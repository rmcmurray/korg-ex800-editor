using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Sanford.Multimedia;
using Sanford.Multimedia.Midi;
using Sanford.Multimedia.Midi.UI;
using KorgEX800Editor.Properties;

namespace KorgEX800Editor
{
    public partial class MainForm : Form
    {
        const int SYSEX_SIZE = 3273;

        static Voice[] Voices = new Voice[64];

        Timer midiTimer = new Timer();
        Timer adsrTimer = new Timer();

        private OutputDevice outDevice = null;
        private InputDevice inDevice = null;

        private int outDeviceID = 0;
        private int inDeviceID = 0;

        private OutputDeviceDialog outDialog = null;
        private InputDeviceDialog inDialog = null;

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        public MainForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void InitializeForm()
        {
            // Initialize the array of voice classes.
            for (int i = 0; i < Voices.Length; ++i)
            {
                // Initialize each individual voice class.
                Voices[i] = new Voice();
                // Add the text (in octal) for each voice to the list box array.
                lstVoices.Items.Add(String.Format("{0} {1}{2}", Resources.UiTextVoice, ((i >> 3) & 7) + 1, (i & 7) + 1));
            }

            // Select the first item.
            lstVoices.SetSelected(0, true);

            // Initialize the MIDI event timer; this is used for MIDI timeouts.
            midiTimer.Tick += new EventHandler(midiTimerProcessor);
            midiTimer.Interval = 5000;

            // Initialize the ADSR event timer; this is used for drawing the initial ADSR.
            adsrTimer.Tick += new EventHandler(adsrTimerProcessor);
            adsrTimer.Interval = 100;
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void InitializeMIDI()
        {
            try
            {
                // Check for MIDI input devices.
                if (InputDevice.DeviceCount == 0)
                {
                    NonCriticalErrorBox(Resources.DialogTextNoInputDevices);
                    // Disable menu items that cannot be used.
                    this.inputDeviceToolStripMenuItem.Enabled = false;
                    this.requestBankToolStripMenuItem.Enabled = false;
                }
                else
                {
                    // Retrieve MIDI device settings.
                    inDeviceID = Properties.Settings.Default.InputDeviceID;
                    // Make sure that the device settings are valid for the current MIDI setup.
                    if (inDeviceID > InputDevice.DeviceCount - 1) inDeviceID = 0;
                    // Initialize the MIDI devices.
                    inDevice = new InputDevice(inDeviceID);
                    // Initialize the MIDI device dialogs.
                    inDialog = new InputDeviceDialog();
                }

                // Check for MIDI output devices.
                if (OutputDevice.DeviceCount == 0)
                {
                    NonCriticalErrorBox(Resources.DialogTextNoOutputDevices);
                    // Disable menu items that cannot be used.
                    this.outputDeviceToolStripMenuItem.Enabled = false;
                    this.sendBankToolStripMenuItem.Enabled = false;
                }
                else
                {
                    // Retrieve MIDI device settings.
                    outDeviceID = Properties.Settings.Default.OutputDeviceID;
                    // Make sure that the device settings are valid for the current MIDI setup.
                    if (outDeviceID > OutputDevice.DeviceCount - 1) outDeviceID = 0;
                    // Initialize the MIDI devices.
                    outDevice = new OutputDevice(outDeviceID);
                    // Initialize the MIDI device dialogs.
                    outDialog = new OutputDeviceDialog();
                }
            }
            catch (Exception ex)
            {
                CriticalErrorBox(String.Format("{0}\n\n{1}", Resources.DialogTextFatalInitError, ex.Message));
            }
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        protected override void OnLoad(EventArgs e)
        {
            InitializeMIDI();
            base.OnLoad(e);
            adsrTimer.Start();
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        protected override void OnClosing(CancelEventArgs e)
        {
            // Check for unsaved data.
            if (this.HasChanges)
            {
                switch (YesNoQuestionBox(Resources.DialogTextUnsavedChanges, false))
                {
                    case DialogResult.Yes:
                        this.saveToolStripMenuItem.PerformClick();
                        break;
                    case DialogResult.No:
                        break;
                }
            }

            adsrTimer.Stop();

            if ((outDevice != null) && (inDevice != null))
            {
                // Save MIDI device settings.
                Properties.Settings.Default.InputDeviceID = inDeviceID;
                Properties.Settings.Default.OutputDeviceID = outDeviceID;
                Properties.Settings.Default.Save();
            }

            base.OnClosing(e);
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        protected override void OnClosed(EventArgs e)
        {
            if (outDevice != null)
            {
                outDevice.Dispose();
            }
            if (inDevice != null)
            {
                inDevice.Dispose();
            }
            base.OnClosed(e);
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void DrawADSR()
        {
            switch (tabMain.SelectedIndex)
            {
                case 0:
                    DrawLines(grpDCO1EnvelopeMap, txtDCO1Attack, txtDCO1Decay, txtDCO1Break, txtDCO1Slope, txtDCO1Sustain, txtDCO1Release, txtDCO1Level);
                    break;
                case 1:
                    DrawLines(grpDCO2EnvelopeMap, txtDCO2Attack, txtDCO2Decay, txtDCO2Break, txtDCO2Slope, txtDCO2Sustain, txtDCO2Release, txtDCO2Level);
                    break;
            }
        }

        private void DrawLines(GroupBox gbx, TextBox atk, TextBox dcy,
            TextBox brk, TextBox slp, TextBox sus, TextBox rel, TextBox lvl)
        {
            // Clear any existing drawing.
            gbx.Refresh();

            if (gbx.Enabled == true)
            {
                const int margin = 10;

                float xOrigin = margin;
                float yOrigin = gbx.Height - margin;
                float xFinish = gbx.Width - margin;
                float yFinish = (margin + 10);

                float xFactor = ((xFinish - xOrigin) / 5) / 31;
                float yFactor = (yOrigin - yFinish) / 31;

                float iLvl = (float)(Convert.ToDouble(lvl.Text) * yFactor);

                float iAtk = (float)(Convert.ToDouble(atk.Text) * xFactor);
                float iDcy = (float)(Convert.ToDouble(dcy.Text) * xFactor);
                float iBrk = (float)(Convert.ToDouble(brk.Text) * (iLvl / 31));
                float iSlp = (float)(Convert.ToDouble(slp.Text) * xFactor);
                float iSus = (float)(Convert.ToDouble(sus.Text) * (iLvl / 31));
                float iRel = (float)(Convert.ToDouble(rel.Text) * xFactor);

                Graphics g;
                g = gbx.CreateGraphics();
                Pen myPen = new Pen(this.ForeColor);

                // Attack
                g.DrawLine(myPen, xOrigin, yOrigin, xOrigin + iAtk, yOrigin - iLvl);
                // Decay
                g.DrawLine(myPen, xOrigin + iAtk, yOrigin - iLvl, xOrigin + iAtk + iDcy, yOrigin - iBrk);
                // Slope
                g.DrawLine(myPen, xOrigin + iAtk + iDcy, yOrigin - iBrk, xOrigin + iAtk + iDcy + iSlp, yOrigin - iSus);
                // Sustain
                g.DrawLine(myPen, xOrigin + iAtk + iDcy + iSlp, yOrigin - iSus, xFinish - iRel, yOrigin - iSus);
                // Release
                g.DrawLine(myPen, xFinish - iRel, yOrigin - iSus, xFinish, yOrigin);

                myPen.Dispose();
                g.Dispose();
            }
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private bool HasChanges
        {
            get
            {
                bool blnHasChanges = false;
                for (int i = 0; i < Voices.Length; ++i) blnHasChanges |= Voices[i].HasChanges;
                return blnHasChanges;
            }
            set
            {
                for (int i = 0; i < Voices.Length; ++i) Voices[i].HasChanges = value;
            }
        }

        #region Digitally Controlled Oscillator (DCO1)

        #region DCO1 Check Boxes and Radio Buttons

        private void rdoDCO1Whole_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                WholeChecked(sender, e);
                rdoDCO2Whole.Checked = true;
            }
        }

        private void rdoDCO1Double_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                DoubleChecked(sender, e);
                rdoDCO2Double.Checked = true;
            }
        }

        private void rdoDCO1High_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                Voices[lstVoices.SelectedIndex].DCO1.Octave.Value = Convert.ToByte(enuOctave.High);
            }
        }

        private void rdoDCO1Mid_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                Voices[lstVoices.SelectedIndex].DCO1.Octave.Value = Convert.ToByte(enuOctave.Mid);
            }
        }

        private void rdoDCO1Low_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                Voices[lstVoices.SelectedIndex].DCO1.Octave.Value = Convert.ToByte(enuOctave.Low);
            }
        }

        private void chkDCO1Harmonic16_CheckedChanged(object sender, EventArgs e)
        {
            SetHarmonics(chkDCO1Harmonic16, Voices[lstVoices.SelectedIndex].DCO1, Convert.ToByte(enuHarmonics.Sixteenth));
        }

        private void chkDCO1Harmonic8_CheckedChanged(object sender, EventArgs e)
        {
            SetHarmonics(chkDCO1Harmonic8, Voices[lstVoices.SelectedIndex].DCO1, Convert.ToByte(enuHarmonics.Eighth));
        }

        private void chkDCO1Harmonic4_CheckedChanged(object sender, EventArgs e)
        {
            SetHarmonics(chkDCO1Harmonic4, Voices[lstVoices.SelectedIndex].DCO1, Convert.ToByte(enuHarmonics.Fourth));
        }

        private void chkDCO1Harmonic2_CheckedChanged(object sender, EventArgs e)
        {
            SetHarmonics(chkDCO1Harmonic2, Voices[lstVoices.SelectedIndex].DCO1, Convert.ToByte(enuHarmonics.Second));
        }

        private void rdoDCO1Sawtooth_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                Voices[lstVoices.SelectedIndex].DCO1.Waveform.Value = Convert.ToByte(enuWaveform.Sawtooth);
            }
        }

        private void rdoDCO1Squarewave_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                Voices[lstVoices.SelectedIndex].DCO1.Waveform.Value = Convert.ToByte(enuWaveform.Squarewave);
            }
        }

        #endregion // DCO1 Check Boxes and Radio Buttons

        #region DCO1 Sliders

        private void trkDCO1Attack_Scroll(object sender, EventArgs e)
        {
            txtDCO1Attack.Text = trkDCO1Attack.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO1.Envelope.Attack.Value = Convert.ToByte(trkDCO1Attack.Value);
            DrawADSR();
        }

        private void trkDCO1Decay_Scroll(object sender, EventArgs e)
        {
            txtDCO1Decay.Text = trkDCO1Decay.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO1.Envelope.Decay.Value = Convert.ToByte(trkDCO1Decay.Value);
            DrawADSR();
        }

        private void trkDCO1Break_Scroll(object sender, EventArgs e)
        {
            txtDCO1Break.Text = trkDCO1Break.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO1.Envelope.Break.Value = Convert.ToByte(trkDCO1Break.Value);
            DrawADSR();
        }

        private void trkDCO1Slope_Scroll(object sender, EventArgs e)
        {
            txtDCO1Slope.Text = trkDCO1Slope.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO1.Envelope.Slope.Value = Convert.ToByte(trkDCO1Slope.Value);
            DrawADSR();
        }

        private void trkDCO1Sustain_Scroll(object sender, EventArgs e)
        {
            txtDCO1Sustain.Text = trkDCO1Sustain.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO1.Envelope.Sustain.Value = Convert.ToByte(trkDCO1Sustain.Value);
            DrawADSR();
        }

        private void trkDCO1Release_Scroll(object sender, EventArgs e)
        {
            txtDCO1Release.Text = trkDCO1Release.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO1.Envelope.Release.Value = Convert.ToByte(trkDCO1Release.Value);
            DrawADSR();
        }

        private void trkDCO1Level_Scroll(object sender, EventArgs e)
        {
            txtDCO1Level.Text = trkDCO1Level.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO1.Level.Value = Convert.ToByte(trkDCO1Level.Value);
            DrawADSR();
        }

        private void trkDCO1Detune_Scroll(object sender, EventArgs e)
        {
            txtDCO1Detune.Text = trkDCO1Detune.Value.ToString();
            txtDCO2Detune.Text = trkDCO1Detune.Value.ToString();
            trkDCO2Detune.Value = trkDCO1Detune.Value;
            Voices[lstVoices.SelectedIndex].DCODetune.Value = Convert.ToByte(trkDCO1Detune.Value);
        }

        private void trkDCO1Interval_Scroll(object sender, EventArgs e)
        {
            txtDCO1Interval.Text = trkDCO1Interval.Value.ToString();
            txtDCO2Interval.Text = trkDCO1Interval.Value.ToString();
            trkDCO2Interval.Value = trkDCO1Interval.Value;
            Voices[lstVoices.SelectedIndex].DCOInterval.Value = Convert.ToByte(trkDCO1Interval.Value);
        }

        #endregion // end of DCO1 Sliders

        #endregion // end of DCO1

        #region Digitally Controlled Oscillator (DCO2)

        #region DCO2 Check Boxes and Radio Buttons

        private void rdoDCO2Whole_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                WholeChecked(sender, e);
                rdoDCO1Whole.Checked = true;
            }
        }

        private void rdoDCO2Double_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                DoubleChecked(sender, e);
                rdoDCO1Double.Checked = true;
            }
        }

        private void rdoDCO2High_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                Voices[lstVoices.SelectedIndex].DCO2.Octave.Value = Convert.ToByte(enuOctave.High);
            }
        }

        private void rdoDCO2Mid_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                Voices[lstVoices.SelectedIndex].DCO2.Octave.Value = Convert.ToByte(enuOctave.Mid);
            }
        }

        private void rdoDCO2Low_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                Voices[lstVoices.SelectedIndex].DCO2.Octave.Value = Convert.ToByte(enuOctave.Low);
            }
        }

        private void chkDCO2Harmonic16_CheckedChanged(object sender, EventArgs e)
        {
            SetHarmonics(chkDCO2Harmonic16, Voices[lstVoices.SelectedIndex].DCO2, Convert.ToByte(enuHarmonics.Sixteenth));
        }

        private void chkDCO2Harmonic8_CheckedChanged(object sender, EventArgs e)
        {
            SetHarmonics(chkDCO2Harmonic8, Voices[lstVoices.SelectedIndex].DCO2, Convert.ToByte(enuHarmonics.Eighth));
        }

        private void chkDCO2Harmonic4_CheckedChanged(object sender, EventArgs e)
        {
            SetHarmonics(chkDCO2Harmonic4, Voices[lstVoices.SelectedIndex].DCO2, Convert.ToByte(enuHarmonics.Fourth));
        }

        private void chkDCO2Harmonic2_CheckedChanged(object sender, EventArgs e)
        {
            SetHarmonics(chkDCO2Harmonic2, Voices[lstVoices.SelectedIndex].DCO2, Convert.ToByte(enuHarmonics.Second));
        }

        private void rdoDCO2Sawtooth_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                Voices[lstVoices.SelectedIndex].DCO2.Waveform.Value = Convert.ToByte(enuWaveform.Sawtooth);
            }
        }

        private void rdoDCO2Squarewave_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                Voices[lstVoices.SelectedIndex].DCO2.Waveform.Value = Convert.ToByte(enuWaveform.Squarewave);
            }
        }

        #endregion

        #region DCO2 Sliders

        private void trkDCO2Attack_Scroll(object sender, EventArgs e)
        {
            txtDCO2Attack.Text = trkDCO2Attack.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO2.Envelope.Attack.Value = Convert.ToByte(trkDCO2Attack.Value);
            DrawADSR();
        }

        private void trkDCO2Decay_Scroll(object sender, EventArgs e)
        {
            txtDCO2Decay.Text = trkDCO2Decay.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO2.Envelope.Decay.Value = Convert.ToByte(trkDCO2Decay.Value);
            DrawADSR();
        }

        private void trkDCO2Break_Scroll(object sender, EventArgs e)
        {
            txtDCO2Break.Text = trkDCO2Break.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO2.Envelope.Break.Value = Convert.ToByte(trkDCO2Break.Value);
            DrawADSR();
        }

        private void trkDCO2Slope_Scroll(object sender, EventArgs e)
        {
            txtDCO2Slope.Text = trkDCO2Slope.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO2.Envelope.Slope.Value = Convert.ToByte(trkDCO2Slope.Value);
            DrawADSR();
        }

        private void trkDCO2Sustain_Scroll(object sender, EventArgs e)
        {
            txtDCO2Sustain.Text = trkDCO2Sustain.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO2.Envelope.Sustain.Value = Convert.ToByte(trkDCO2Sustain.Value);
            DrawADSR();
        }

        private void trkDCO2Release_Scroll(object sender, EventArgs e)
        {
            txtDCO2Release.Text = trkDCO2Release.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO2.Envelope.Release.Value = Convert.ToByte(trkDCO2Release.Value);
            DrawADSR();
        }

        private void trkDCO2Level_Scroll(object sender, EventArgs e)
        {
            txtDCO2Level.Text = trkDCO2Level.Value.ToString();
            Voices[lstVoices.SelectedIndex].DCO2.Level.Value = Convert.ToByte(trkDCO2Level.Value);
            DrawADSR();
        }

        private void trkDCO2Detune_Scroll(object sender, EventArgs e)
        {
            txtDCO2Detune.Text = trkDCO2Detune.Value.ToString();
            txtDCO1Detune.Text = trkDCO2Detune.Value.ToString();
            trkDCO1Detune.Value = trkDCO2Detune.Value;
            Voices[lstVoices.SelectedIndex].DCODetune.Value = Convert.ToByte(trkDCO2Detune.Value);
        }

        private void trkDCO2Interval_Scroll(object sender, EventArgs e)
        {
            txtDCO2Interval.Text = trkDCO2Interval.Value.ToString();
            txtDCO1Interval.Text = trkDCO2Interval.Value.ToString();
            trkDCO1Interval.Value = trkDCO2Interval.Value;
            Voices[lstVoices.SelectedIndex].DCOInterval.Value = Convert.ToByte(trkDCO2Interval.Value);
        }

        #endregion // end of DCO2 Sliders

        #endregion // end of DCO2

        #region Voltage Controlled Filter (VCF)

        #region VCF Check Boxes and Radio Buttons

        private void rdoChorus_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                if (sender == rdoChorusOn)
                {
                    Voices[lstVoices.SelectedIndex].Chorus.Value = (byte)enuChorus.On;
                    rdoChorusOn.Checked = true;
                }
                else if (sender == rdoChorusOff)
                {
                    Voices[lstVoices.SelectedIndex].Chorus.Value = (byte)enuChorus.Off;
                    rdoChorusOff.Checked = true;
                }
            }
        }

        private void rdoKBDTrack_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                if (sender == rdoKBDTrackFull)
                {
                    Voices[lstVoices.SelectedIndex].VCF.KeyboardTracking.Value = (byte)enuKbdTrack.Full;
                    rdoKBDTrackFull.Checked = true;
                }
                else if (sender == rdoKBDTrackHalf)
                {
                    Voices[lstVoices.SelectedIndex].VCF.KeyboardTracking.Value = (byte)enuKbdTrack.Half;
                    rdoKBDTrackHalf.Checked = true;
                }
                else if (sender == rdoKBDTrackOff)
                {
                    Voices[lstVoices.SelectedIndex].VCF.KeyboardTracking.Value = (byte)enuKbdTrack.Off;
                    rdoKBDTrackOff.Checked = true;
                }
            }
        }

        private void rdoPolarity_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                if (sender == rdoPolarityUp)
                {
                    Voices[lstVoices.SelectedIndex].VCF.Polarity.Value = (byte)enuPolarity.Up;
                    rdoPolarityUp.Checked = true;
                }
                else if (sender == rdoPolarityDown)
                {
                    Voices[lstVoices.SelectedIndex].VCF.Polarity.Value = (byte)enuPolarity.Down;
                    rdoPolarityDown.Checked = true;
                }
            }
        }

        private void rdoTrigger_CheckedChanged(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                if (sender == rdoTriggerMulti)
                {
                    Voices[lstVoices.SelectedIndex].VCF.Trigger.Value = (byte)enuTrigger.Multi;
                    rdoTriggerMulti.Checked = true;
                }
                else if (sender == rdoTriggerSingle)
                {
                    Voices[lstVoices.SelectedIndex].VCF.Trigger.Value = (byte)enuTrigger.Single;
                    rdoTriggerSingle.Checked = true;
                }
            }
        }

        #endregion // end of VCF Check Boxes and Radio Buttons

        #region VCF Sliders

        private void trkVCFAttack_Scroll(object sender, EventArgs e)
        {
            txtVCFAttack.Text = trkVCFAttack.Value.ToString();
            Voices[lstVoices.SelectedIndex].VCF.Envelope.Attack.Value = Convert.ToByte(trkVCFAttack.Value);
        }

        private void trkVCFDecay_Scroll(object sender, EventArgs e)
        {
            txtVCFDecay.Text = trkVCFDecay.Value.ToString();
            Voices[lstVoices.SelectedIndex].VCF.Envelope.Decay.Value = Convert.ToByte(trkVCFDecay.Value);
        }

        private void trkVCFBreak_Scroll(object sender, EventArgs e)
        {
            txtVCFBreak.Text = trkVCFBreak.Value.ToString();
            Voices[lstVoices.SelectedIndex].VCF.Envelope.Break.Value = Convert.ToByte(trkVCFBreak.Value);
        }

        private void trkVCFSlope_Scroll(object sender, EventArgs e)
        {
            txtVCFSlope.Text = trkVCFSlope.Value.ToString();
            Voices[lstVoices.SelectedIndex].VCF.Envelope.Slope.Value = Convert.ToByte(trkVCFSlope.Value);
        }

        private void trkVCFSustain_Scroll(object sender, EventArgs e)
        {
            txtVCFSustain.Text = trkVCFSustain.Value.ToString();
            Voices[lstVoices.SelectedIndex].VCF.Envelope.Sustain.Value = Convert.ToByte(trkVCFSustain.Value);
        }

        private void trkVCFRelease_Scroll(object sender, EventArgs e)
        {
            txtVCFRelease.Text = trkVCFRelease.Value.ToString();
            Voices[lstVoices.SelectedIndex].VCF.Envelope.Release.Value = Convert.ToByte(trkVCFRelease.Value);
        }

        private void trkNoise_Scroll(object sender, EventArgs e)
        {
            txtNoise.Text = trkNoise.Value.ToString();
            Voices[lstVoices.SelectedIndex].Noise.Value = Convert.ToByte(trkNoise.Value);
        }

        private void trkVCFCutoff_Scroll(object sender, EventArgs e)
        {
            txtVCFCutoff.Text = trkVCFCutoff.Value.ToString();
            Voices[lstVoices.SelectedIndex].VCF.Cutoff.Value = Convert.ToByte(trkVCFCutoff.Value);
        }

        private void trkVCFResonance_Scroll(object sender, EventArgs e)
        {
            txtVCFResonance.Text = trkVCFResonance.Value.ToString();
            Voices[lstVoices.SelectedIndex].VCF.Resonance.Value = Convert.ToByte(trkVCFResonance.Value);
        }

        private void trkVCFEGIntensity_Scroll(object sender, EventArgs e)
        {
            txtVCFEGIntensity.Text = trkVCFEGIntensity.Value.ToString();
            Voices[lstVoices.SelectedIndex].VCF.EGIntensity.Value = Convert.ToByte(trkVCFEGIntensity.Value);
        }

        #endregion // end of VCF Sliders

        #endregion // end of Voltage Controlled Filter

        #region Modulation Generator (MG)

        private void trkMGFrequency_Scroll(object sender, EventArgs e)
        {
            txtMGFrequency.Text = trkMGFrequency.Value.ToString();
            Voices[lstVoices.SelectedIndex].MG.Frequency.Value = Convert.ToByte(trkMGFrequency.Value);
        }

        private void trkMGDelay_Scroll(object sender, EventArgs e)
        {
            txtMGDelay.Text = trkMGDelay.Value.ToString();
            Voices[lstVoices.SelectedIndex].MG.Delay.Value = Convert.ToByte(trkMGDelay.Value);
        }

        private void trkMGDCO_Scroll(object sender, EventArgs e)
        {
            txtMGDCO.Text = trkMGDCO.Value.ToString();
            Voices[lstVoices.SelectedIndex].MG.DCO.Value = Convert.ToByte(trkMGDCO.Value);
        }

        private void trkMGVCF_Scroll(object sender, EventArgs e)
        {
            txtMGVCF.Text = trkMGVCF.Value.ToString();
            Voices[lstVoices.SelectedIndex].MG.VCF.Value = Convert.ToByte(trkMGVCF.Value);
        }

        #endregion // end of Modulation Generator

        #region Utility Functions

        private void UpdateDCOModeWarningText()
        {
            if (rdoDCO1Whole.Checked == true)
            {
                txtDCO1ModeWarning.Text = Resources.UiTextDCOModeWhole;
                txtDCO2ModeWarning.Text = Resources.UiTextDCOModeWhole;
                txtDCO1ModeWarning.BackColor = SystemColors.Info;
                txtDCO2ModeWarning.BackColor = SystemColors.Info;
                txtDCO1ModeWarning.Enabled = true;
                txtDCO2ModeWarning.Enabled = true;
            }
            else
            {
                txtDCO1ModeWarning.Text = Resources.UiTextDCOModeDouble;
                txtDCO2ModeWarning.Text = Resources.UiTextDCOModeDouble;
                txtDCO1ModeWarning.BackColor = SystemColors.Control;
                txtDCO2ModeWarning.BackColor = SystemColors.Control;
                txtDCO1ModeWarning.Enabled = false;
                txtDCO2ModeWarning.Enabled = false;
            }
        }

        private void WholeChecked(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                grpDCO1Detune.Enabled = false;
                grpDCO1Interval.Enabled = false;
                grpDCO2Detune.Enabled = false;
                grpDCO2Interval.Enabled = false;

                grpDCO2Attack.Enabled = false;
                grpDCO2Decay.Enabled = false;
                grpDCO2Break.Enabled = false;
                grpDCO2Slope.Enabled = false;
                grpDCO2Sustain.Enabled = false;
                grpDCO2Release.Enabled = false;

                grpDCO2Octave.Enabled = false;
                grpDCO2Harmonics.Enabled = false;
                grpDCO2Waveform.Enabled = false;
                grpDCO2Level.Enabled = false;

                grpDCO2EnvelopeMap.Enabled = false;

                UpdateDCOModeWarningText();

                Voices[lstVoices.SelectedIndex].DCOMode.Value = Convert.ToByte(enuDcoMode.Whole);
                lstVoices.SetSelected(lstVoices.SelectedIndex, true);
            }
        }

        private void DoubleChecked(object sender, EventArgs e)
        {
            // filter out unwarranted events
            if (((RadioButton)sender).Checked == true)
            {
                grpDCO1Detune.Enabled = true;
                grpDCO1Interval.Enabled = true;
                grpDCO2Detune.Enabled = true;
                grpDCO2Interval.Enabled = true;

                grpDCO2Attack.Enabled = true;
                grpDCO2Decay.Enabled = true;
                grpDCO2Break.Enabled = true;
                grpDCO2Slope.Enabled = true;
                grpDCO2Sustain.Enabled = true;
                grpDCO2Release.Enabled = true;

                grpDCO2Octave.Enabled = true;
                grpDCO2Harmonics.Enabled = true;
                grpDCO2Waveform.Enabled = true;
                grpDCO2Level.Enabled = true;

                grpDCO2EnvelopeMap.Enabled = true;

                UpdateDCOModeWarningText();

                Voices[lstVoices.SelectedIndex].DCOMode.Value = Convert.ToByte(enuDcoMode.Double);
                lstVoices.SetSelected(lstVoices.SelectedIndex, true);
            }
        }

        private void SetHarmonics(CheckBox c, DCO d, Byte b)
        {
            switch (c.Checked)
            {
                case true:
                    d.Harmonics.Value |= b;
                    break;
                case false:
                    d.Harmonics.Value &= Convert.ToByte(enuHarmonics.All - b);
                    break;
            }
        }

        private void GetHarmonics(CheckBox c, DCO d, Byte b)
        {
            c.Checked = ((d.Harmonics.Value & b) == b) ? true : false;
        }

        private DialogResult YesNoQuestionBox(string message, bool showCancel)
        {
            return MessageBox.Show(
                message, Resources.ApplicationTitle,
                (showCancel == true) ? MessageBoxButtons.YesNoCancel : MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void CriticalErrorBox(string message)
        {
            MessageBox.Show(
                message, Resources.ApplicationTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
            Close();
        }

        private void NonCriticalErrorBox(string message)
        {
            MessageBox.Show(
                message, Resources.ApplicationTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void InformationBox(string message)
        {
            MessageBox.Show(
                message, Resources.ApplicationTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void FillData(byte[] data, int start, int end, byte fill)
        {
            for (int i = start; i <= end; ++i) data[i] = fill;
        }

        private void SysexToVoices(byte[] sysexData)
        {
            if (sysexData.Length == SYSEX_SIZE)
            {
                for (int i = 0; i < Voices.Length; ++i)
                {
                    byte[] voice = new byte[Voices[i].Length];
                    for (int j = 0; j < Voices[i].Length; ++j)
                    {
                        voice[j] = Convert.ToByte(
                            sysexData[0x0244 + (i * voice.Length * 2) + (j * 2)] |       // LSB
                            sysexData[0x0245 + (i * voice.Length * 2) + (j * 2)] << 4);  //MSB
                    }
                    Voices[i].SysexData = voice;
                }
            }
        }

        private byte[] VoicesToSysex()
        {
            byte[] sysexData = new byte[SYSEX_SIZE];

            sysexData[0] = 0xF0;                    // Start of SysEx
            sysexData[1] = 0x42;                    // Korg ID
            sysexData[2] = 0x21;                    // Format ID
            sysexData[3] = 0x01;                    // EX-800 ID

            FillData(sysexData, 0x0004, 0x0005, 0); // Midi Receive Channel
            FillData(sysexData, 0x0006, 0x0205, 0); // Sequencer Data
            FillData(sysexData, 0x0206, 0x0217, 0); // Undefined

            sysexData[0x0218] = 0x00;               // Pitch Bend Depth (LSB)
            sysexData[0x0219] = 0x04;               // Pitch Bend Depth (MSB)

            FillData(sysexData, 0x021A, 0x0243, 0); // Undefined

            // Loop through all of the voices.
            for (int i = 0; i < Voices.Length; ++i)
            {
                // Get system exclusive data for a voice.
                byte[] voice = Voices[i].SysexData;

                // Loop through all of the voice data.
                for (int j = 0; j < voice.Length; ++j)
                {
                    // Add the LSB/MSB for each data byte.
                    sysexData[0x0244 + (i * voice.Length * 2) + (j * 2)] = (byte)(voice[j] & 15); // (LSB)
                    sysexData[0x0245 + (i * voice.Length * 2) + (j * 2)] = (byte)(voice[j] >> 4); // (MSB)
                }
            }

            FillData(sysexData, 0x0CC4, 0x0CC5, 0); // Undefined

            int crc = 0;

            for (int i = 0x0004; i < 0x0CC6; i += 2)
            {
                crc += (sysexData[i] + (sysexData[i + 1] << 4));
                crc &= 255;
            }

            sysexData[0x0CC6] = (byte)(crc & 15);   // checksum (LSB)
            sysexData[0x0CC7] = (byte)(crc >> 4);   // checksum (MSB)

            sysexData[0x0CC8] = 0xF7;               // EOX

            return sysexData;
        }

        #endregion // end of Utility Functions

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void lstVoices_SelectedIndexChanged(object sender, EventArgs e)
        {

            #region DCO1 Information

            trkDCO1Level.Value = Voices[lstVoices.SelectedIndex].DCO1.Level.Value;
            txtDCO1Level.Text = trkDCO1Level.Value.ToString();

            trkDCO1Attack.Value = Voices[lstVoices.SelectedIndex].DCO1.Envelope.Attack.Value;
            txtDCO1Attack.Text = trkDCO1Attack.Value.ToString();

            trkDCO1Decay.Value = Voices[lstVoices.SelectedIndex].DCO1.Envelope.Decay.Value;
            txtDCO1Decay.Text = trkDCO1Decay.Value.ToString();

            trkDCO1Break.Value = Voices[lstVoices.SelectedIndex].DCO1.Envelope.Break.Value;
            txtDCO1Break.Text = trkDCO1Break.Value.ToString();

            trkDCO1Slope.Value = Voices[lstVoices.SelectedIndex].DCO1.Envelope.Slope.Value;
            txtDCO1Slope.Text = trkDCO1Slope.Value.ToString();

            trkDCO1Sustain.Value = Voices[lstVoices.SelectedIndex].DCO1.Envelope.Sustain.Value;
            txtDCO1Sustain.Text = trkDCO1Sustain.Value.ToString();

            trkDCO1Release.Value = Voices[lstVoices.SelectedIndex].DCO1.Envelope.Release.Value;
            txtDCO1Release.Text = trkDCO1Release.Value.ToString();

            GetHarmonics(chkDCO1Harmonic16, Voices[lstVoices.SelectedIndex].DCO1, Convert.ToByte(enuHarmonics.Sixteenth));
            GetHarmonics(chkDCO1Harmonic8, Voices[lstVoices.SelectedIndex].DCO1, Convert.ToByte(enuHarmonics.Eighth));
            GetHarmonics(chkDCO1Harmonic4, Voices[lstVoices.SelectedIndex].DCO1, Convert.ToByte(enuHarmonics.Fourth));
            GetHarmonics(chkDCO1Harmonic2, Voices[lstVoices.SelectedIndex].DCO1, Convert.ToByte(enuHarmonics.Second));

            switch (Voices[lstVoices.SelectedIndex].DCO1.Octave.Value)
            {
                case (byte)enuOctave.High:
                    rdoDCO1High.Checked = true;
                    break;
                case (byte)enuOctave.Mid:
                    rdoDCO1Mid.Checked = true;
                    break;
                case (byte)enuOctave.Low:
                    rdoDCO1Low.Checked = true;
                    break;
            }

            switch (Voices[lstVoices.SelectedIndex].DCO1.Waveform.Value)
            {
                case (byte)enuWaveform.Sawtooth:
                    rdoDCO1Sawtooth.Checked = true;
                    break;
                case (byte)enuWaveform.Squarewave:
                    rdoDCO1Squarewave.Checked = true;
                    break;
            }

            #endregion

            #region DCO2 Information

            trkDCO2Level.Value = Voices[lstVoices.SelectedIndex].DCO2.Level.Value;
            txtDCO2Level.Text = trkDCO2Level.Value.ToString();

            trkDCO2Attack.Value = Voices[lstVoices.SelectedIndex].DCO2.Envelope.Attack.Value;
            txtDCO2Attack.Text = trkDCO2Attack.Value.ToString();

            trkDCO2Decay.Value = Voices[lstVoices.SelectedIndex].DCO2.Envelope.Decay.Value;
            txtDCO2Decay.Text = trkDCO2Decay.Value.ToString();

            trkDCO2Break.Value = Voices[lstVoices.SelectedIndex].DCO2.Envelope.Break.Value;
            txtDCO2Break.Text = trkDCO2Break.Value.ToString();

            trkDCO2Slope.Value = Voices[lstVoices.SelectedIndex].DCO2.Envelope.Slope.Value;
            txtDCO2Slope.Text = trkDCO2Slope.Value.ToString();

            trkDCO2Sustain.Value = Voices[lstVoices.SelectedIndex].DCO2.Envelope.Sustain.Value;
            txtDCO2Sustain.Text = trkDCO2Sustain.Value.ToString();

            trkDCO2Release.Value = Voices[lstVoices.SelectedIndex].DCO2.Envelope.Release.Value;
            txtDCO2Release.Text = trkDCO2Release.Value.ToString();

            GetHarmonics(chkDCO2Harmonic16, Voices[lstVoices.SelectedIndex].DCO2, Convert.ToByte(enuHarmonics.Sixteenth));
            GetHarmonics(chkDCO2Harmonic8, Voices[lstVoices.SelectedIndex].DCO2, Convert.ToByte(enuHarmonics.Eighth));
            GetHarmonics(chkDCO2Harmonic4, Voices[lstVoices.SelectedIndex].DCO2, Convert.ToByte(enuHarmonics.Fourth));
            GetHarmonics(chkDCO2Harmonic2, Voices[lstVoices.SelectedIndex].DCO2, Convert.ToByte(enuHarmonics.Second));

            switch (Voices[lstVoices.SelectedIndex].DCO2.Octave.Value)
            {
                case (byte)enuOctave.High:
                    rdoDCO2High.Checked = true;
                    break;
                case (byte)enuOctave.Mid:
                    rdoDCO2Mid.Checked = true;
                    break;
                case (byte)enuOctave.Low:
                    rdoDCO2Low.Checked = true;
                    break;
            }

            switch (Voices[lstVoices.SelectedIndex].DCO2.Waveform.Value)
            {
                case (byte)enuWaveform.Sawtooth:
                    rdoDCO2Sawtooth.Checked = true;
                    break;
                case (byte)enuWaveform.Squarewave:
                    rdoDCO2Squarewave.Checked = true;
                    break;
            }

            #endregion

            #region DCO Mode Information

            if (Voices[lstVoices.SelectedIndex].DCOMode.Value == Convert.ToByte(enuDcoMode.Double))
            {
                rdoDCO1Double.Checked = true;
                rdoDCO2Double.Checked = true;
                rdoDCO1Whole.Checked = false;
                rdoDCO2Whole.Checked = false;
                txtDCO1ModeWarning.Text = Resources.UiTextDCOModeDouble;
            }
            else
            {
                rdoDCO1Double.Checked = false;
                rdoDCO2Double.Checked = false;
                rdoDCO1Whole.Checked = true;
                rdoDCO2Whole.Checked = true;
                txtDCO1ModeWarning.Text = Resources.UiTextDCOModeWhole;
            }

            trkDCO1Detune.Value = Voices[lstVoices.SelectedIndex].DCODetune.Value;
            txtDCO1Detune.Text = trkDCO1Detune.Value.ToString();
            trkDCO2Detune.Value = Voices[lstVoices.SelectedIndex].DCODetune.Value;
            txtDCO2Detune.Text = trkDCO2Detune.Value.ToString();

            trkDCO1Interval.Value = Voices[lstVoices.SelectedIndex].DCOInterval.Value;
            txtDCO1Interval.Text = trkDCO1Interval.Value.ToString();
            trkDCO2Interval.Value = Voices[lstVoices.SelectedIndex].DCOInterval.Value;
            txtDCO2Interval.Text = trkDCO2Interval.Value.ToString();

            #endregion

            #region VCF Information

            trkVCFAttack.Value = Voices[lstVoices.SelectedIndex].VCF.Envelope.Attack.Value;
            txtVCFAttack.Text = trkVCFAttack.Value.ToString();

            trkVCFDecay.Value = Voices[lstVoices.SelectedIndex].VCF.Envelope.Decay.Value;
            txtVCFDecay.Text = trkVCFDecay.Value.ToString();

            trkVCFBreak.Value = Voices[lstVoices.SelectedIndex].VCF.Envelope.Break.Value;
            txtVCFBreak.Text = trkVCFBreak.Value.ToString();

            trkVCFSlope.Value = Voices[lstVoices.SelectedIndex].VCF.Envelope.Slope.Value;
            txtVCFSlope.Text = trkVCFSlope.Value.ToString();

            trkVCFSustain.Value = Voices[lstVoices.SelectedIndex].VCF.Envelope.Sustain.Value;
            txtVCFSustain.Text = trkVCFSustain.Value.ToString();

            trkVCFRelease.Value = Voices[lstVoices.SelectedIndex].VCF.Envelope.Release.Value;
            txtVCFRelease.Text = trkVCFRelease.Value.ToString();

            trkVCFCutoff.Value = Voices[lstVoices.SelectedIndex].VCF.Cutoff.Value;
            txtVCFCutoff.Text = trkVCFCutoff.Value.ToString();

            trkVCFResonance.Value = Voices[lstVoices.SelectedIndex].VCF.Resonance.Value;
            txtVCFResonance.Text = trkVCFResonance.Value.ToString();

            trkVCFEGIntensity.Value = Voices[lstVoices.SelectedIndex].VCF.EGIntensity.Value;
            txtVCFEGIntensity.Text = trkVCFEGIntensity.Value.ToString();

            trkNoise.Value = Voices[lstVoices.SelectedIndex].Noise.Value;
            txtNoise.Text = trkNoise.Value.ToString();

            switch (Voices[lstVoices.SelectedIndex].Chorus.Value)
            {
                case (byte)enuChorus.On:
                    rdoChorusOn.Checked = true;
                    rdoChorusOff.Checked = false;
                    break;
                case (byte)enuChorus.Off:
                    rdoChorusOn.Checked = false;
                    rdoChorusOff.Checked = true;
                    break;
            }

            switch (Voices[lstVoices.SelectedIndex].VCF.KeyboardTracking.Value)
            {
                case (byte)enuKbdTrack.Full:
                    rdoKBDTrackFull.Checked = true;
                    rdoKBDTrackHalf.Checked = false;
                    rdoKBDTrackOff.Checked = false;
                    break;
                case (byte)enuKbdTrack.Half:
                    rdoKBDTrackFull.Checked = false;
                    rdoKBDTrackHalf.Checked = true;
                    rdoKBDTrackOff.Checked = false;
                    break;
                case (byte)enuKbdTrack.Off:
                    rdoKBDTrackFull.Checked = false;
                    rdoKBDTrackHalf.Checked = false;
                    rdoKBDTrackOff.Checked = true;
                    break;
            }

            switch (Voices[lstVoices.SelectedIndex].VCF.Polarity.Value)
            {
                case (byte)enuPolarity.Up:
                    rdoPolarityUp.Checked = true;
                    rdoPolarityDown.Checked = false;
                    break;
                case (byte)enuPolarity.Down:
                    rdoPolarityUp.Checked = false;
                    rdoPolarityDown.Checked = true;
                    break;
            }

            switch (Voices[lstVoices.SelectedIndex].VCF.Trigger.Value)
            {
                case (byte)enuTrigger.Multi:
                    rdoTriggerMulti.Checked = true;
                    rdoTriggerSingle.Checked = false;
                    break;
                case (byte)enuTrigger.Single:
                    rdoTriggerMulti.Checked = false;
                    rdoTriggerSingle.Checked = true;
                    break;
            }

            #endregion

            #region MG Information

            trkMGFrequency.Value = Voices[lstVoices.SelectedIndex].MG.Frequency.Value;
            txtMGFrequency.Text = trkMGFrequency.Value.ToString();

            trkMGDelay.Value = Voices[lstVoices.SelectedIndex].MG.Delay.Value;
            txtMGDelay.Text = trkMGDelay.Value.ToString();

            trkMGDCO.Value = Voices[lstVoices.SelectedIndex].MG.DCO.Value;
            txtMGDCO.Text = trkMGDCO.Value.ToString();

            trkMGVCF.Value = Voices[lstVoices.SelectedIndex].MG.VCF.Value;
            txtMGVCF.Text = trkMGVCF.Value.ToString();

            #endregion

            DrawADSR();
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void inputDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inDialog.StartPosition = FormStartPosition.CenterScreen;
            if (inDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    inDeviceID = inDialog.InputDeviceID;
                    inDevice.Dispose();
                    inDevice = new InputDevice(inDeviceID);
                }
                catch (Exception ex)
                {
                    CriticalErrorBox(String.Format("{0}\n\n{1}", Resources.DialogTextFatalInitInputError, ex.Message));
                }
            }
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void outputDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outDialog.StartPosition = FormStartPosition.CenterScreen;
            if (outDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    outDeviceID = outDialog.OutputDeviceID;
                    outDevice.Dispose();
                    outDevice = new OutputDevice(outDeviceID);
                }
                catch (Exception ex)
                {
                    CriticalErrorBox(String.Format("{0}\n\n{1}", Resources.DialogTextFatalInitOutputError, ex.Message));
                }
            }
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.HasChanges)
            {
                switch (YesNoQuestionBox(Resources.DialogTextUnsavedChanges, true))
                {
                    case DialogResult.Yes:
                        this.saveToolStripMenuItem.PerformClick();
                        break;
                    case DialogResult.No:
                        this.HasChanges = false;
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            if (sender == emptyToolStripMenuItem)
            {
                emptyToolStripMenuItem_Click(sender, e);
            }
            else if (sender == randomToolStripMenuItem)
            {
                randomToolStripMenuItem_Click(sender, e);
            }
            else if (sender == exitToolStripMenuItem)
            {
                exitToolStripMenuItem_Click(sender, e);
            }
            else if (sender == openToolStripMenuItem)
            {
                openToolStripMenuItem_Click(sender, e);
            }
            else if (sender == requestBankToolStripMenuItem)
            {
                requestBankToolStripMenuItem_Click(sender, e);
            }
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void emptyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Voices.Length; ++i) Voices[i].Reset();
            lstVoices.SetSelected(0, true);
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Voices.Length; ++i) Voices[i].Randomize();
            lstVoices.SetSelected(0, true);
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = Resources.DialogTextSysexExtension;
            saveDialog.Filter = Resources.DialogTextSysexFilter;
            saveDialog.Title = String.Format("{0} - {1}", Resources.ApplicationTitle, Resources.DialogTextSaveFile);
            DialogResult saveResult = saveDialog.ShowDialog();

            if (saveResult == DialogResult.OK)
            {
                // Retrieve the voice data in sysex format.
                byte[] sysexData = VoicesToSysex();
                try
                {
                    // Open the file for writing.
                    FileStream file = File.Open(saveDialog.FileName, FileMode.Create, FileAccess.Write);
                    // Write the data to the file.
                    file.Write(sysexData, 0, SYSEX_SIZE);
                    // Close the file.
                    file.Dispose();
                }
                catch (Exception ex)
                {
                    // Display the error.
                    NonCriticalErrorBox(String.Format("{0}\n\n{1}", Resources.DialogTextGenericErrorOccurred, ex.Message));
                }
                // Flag the data as unchanged.
                this.HasChanges = false;
            }
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.DefaultExt = Resources.DialogTextSysexExtension;
            openDialog.Filter = Resources.DialogTextSysexFilter;
            openDialog.Title = String.Format("{0} - {1}", Resources.ApplicationTitle, Resources.DialogTextOpenFile);
            openDialog.Multiselect = false;
            DialogResult openResult = openDialog.ShowDialog();

            if (openResult == DialogResult.OK)
            {
                if (File.Exists(openDialog.FileName))
                {
                    // Open the file for reading.
                    FileStream file = File.Open(openDialog.FileName, FileMode.Open, FileAccess.Read);
                    // Verify that the file is the correct length.
                    if (file.Length != SYSEX_SIZE)
                    {
                        NonCriticalErrorBox(Resources.DialogTextIncorrectSysexFileSize);
                    }
                    else
                    {
                        byte[] sysexData = new byte[SYSEX_SIZE];
                        try
                        {
                            // Read the sysex data from the file.
                            file.Read(sysexData, 0, SYSEX_SIZE);
                            // Convert the sysex data to voices.
                            SysexToVoices(sysexData);
                            // Flag the data as unchanged.
                            this.HasChanges = false;
                        }
                        catch (Exception ex)
                        {
                            // Display the MIDI error.
                            NonCriticalErrorBox(String.Format("{0}\n\n{1}", Resources.DialogTextMidiErrorOccurred, ex.Message));
                        }
                    }
                    // Close the file.
                    file.Dispose();
                }
                // Select the first voice in the list.
                lstVoices.SetSelected(0, true);
            }
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void sendBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create SystemExMessage object using the raw sysex data.
            SysExMessage message = new SysExMessage(this.VoicesToSysex());

            try
            {
                // Connect to event to be notified if an error occurs.
                outDevice.Error += new EventHandler<Sanford.Multimedia.ErrorEventArgs>(outDevice_Error);
                // Send system exclusive message.
                outDevice.Send(message);
            }
            catch (Exception ex)
            {
                // Display the MIDI error.
                NonCriticalErrorBox(String.Format("{0}\n\n{1}", Resources.DialogTextMidiErrorOccurred, ex.Message));
            }
            // Reset the application from MIDI recording state.
            cleanupRecording();
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationBox(Resources.DialogTextHelpAbout);
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        private void requestBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // System exclusive message for Korg EX-800 bulk dump request.
            byte[] data =
            {
                (byte)0xF0, // Start of SysEx
                (byte)0x42, // Korg ID
                (byte)0x21, // Format ID
                (byte)0x01, // EX-800 ID
                (byte)0x10, // Dump request
                (byte)0xF7  // End of SysEx
            };

            // Create SystemExMessage object using the raw sysex data.
            SysExMessage message = new SysExMessage(data);

            try
            {
                // Reset devices - this might be unnecessary, but it's good practice.
                outDevice.Reset();
                inDevice.Reset();

                // Connect to event to be notified when a system exclusive event is received.
                inDevice.SysExMessageReceived += new EventHandler<SysExMessageEventArgs>(inDevice_SysExMessageReceived);

                // Connect to event to be notified if an error occurs.
                outDevice.Error += new EventHandler<Sanford.Multimedia.ErrorEventArgs>(outDevice_Error);

                // Start listening for input messages.
                inDevice.StartRecording();

                // Send system exclusive message.
                outDevice.Send(message);

                // Start the event timer; this times the MIDI input and throws if no input is received.
                midiTimer.Start();

                // Disable the form controls while waiting for input.
                grpMain.Enabled = false;
                lstVoices.Enabled = false;
                mnuMain.Enabled = false;
            }
            catch (Exception ex)
            {
                // Display the MIDI error.
                NonCriticalErrorBox(String.Format("{0}\n\n{1}", Resources.DialogTextMidiErrorOccurred, ex.Message));

                // Reset the application from MIDI recording state.
                cleanupRecording();
            }
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        void tabMain_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateDCOModeWarningText();
            DrawADSR();
        }

        // --------------------------------------------------------------------------------
        //
        // --------------------------------------------------------------------------------

        void inDevice_SysExMessageReceived(object sender, SysExMessageEventArgs e)
        {
            // BUGBUG - Check about reusing this method for ACK/NAK on return
            // message from sysex send; perhaps a switch statement on the data length

            // Reset the application from MIDI recording state.
            cleanupRecording();

            byte[] data = e.Message.GetBytes();

            if (data.Length != SYSEX_SIZE)
            {
                NonCriticalErrorBox(Resources.DialogTextIncorrectSysexDataSize);
            }
            else
            {
                // Unpack the sysex data into voices.
                SysexToVoices(data);
                // Flag the data as changed.
                this.HasChanges = true;
                // Jump to the first voice in the list.
                lstVoices.SetSelected(0, true);
            }
        }

        // --------------------------------------------------------------------------------
        // Clean up the MIDI recording environment
        // --------------------------------------------------------------------------------

        private void cleanupRecording()
        {
            // Disable the timer.
            midiTimer.Stop();

            // Re-enable the form controls.
            grpMain.Enabled = true;
            lstVoices.Enabled = true;
            mnuMain.Enabled = true;

            try
            {
                // Stop listening for input messages.
                inDevice.StopRecording();
                // Remove the MIDI event handlers.
                inDevice.SysExMessageReceived -= new EventHandler<SysExMessageEventArgs>(inDevice_SysExMessageReceived);
                outDevice.Error -= new EventHandler<Sanford.Multimedia.ErrorEventArgs>(outDevice_Error);
            }
            catch (Exception ex)
            {
                // Display the MIDI error.
                NonCriticalErrorBox(String.Format("{0}\n\n{1}", Resources.DialogTextMidiErrorOccurred, ex.Message));
            }
        }

        // --------------------------------------------------------------------------------
        // Event handler for MIDI output errors.
        // --------------------------------------------------------------------------------

        void outDevice_Error(object sender, Sanford.Multimedia.ErrorEventArgs e)
        {
            // Display the MIDI error.
            NonCriticalErrorBox(String.Format("{0}\n\n{1}", Resources.DialogTextMidiErrorOccurred, e.Error.Message));
        }

        // --------------------------------------------------------------------------------
        // Event handler for MIDI timer; this should only be called when no MIDI input has been received.
        // --------------------------------------------------------------------------------

        private void midiTimerProcessor(object sender, EventArgs e)
        {
            // Reset the application from MIDI recording state.
            cleanupRecording();
            // Display an error message.
            NonCriticalErrorBox(Resources.DialogTextMidiTimeoutError);
        }

        // --------------------------------------------------------------------------------
        // Event handler for ADSR timer; this should only be called once.
        // --------------------------------------------------------------------------------

        private void adsrTimerProcessor(object sender, EventArgs e)
        {
            adsrTimer.Tick -= adsrTimerProcessor;
            DrawADSR();
        }

    }
}
