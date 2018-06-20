namespace KorgEX800Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                if (outDevice != null)
                {
                    outDevice.Dispose();
                }
                if (inDevice != null)
                {
                    inDevice.Dispose();
                }
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lstVoices = new System.Windows.Forms.ListBox();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabDCO1 = new System.Windows.Forms.TabPage();
            this.grpDCO1EnvelopeMap = new System.Windows.Forms.GroupBox();
            this.txtDCO1ModeWarning = new System.Windows.Forms.TextBox();
            this.grpDCO1Release = new System.Windows.Forms.GroupBox();
            this.txtDCO1Release = new System.Windows.Forms.TextBox();
            this.trkDCO1Release = new System.Windows.Forms.TrackBar();
            this.grpDCO1Sustain = new System.Windows.Forms.GroupBox();
            this.txtDCO1Sustain = new System.Windows.Forms.TextBox();
            this.trkDCO1Sustain = new System.Windows.Forms.TrackBar();
            this.grpDCO1Slope = new System.Windows.Forms.GroupBox();
            this.txtDCO1Slope = new System.Windows.Forms.TextBox();
            this.trkDCO1Slope = new System.Windows.Forms.TrackBar();
            this.grpDCO1Mode = new System.Windows.Forms.GroupBox();
            this.grpDCO1Interval = new System.Windows.Forms.GroupBox();
            this.txtDCO1Interval = new System.Windows.Forms.TextBox();
            this.trkDCO1Interval = new System.Windows.Forms.TrackBar();
            this.grpDCO1Detune = new System.Windows.Forms.GroupBox();
            this.txtDCO1Detune = new System.Windows.Forms.TextBox();
            this.trkDCO1Detune = new System.Windows.Forms.TrackBar();
            this.rdoDCO1Whole = new System.Windows.Forms.RadioButton();
            this.rdoDCO1Double = new System.Windows.Forms.RadioButton();
            this.grpDCO1Decay = new System.Windows.Forms.GroupBox();
            this.txtDCO1Decay = new System.Windows.Forms.TextBox();
            this.trkDCO1Decay = new System.Windows.Forms.TrackBar();
            this.grpDCO1Break = new System.Windows.Forms.GroupBox();
            this.txtDCO1Break = new System.Windows.Forms.TextBox();
            this.trkDCO1Break = new System.Windows.Forms.TrackBar();
            this.grpDCO1Attack = new System.Windows.Forms.GroupBox();
            this.txtDCO1Attack = new System.Windows.Forms.TextBox();
            this.trkDCO1Attack = new System.Windows.Forms.TrackBar();
            this.grpDCO1Level = new System.Windows.Forms.GroupBox();
            this.txtDCO1Level = new System.Windows.Forms.TextBox();
            this.trkDCO1Level = new System.Windows.Forms.TrackBar();
            this.grpDCO1Harmonics = new System.Windows.Forms.GroupBox();
            this.chkDCO1Harmonic2 = new System.Windows.Forms.CheckBox();
            this.chkDCO1Harmonic4 = new System.Windows.Forms.CheckBox();
            this.chkDCO1Harmonic8 = new System.Windows.Forms.CheckBox();
            this.chkDCO1Harmonic16 = new System.Windows.Forms.CheckBox();
            this.grpDCO1Waveform = new System.Windows.Forms.GroupBox();
            this.rdoDCO1Sawtooth = new System.Windows.Forms.RadioButton();
            this.rdoDCO1Squarewave = new System.Windows.Forms.RadioButton();
            this.grpDCO1Octave = new System.Windows.Forms.GroupBox();
            this.rdoDCO1High = new System.Windows.Forms.RadioButton();
            this.rdoDCO1Mid = new System.Windows.Forms.RadioButton();
            this.rdoDCO1Low = new System.Windows.Forms.RadioButton();
            this.tabDCO2 = new System.Windows.Forms.TabPage();
            this.grpDCO2EnvelopeMap = new System.Windows.Forms.GroupBox();
            this.txtDCO2ModeWarning = new System.Windows.Forms.TextBox();
            this.grpDCO2Release = new System.Windows.Forms.GroupBox();
            this.txtDCO2Release = new System.Windows.Forms.TextBox();
            this.trkDCO2Release = new System.Windows.Forms.TrackBar();
            this.grpDCO2Sustain = new System.Windows.Forms.GroupBox();
            this.txtDCO2Sustain = new System.Windows.Forms.TextBox();
            this.trkDCO2Sustain = new System.Windows.Forms.TrackBar();
            this.grpDCO2Slope = new System.Windows.Forms.GroupBox();
            this.txtDCO2Slope = new System.Windows.Forms.TextBox();
            this.trkDCO2Slope = new System.Windows.Forms.TrackBar();
            this.grpDCO2Mode = new System.Windows.Forms.GroupBox();
            this.grpDCO2Interval = new System.Windows.Forms.GroupBox();
            this.txtDCO2Interval = new System.Windows.Forms.TextBox();
            this.trkDCO2Interval = new System.Windows.Forms.TrackBar();
            this.grpDCO2Detune = new System.Windows.Forms.GroupBox();
            this.txtDCO2Detune = new System.Windows.Forms.TextBox();
            this.trkDCO2Detune = new System.Windows.Forms.TrackBar();
            this.rdoDCO2Whole = new System.Windows.Forms.RadioButton();
            this.rdoDCO2Double = new System.Windows.Forms.RadioButton();
            this.grpDCO2Decay = new System.Windows.Forms.GroupBox();
            this.txtDCO2Decay = new System.Windows.Forms.TextBox();
            this.trkDCO2Decay = new System.Windows.Forms.TrackBar();
            this.grpDCO2Break = new System.Windows.Forms.GroupBox();
            this.txtDCO2Break = new System.Windows.Forms.TextBox();
            this.trkDCO2Break = new System.Windows.Forms.TrackBar();
            this.grpDCO2Attack = new System.Windows.Forms.GroupBox();
            this.txtDCO2Attack = new System.Windows.Forms.TextBox();
            this.trkDCO2Attack = new System.Windows.Forms.TrackBar();
            this.grpDCO2Level = new System.Windows.Forms.GroupBox();
            this.txtDCO2Level = new System.Windows.Forms.TextBox();
            this.trkDCO2Level = new System.Windows.Forms.TrackBar();
            this.grpDCO2Harmonics = new System.Windows.Forms.GroupBox();
            this.chkDCO2Harmonic2 = new System.Windows.Forms.CheckBox();
            this.chkDCO2Harmonic4 = new System.Windows.Forms.CheckBox();
            this.chkDCO2Harmonic8 = new System.Windows.Forms.CheckBox();
            this.chkDCO2Harmonic16 = new System.Windows.Forms.CheckBox();
            this.grpDCO2Waveform = new System.Windows.Forms.GroupBox();
            this.rdoDCO2Sawtooth = new System.Windows.Forms.RadioButton();
            this.rdoDCO2Squarewave = new System.Windows.Forms.RadioButton();
            this.grpDCO2Octave = new System.Windows.Forms.GroupBox();
            this.rdoDCO2High = new System.Windows.Forms.RadioButton();
            this.rdoDCO2Mid = new System.Windows.Forms.RadioButton();
            this.rdoDCO2Low = new System.Windows.Forms.RadioButton();
            this.tabVCF = new System.Windows.Forms.TabPage();
            this.grpVCFEGIntensity = new System.Windows.Forms.GroupBox();
            this.txtVCFEGIntensity = new System.Windows.Forms.TextBox();
            this.trkVCFEGIntensity = new System.Windows.Forms.TrackBar();
            this.grpVCFResonance = new System.Windows.Forms.GroupBox();
            this.txtVCFResonance = new System.Windows.Forms.TextBox();
            this.trkVCFResonance = new System.Windows.Forms.TrackBar();
            this.grpVCFCutoff = new System.Windows.Forms.GroupBox();
            this.trkVCFCutoff = new System.Windows.Forms.TrackBar();
            this.txtVCFCutoff = new System.Windows.Forms.TextBox();
            this.grpNoise = new System.Windows.Forms.GroupBox();
            this.txtNoise = new System.Windows.Forms.TextBox();
            this.trkNoise = new System.Windows.Forms.TrackBar();
            this.grpChorus = new System.Windows.Forms.GroupBox();
            this.rdoChorusOn = new System.Windows.Forms.RadioButton();
            this.rdoChorusOff = new System.Windows.Forms.RadioButton();
            this.grpMG = new System.Windows.Forms.GroupBox();
            this.grpMGDelay = new System.Windows.Forms.GroupBox();
            this.txtMGDelay = new System.Windows.Forms.TextBox();
            this.trkMGDelay = new System.Windows.Forms.TrackBar();
            this.grpMGFrequency = new System.Windows.Forms.GroupBox();
            this.txtMGFrequency = new System.Windows.Forms.TextBox();
            this.trkMGFrequency = new System.Windows.Forms.TrackBar();
            this.grpMGVCF = new System.Windows.Forms.GroupBox();
            this.txtMGVCF = new System.Windows.Forms.TextBox();
            this.trkMGVCF = new System.Windows.Forms.TrackBar();
            this.grpMGDCO = new System.Windows.Forms.GroupBox();
            this.txtMGDCO = new System.Windows.Forms.TextBox();
            this.trkMGDCO = new System.Windows.Forms.TrackBar();
            this.grpTrigger = new System.Windows.Forms.GroupBox();
            this.rdoTriggerSingle = new System.Windows.Forms.RadioButton();
            this.rdoTriggerMulti = new System.Windows.Forms.RadioButton();
            this.grpVCFRelease = new System.Windows.Forms.GroupBox();
            this.txtVCFRelease = new System.Windows.Forms.TextBox();
            this.trkVCFRelease = new System.Windows.Forms.TrackBar();
            this.grpVCFSustain = new System.Windows.Forms.GroupBox();
            this.txtVCFSustain = new System.Windows.Forms.TextBox();
            this.trkVCFSustain = new System.Windows.Forms.TrackBar();
            this.grpVCFSlope = new System.Windows.Forms.GroupBox();
            this.txtVCFSlope = new System.Windows.Forms.TextBox();
            this.trkVCFSlope = new System.Windows.Forms.TrackBar();
            this.grpVCFDecay = new System.Windows.Forms.GroupBox();
            this.txtVCFDecay = new System.Windows.Forms.TextBox();
            this.trkVCFDecay = new System.Windows.Forms.TrackBar();
            this.grpVCFBreak = new System.Windows.Forms.GroupBox();
            this.txtVCFBreak = new System.Windows.Forms.TextBox();
            this.trkVCFBreak = new System.Windows.Forms.TrackBar();
            this.grpPolarity = new System.Windows.Forms.GroupBox();
            this.rdoPolarityUp = new System.Windows.Forms.RadioButton();
            this.rdoPolarityDown = new System.Windows.Forms.RadioButton();
            this.grpKBDTrack = new System.Windows.Forms.GroupBox();
            this.rdoKBDTrackFull = new System.Windows.Forms.RadioButton();
            this.rdoKBDTrackHalf = new System.Windows.Forms.RadioButton();
            this.rdoKBDTrackOff = new System.Windows.Forms.RadioButton();
            this.grpVCFAttack = new System.Windows.Forms.GroupBox();
            this.txtVCFAttack = new System.Windows.Forms.TextBox();
            this.trkVCFAttack = new System.Windows.Forms.TrackBar();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.midiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabDCO1.SuspendLayout();
            this.grpDCO1Release.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Release)).BeginInit();
            this.grpDCO1Sustain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Sustain)).BeginInit();
            this.grpDCO1Slope.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Slope)).BeginInit();
            this.grpDCO1Mode.SuspendLayout();
            this.grpDCO1Interval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Interval)).BeginInit();
            this.grpDCO1Detune.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Detune)).BeginInit();
            this.grpDCO1Decay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Decay)).BeginInit();
            this.grpDCO1Break.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Break)).BeginInit();
            this.grpDCO1Attack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Attack)).BeginInit();
            this.grpDCO1Level.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Level)).BeginInit();
            this.grpDCO1Harmonics.SuspendLayout();
            this.grpDCO1Waveform.SuspendLayout();
            this.grpDCO1Octave.SuspendLayout();
            this.tabDCO2.SuspendLayout();
            this.grpDCO2Release.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Release)).BeginInit();
            this.grpDCO2Sustain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Sustain)).BeginInit();
            this.grpDCO2Slope.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Slope)).BeginInit();
            this.grpDCO2Mode.SuspendLayout();
            this.grpDCO2Interval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Interval)).BeginInit();
            this.grpDCO2Detune.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Detune)).BeginInit();
            this.grpDCO2Decay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Decay)).BeginInit();
            this.grpDCO2Break.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Break)).BeginInit();
            this.grpDCO2Attack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Attack)).BeginInit();
            this.grpDCO2Level.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Level)).BeginInit();
            this.grpDCO2Harmonics.SuspendLayout();
            this.grpDCO2Waveform.SuspendLayout();
            this.grpDCO2Octave.SuspendLayout();
            this.tabVCF.SuspendLayout();
            this.grpVCFEGIntensity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFEGIntensity)).BeginInit();
            this.grpVCFResonance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFResonance)).BeginInit();
            this.grpVCFCutoff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFCutoff)).BeginInit();
            this.grpNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkNoise)).BeginInit();
            this.grpChorus.SuspendLayout();
            this.grpMG.SuspendLayout();
            this.grpMGDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMGDelay)).BeginInit();
            this.grpMGFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMGFrequency)).BeginInit();
            this.grpMGVCF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMGVCF)).BeginInit();
            this.grpMGDCO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMGDCO)).BeginInit();
            this.grpTrigger.SuspendLayout();
            this.grpVCFRelease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFRelease)).BeginInit();
            this.grpVCFSustain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFSustain)).BeginInit();
            this.grpVCFSlope.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFSlope)).BeginInit();
            this.grpVCFDecay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFDecay)).BeginInit();
            this.grpVCFBreak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFBreak)).BeginInit();
            this.grpPolarity.SuspendLayout();
            this.grpKBDTrack.SuspendLayout();
            this.grpVCFAttack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFAttack)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVoices
            // 
            this.lstVoices.BackColor = System.Drawing.SystemColors.Window;
            this.lstVoices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVoices.FormattingEnabled = true;
            this.lstVoices.Location = new System.Drawing.Point(13, 30);
            this.lstVoices.Name = "lstVoices";
            this.lstVoices.Size = new System.Drawing.Size(144, 379);
            this.lstVoices.TabIndex = 0;
            this.lstVoices.SelectedIndexChanged += new System.EventHandler(this.lstVoices_SelectedIndexChanged);
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.tabMain);
            this.grpMain.Location = new System.Drawing.Point(163, 25);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(554, 388);
            this.grpMain.TabIndex = 7;
            this.grpMain.TabStop = false;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabDCO1);
            this.tabMain.Controls.Add(this.tabDCO2);
            this.tabMain.Controls.Add(this.tabVCF);
            this.tabMain.Location = new System.Drawing.Point(6, 19);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(540, 356);
            this.tabMain.TabIndex = 0;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabDCO1
            // 
            this.tabDCO1.BackColor = System.Drawing.SystemColors.Control;
            this.tabDCO1.Controls.Add(this.grpDCO1EnvelopeMap);
            this.tabDCO1.Controls.Add(this.txtDCO1ModeWarning);
            this.tabDCO1.Controls.Add(this.grpDCO1Release);
            this.tabDCO1.Controls.Add(this.grpDCO1Sustain);
            this.tabDCO1.Controls.Add(this.grpDCO1Slope);
            this.tabDCO1.Controls.Add(this.grpDCO1Mode);
            this.tabDCO1.Controls.Add(this.grpDCO1Decay);
            this.tabDCO1.Controls.Add(this.grpDCO1Break);
            this.tabDCO1.Controls.Add(this.grpDCO1Attack);
            this.tabDCO1.Controls.Add(this.grpDCO1Level);
            this.tabDCO1.Controls.Add(this.grpDCO1Harmonics);
            this.tabDCO1.Controls.Add(this.grpDCO1Waveform);
            this.tabDCO1.Controls.Add(this.grpDCO1Octave);
            this.tabDCO1.Location = new System.Drawing.Point(4, 22);
            this.tabDCO1.Name = "tabDCO1";
            this.tabDCO1.Padding = new System.Windows.Forms.Padding(3);
            this.tabDCO1.Size = new System.Drawing.Size(532, 330);
            this.tabDCO1.TabIndex = 0;
            this.tabDCO1.Text = global::KorgEX800Editor.Resources.UiTextDCO1;
            // 
            // grpDCO1EnvelopeMap
            // 
            this.grpDCO1EnvelopeMap.Location = new System.Drawing.Point(110, 208);
            this.grpDCO1EnvelopeMap.Name = "grpDCO1EnvelopeMap";
            this.grpDCO1EnvelopeMap.Size = new System.Drawing.Size(208, 111);
            this.grpDCO1EnvelopeMap.TabIndex = 38;
            this.grpDCO1EnvelopeMap.TabStop = false;
            this.grpDCO1EnvelopeMap.Text = "DCO 1 Envelope Map";
            // 
            // txtDCO1ModeWarning
            // 
            this.txtDCO1ModeWarning.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO1ModeWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDCO1ModeWarning.Enabled = false;
            this.txtDCO1ModeWarning.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDCO1ModeWarning.Location = new System.Drawing.Point(110, 166);
            this.txtDCO1ModeWarning.Multiline = true;
            this.txtDCO1ModeWarning.Name = "txtDCO1ModeWarning";
            this.txtDCO1ModeWarning.ReadOnly = true;
            this.txtDCO1ModeWarning.Size = new System.Drawing.Size(208, 36);
            this.txtDCO1ModeWarning.TabIndex = 37;
            this.txtDCO1ModeWarning.TabStop = false;
            // 
            // grpDCO1Release
            // 
            this.grpDCO1Release.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO1Release.Controls.Add(this.txtDCO1Release);
            this.grpDCO1Release.Controls.Add(this.trkDCO1Release);
            this.grpDCO1Release.Location = new System.Drawing.Point(405, 7);
            this.grpDCO1Release.Name = "grpDCO1Release";
            this.grpDCO1Release.Size = new System.Drawing.Size(60, 153);
            this.grpDCO1Release.TabIndex = 36;
            this.grpDCO1Release.TabStop = false;
            this.grpDCO1Release.Text = "Release";
            // 
            // txtDCO1Release
            // 
            this.txtDCO1Release.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO1Release.Location = new System.Drawing.Point(8, 128);
            this.txtDCO1Release.Name = "txtDCO1Release";
            this.txtDCO1Release.ReadOnly = true;
            this.txtDCO1Release.Size = new System.Drawing.Size(39, 20);
            this.txtDCO1Release.TabIndex = 7;
            this.txtDCO1Release.TabStop = false;
            this.txtDCO1Release.Text = "0";
            this.txtDCO1Release.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO1Release
            // 
            this.trkDCO1Release.Location = new System.Drawing.Point(8, 14);
            this.trkDCO1Release.Maximum = 31;
            this.trkDCO1Release.Name = "trkDCO1Release";
            this.trkDCO1Release.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO1Release.Size = new System.Drawing.Size(45, 108);
            this.trkDCO1Release.TabIndex = 6;
            this.trkDCO1Release.Scroll += new System.EventHandler(this.trkDCO1Release_Scroll);
            // 
            // grpDCO1Sustain
            // 
            this.grpDCO1Sustain.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO1Sustain.Controls.Add(this.txtDCO1Sustain);
            this.grpDCO1Sustain.Controls.Add(this.trkDCO1Sustain);
            this.grpDCO1Sustain.Location = new System.Drawing.Point(346, 7);
            this.grpDCO1Sustain.Name = "grpDCO1Sustain";
            this.grpDCO1Sustain.Size = new System.Drawing.Size(60, 153);
            this.grpDCO1Sustain.TabIndex = 35;
            this.grpDCO1Sustain.TabStop = false;
            this.grpDCO1Sustain.Text = "Sustain";
            // 
            // txtDCO1Sustain
            // 
            this.txtDCO1Sustain.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO1Sustain.Location = new System.Drawing.Point(8, 127);
            this.txtDCO1Sustain.Name = "txtDCO1Sustain";
            this.txtDCO1Sustain.ReadOnly = true;
            this.txtDCO1Sustain.Size = new System.Drawing.Size(39, 20);
            this.txtDCO1Sustain.TabIndex = 7;
            this.txtDCO1Sustain.TabStop = false;
            this.txtDCO1Sustain.Text = "0";
            this.txtDCO1Sustain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO1Sustain
            // 
            this.trkDCO1Sustain.Location = new System.Drawing.Point(8, 14);
            this.trkDCO1Sustain.Maximum = 31;
            this.trkDCO1Sustain.Name = "trkDCO1Sustain";
            this.trkDCO1Sustain.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO1Sustain.Size = new System.Drawing.Size(45, 108);
            this.trkDCO1Sustain.TabIndex = 6;
            this.trkDCO1Sustain.Scroll += new System.EventHandler(this.trkDCO1Sustain_Scroll);
            // 
            // grpDCO1Slope
            // 
            this.grpDCO1Slope.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO1Slope.Controls.Add(this.txtDCO1Slope);
            this.grpDCO1Slope.Controls.Add(this.trkDCO1Slope);
            this.grpDCO1Slope.Location = new System.Drawing.Point(287, 7);
            this.grpDCO1Slope.Name = "grpDCO1Slope";
            this.grpDCO1Slope.Size = new System.Drawing.Size(60, 153);
            this.grpDCO1Slope.TabIndex = 34;
            this.grpDCO1Slope.TabStop = false;
            this.grpDCO1Slope.Text = "Slope";
            // 
            // txtDCO1Slope
            // 
            this.txtDCO1Slope.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO1Slope.Location = new System.Drawing.Point(8, 127);
            this.txtDCO1Slope.Name = "txtDCO1Slope";
            this.txtDCO1Slope.ReadOnly = true;
            this.txtDCO1Slope.Size = new System.Drawing.Size(39, 20);
            this.txtDCO1Slope.TabIndex = 7;
            this.txtDCO1Slope.TabStop = false;
            this.txtDCO1Slope.Text = "0";
            this.txtDCO1Slope.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO1Slope
            // 
            this.trkDCO1Slope.Location = new System.Drawing.Point(8, 14);
            this.trkDCO1Slope.Maximum = 31;
            this.trkDCO1Slope.Name = "trkDCO1Slope";
            this.trkDCO1Slope.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO1Slope.Size = new System.Drawing.Size(45, 108);
            this.trkDCO1Slope.TabIndex = 6;
            this.trkDCO1Slope.Scroll += new System.EventHandler(this.trkDCO1Slope_Scroll);
            // 
            // grpDCO1Mode
            // 
            this.grpDCO1Mode.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO1Mode.Controls.Add(this.grpDCO1Interval);
            this.grpDCO1Mode.Controls.Add(this.grpDCO1Detune);
            this.grpDCO1Mode.Controls.Add(this.rdoDCO1Whole);
            this.grpDCO1Mode.Controls.Add(this.rdoDCO1Double);
            this.grpDCO1Mode.Location = new System.Drawing.Point(324, 166);
            this.grpDCO1Mode.Name = "grpDCO1Mode";
            this.grpDCO1Mode.Size = new System.Drawing.Size(200, 153);
            this.grpDCO1Mode.TabIndex = 25;
            this.grpDCO1Mode.TabStop = false;
            this.grpDCO1Mode.Text = "DCO Mode";
            // 
            // grpDCO1Interval
            // 
            this.grpDCO1Interval.Controls.Add(this.txtDCO1Interval);
            this.grpDCO1Interval.Controls.Add(this.trkDCO1Interval);
            this.grpDCO1Interval.Location = new System.Drawing.Point(131, 13);
            this.grpDCO1Interval.Name = "grpDCO1Interval";
            this.grpDCO1Interval.Size = new System.Drawing.Size(60, 134);
            this.grpDCO1Interval.TabIndex = 39;
            this.grpDCO1Interval.TabStop = false;
            this.grpDCO1Interval.Text = "Interval";
            // 
            // txtDCO1Interval
            // 
            this.txtDCO1Interval.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO1Interval.Location = new System.Drawing.Point(8, 105);
            this.txtDCO1Interval.Name = "txtDCO1Interval";
            this.txtDCO1Interval.ReadOnly = true;
            this.txtDCO1Interval.Size = new System.Drawing.Size(39, 20);
            this.txtDCO1Interval.TabIndex = 7;
            this.txtDCO1Interval.TabStop = false;
            this.txtDCO1Interval.Text = "0";
            this.txtDCO1Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO1Interval
            // 
            this.trkDCO1Interval.Location = new System.Drawing.Point(8, 19);
            this.trkDCO1Interval.Maximum = 12;
            this.trkDCO1Interval.Name = "trkDCO1Interval";
            this.trkDCO1Interval.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO1Interval.Size = new System.Drawing.Size(45, 80);
            this.trkDCO1Interval.TabIndex = 6;
            this.trkDCO1Interval.Scroll += new System.EventHandler(this.trkDCO1Interval_Scroll);
            // 
            // grpDCO1Detune
            // 
            this.grpDCO1Detune.Controls.Add(this.txtDCO1Detune);
            this.grpDCO1Detune.Controls.Add(this.trkDCO1Detune);
            this.grpDCO1Detune.Location = new System.Drawing.Point(71, 13);
            this.grpDCO1Detune.Name = "grpDCO1Detune";
            this.grpDCO1Detune.Size = new System.Drawing.Size(60, 134);
            this.grpDCO1Detune.TabIndex = 38;
            this.grpDCO1Detune.TabStop = false;
            this.grpDCO1Detune.Text = "Detune";
            // 
            // txtDCO1Detune
            // 
            this.txtDCO1Detune.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO1Detune.Location = new System.Drawing.Point(8, 105);
            this.txtDCO1Detune.Name = "txtDCO1Detune";
            this.txtDCO1Detune.ReadOnly = true;
            this.txtDCO1Detune.Size = new System.Drawing.Size(39, 20);
            this.txtDCO1Detune.TabIndex = 11;
            this.txtDCO1Detune.TabStop = false;
            this.txtDCO1Detune.Text = "0";
            this.txtDCO1Detune.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO1Detune
            // 
            this.trkDCO1Detune.Location = new System.Drawing.Point(8, 19);
            this.trkDCO1Detune.Maximum = 3;
            this.trkDCO1Detune.Name = "trkDCO1Detune";
            this.trkDCO1Detune.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO1Detune.Size = new System.Drawing.Size(45, 80);
            this.trkDCO1Detune.TabIndex = 10;
            this.trkDCO1Detune.Scroll += new System.EventHandler(this.trkDCO1Detune_Scroll);
            // 
            // rdoDCO1Whole
            // 
            this.rdoDCO1Whole.AutoSize = true;
            this.rdoDCO1Whole.Location = new System.Drawing.Point(6, 19);
            this.rdoDCO1Whole.Name = "rdoDCO1Whole";
            this.rdoDCO1Whole.Size = new System.Drawing.Size(56, 17);
            this.rdoDCO1Whole.TabIndex = 7;
            this.rdoDCO1Whole.Text = global::KorgEX800Editor.Resources.UiTextWhole;
            this.rdoDCO1Whole.UseVisualStyleBackColor = true;
            this.rdoDCO1Whole.CheckedChanged += new System.EventHandler(this.rdoDCO1Whole_CheckedChanged);
            // 
            // rdoDCO1Double
            // 
            this.rdoDCO1Double.AutoSize = true;
            this.rdoDCO1Double.Checked = true;
            this.rdoDCO1Double.Location = new System.Drawing.Point(6, 42);
            this.rdoDCO1Double.Name = "rdoDCO1Double";
            this.rdoDCO1Double.Size = new System.Drawing.Size(59, 17);
            this.rdoDCO1Double.TabIndex = 6;
            this.rdoDCO1Double.TabStop = true;
            this.rdoDCO1Double.Text = global::KorgEX800Editor.Resources.UiTextDouble;
            this.rdoDCO1Double.UseVisualStyleBackColor = true;
            this.rdoDCO1Double.CheckedChanged += new System.EventHandler(this.rdoDCO1Double_CheckedChanged);
            // 
            // grpDCO1Decay
            // 
            this.grpDCO1Decay.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO1Decay.Controls.Add(this.txtDCO1Decay);
            this.grpDCO1Decay.Controls.Add(this.trkDCO1Decay);
            this.grpDCO1Decay.Location = new System.Drawing.Point(169, 7);
            this.grpDCO1Decay.Name = "grpDCO1Decay";
            this.grpDCO1Decay.Size = new System.Drawing.Size(60, 153);
            this.grpDCO1Decay.TabIndex = 32;
            this.grpDCO1Decay.TabStop = false;
            this.grpDCO1Decay.Text = "Decay";
            // 
            // txtDCO1Decay
            // 
            this.txtDCO1Decay.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO1Decay.Location = new System.Drawing.Point(8, 127);
            this.txtDCO1Decay.Name = "txtDCO1Decay";
            this.txtDCO1Decay.ReadOnly = true;
            this.txtDCO1Decay.Size = new System.Drawing.Size(39, 20);
            this.txtDCO1Decay.TabIndex = 7;
            this.txtDCO1Decay.TabStop = false;
            this.txtDCO1Decay.Text = "0";
            this.txtDCO1Decay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO1Decay
            // 
            this.trkDCO1Decay.Location = new System.Drawing.Point(8, 14);
            this.trkDCO1Decay.Maximum = 31;
            this.trkDCO1Decay.Name = "trkDCO1Decay";
            this.trkDCO1Decay.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO1Decay.Size = new System.Drawing.Size(45, 108);
            this.trkDCO1Decay.TabIndex = 6;
            this.trkDCO1Decay.Scroll += new System.EventHandler(this.trkDCO1Decay_Scroll);
            // 
            // grpDCO1Break
            // 
            this.grpDCO1Break.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO1Break.Controls.Add(this.txtDCO1Break);
            this.grpDCO1Break.Controls.Add(this.trkDCO1Break);
            this.grpDCO1Break.Location = new System.Drawing.Point(228, 7);
            this.grpDCO1Break.Name = "grpDCO1Break";
            this.grpDCO1Break.Size = new System.Drawing.Size(60, 153);
            this.grpDCO1Break.TabIndex = 33;
            this.grpDCO1Break.TabStop = false;
            this.grpDCO1Break.Text = "Break";
            // 
            // txtDCO1Break
            // 
            this.txtDCO1Break.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO1Break.Location = new System.Drawing.Point(8, 127);
            this.txtDCO1Break.Name = "txtDCO1Break";
            this.txtDCO1Break.ReadOnly = true;
            this.txtDCO1Break.Size = new System.Drawing.Size(39, 20);
            this.txtDCO1Break.TabIndex = 7;
            this.txtDCO1Break.TabStop = false;
            this.txtDCO1Break.Text = "0";
            this.txtDCO1Break.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO1Break
            // 
            this.trkDCO1Break.Location = new System.Drawing.Point(8, 14);
            this.trkDCO1Break.Maximum = 31;
            this.trkDCO1Break.Name = "trkDCO1Break";
            this.trkDCO1Break.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO1Break.Size = new System.Drawing.Size(45, 108);
            this.trkDCO1Break.TabIndex = 6;
            this.trkDCO1Break.Scroll += new System.EventHandler(this.trkDCO1Break_Scroll);
            // 
            // grpDCO1Attack
            // 
            this.grpDCO1Attack.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO1Attack.Controls.Add(this.txtDCO1Attack);
            this.grpDCO1Attack.Controls.Add(this.trkDCO1Attack);
            this.grpDCO1Attack.Location = new System.Drawing.Point(110, 7);
            this.grpDCO1Attack.Name = "grpDCO1Attack";
            this.grpDCO1Attack.Size = new System.Drawing.Size(60, 153);
            this.grpDCO1Attack.TabIndex = 31;
            this.grpDCO1Attack.TabStop = false;
            this.grpDCO1Attack.Text = "Attack";
            // 
            // txtDCO1Attack
            // 
            this.txtDCO1Attack.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO1Attack.Location = new System.Drawing.Point(8, 127);
            this.txtDCO1Attack.Name = "txtDCO1Attack";
            this.txtDCO1Attack.ReadOnly = true;
            this.txtDCO1Attack.Size = new System.Drawing.Size(39, 20);
            this.txtDCO1Attack.TabIndex = 7;
            this.txtDCO1Attack.TabStop = false;
            this.txtDCO1Attack.Text = "0";
            this.txtDCO1Attack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO1Attack
            // 
            this.trkDCO1Attack.BackColor = System.Drawing.SystemColors.Control;
            this.trkDCO1Attack.Location = new System.Drawing.Point(8, 14);
            this.trkDCO1Attack.Maximum = 31;
            this.trkDCO1Attack.Name = "trkDCO1Attack";
            this.trkDCO1Attack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO1Attack.Size = new System.Drawing.Size(45, 108);
            this.trkDCO1Attack.TabIndex = 6;
            this.trkDCO1Attack.Scroll += new System.EventHandler(this.trkDCO1Attack_Scroll);
            // 
            // grpDCO1Level
            // 
            this.grpDCO1Level.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO1Level.Controls.Add(this.txtDCO1Level);
            this.grpDCO1Level.Controls.Add(this.trkDCO1Level);
            this.grpDCO1Level.Location = new System.Drawing.Point(464, 7);
            this.grpDCO1Level.Name = "grpDCO1Level";
            this.grpDCO1Level.Size = new System.Drawing.Size(60, 153);
            this.grpDCO1Level.TabIndex = 30;
            this.grpDCO1Level.TabStop = false;
            this.grpDCO1Level.Text = "Level";
            // 
            // txtDCO1Level
            // 
            this.txtDCO1Level.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO1Level.Location = new System.Drawing.Point(8, 127);
            this.txtDCO1Level.Name = "txtDCO1Level";
            this.txtDCO1Level.ReadOnly = true;
            this.txtDCO1Level.Size = new System.Drawing.Size(39, 20);
            this.txtDCO1Level.TabIndex = 7;
            this.txtDCO1Level.TabStop = false;
            this.txtDCO1Level.Text = "0";
            this.txtDCO1Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO1Level
            // 
            this.trkDCO1Level.Location = new System.Drawing.Point(8, 14);
            this.trkDCO1Level.Maximum = 31;
            this.trkDCO1Level.Name = "trkDCO1Level";
            this.trkDCO1Level.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO1Level.Size = new System.Drawing.Size(45, 108);
            this.trkDCO1Level.TabIndex = 6;
            this.trkDCO1Level.Scroll += new System.EventHandler(this.trkDCO1Level_Scroll);
            // 
            // grpDCO1Harmonics
            // 
            this.grpDCO1Harmonics.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO1Harmonics.Controls.Add(this.chkDCO1Harmonic2);
            this.grpDCO1Harmonics.Controls.Add(this.chkDCO1Harmonic4);
            this.grpDCO1Harmonics.Controls.Add(this.chkDCO1Harmonic8);
            this.grpDCO1Harmonics.Controls.Add(this.chkDCO1Harmonic16);
            this.grpDCO1Harmonics.Location = new System.Drawing.Point(7, 112);
            this.grpDCO1Harmonics.Name = "grpDCO1Harmonics";
            this.grpDCO1Harmonics.Size = new System.Drawing.Size(97, 125);
            this.grpDCO1Harmonics.TabIndex = 27;
            this.grpDCO1Harmonics.TabStop = false;
            this.grpDCO1Harmonics.Text = "Harmonics";
            // 
            // chkDCO1Harmonic2
            // 
            this.chkDCO1Harmonic2.AutoSize = true;
            this.chkDCO1Harmonic2.Location = new System.Drawing.Point(6, 89);
            this.chkDCO1Harmonic2.Name = "chkDCO1Harmonic2";
            this.chkDCO1Harmonic2.Size = new System.Drawing.Size(34, 17);
            this.chkDCO1Harmonic2.TabIndex = 3;
            this.chkDCO1Harmonic2.Text = global::KorgEX800Editor.Resources.UiTextHarmonic2;
            this.chkDCO1Harmonic2.UseVisualStyleBackColor = true;
            this.chkDCO1Harmonic2.CheckedChanged += new System.EventHandler(this.chkDCO1Harmonic2_CheckedChanged);
            // 
            // chkDCO1Harmonic4
            // 
            this.chkDCO1Harmonic4.AutoSize = true;
            this.chkDCO1Harmonic4.Location = new System.Drawing.Point(6, 66);
            this.chkDCO1Harmonic4.Name = "chkDCO1Harmonic4";
            this.chkDCO1Harmonic4.Size = new System.Drawing.Size(34, 17);
            this.chkDCO1Harmonic4.TabIndex = 2;
            this.chkDCO1Harmonic4.Text = global::KorgEX800Editor.Resources.UiTextHarmonic4;
            this.chkDCO1Harmonic4.UseVisualStyleBackColor = true;
            this.chkDCO1Harmonic4.CheckedChanged += new System.EventHandler(this.chkDCO1Harmonic4_CheckedChanged);
            // 
            // chkDCO1Harmonic8
            // 
            this.chkDCO1Harmonic8.AutoSize = true;
            this.chkDCO1Harmonic8.Location = new System.Drawing.Point(6, 43);
            this.chkDCO1Harmonic8.Name = "chkDCO1Harmonic8";
            this.chkDCO1Harmonic8.Size = new System.Drawing.Size(34, 17);
            this.chkDCO1Harmonic8.TabIndex = 1;
            this.chkDCO1Harmonic8.Text = global::KorgEX800Editor.Resources.UiTextHarmonic8;
            this.chkDCO1Harmonic8.UseVisualStyleBackColor = true;
            this.chkDCO1Harmonic8.CheckedChanged += new System.EventHandler(this.chkDCO1Harmonic8_CheckedChanged);
            // 
            // chkDCO1Harmonic16
            // 
            this.chkDCO1Harmonic16.AutoSize = true;
            this.chkDCO1Harmonic16.Location = new System.Drawing.Point(6, 19);
            this.chkDCO1Harmonic16.Name = "chkDCO1Harmonic16";
            this.chkDCO1Harmonic16.Size = new System.Drawing.Size(40, 17);
            this.chkDCO1Harmonic16.TabIndex = 0;
            this.chkDCO1Harmonic16.Text = global::KorgEX800Editor.Resources.UiTextHarmonic16;
            this.chkDCO1Harmonic16.UseVisualStyleBackColor = true;
            this.chkDCO1Harmonic16.CheckedChanged += new System.EventHandler(this.chkDCO1Harmonic16_CheckedChanged);
            // 
            // grpDCO1Waveform
            // 
            this.grpDCO1Waveform.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO1Waveform.Controls.Add(this.rdoDCO1Sawtooth);
            this.grpDCO1Waveform.Controls.Add(this.rdoDCO1Squarewave);
            this.grpDCO1Waveform.Location = new System.Drawing.Point(7, 243);
            this.grpDCO1Waveform.Name = "grpDCO1Waveform";
            this.grpDCO1Waveform.Size = new System.Drawing.Size(97, 76);
            this.grpDCO1Waveform.TabIndex = 29;
            this.grpDCO1Waveform.TabStop = false;
            this.grpDCO1Waveform.Text = "Waveform";
            // 
            // rdoDCO1Sawtooth
            // 
            this.rdoDCO1Sawtooth.AutoSize = true;
            this.rdoDCO1Sawtooth.Location = new System.Drawing.Point(6, 19);
            this.rdoDCO1Sawtooth.Name = "rdoDCO1Sawtooth";
            this.rdoDCO1Sawtooth.Size = new System.Drawing.Size(70, 17);
            this.rdoDCO1Sawtooth.TabIndex = 5;
            this.rdoDCO1Sawtooth.Text = global::KorgEX800Editor.Resources.UiTextSawtooth;
            this.rdoDCO1Sawtooth.UseVisualStyleBackColor = true;
            this.rdoDCO1Sawtooth.CheckedChanged += new System.EventHandler(this.rdoDCO1Sawtooth_CheckedChanged);
            // 
            // rdoDCO1Squarewave
            // 
            this.rdoDCO1Squarewave.AutoSize = true;
            this.rdoDCO1Squarewave.Checked = true;
            this.rdoDCO1Squarewave.Location = new System.Drawing.Point(6, 42);
            this.rdoDCO1Squarewave.Name = "rdoDCO1Squarewave";
            this.rdoDCO1Squarewave.Size = new System.Drawing.Size(85, 17);
            this.rdoDCO1Squarewave.TabIndex = 4;
            this.rdoDCO1Squarewave.TabStop = true;
            this.rdoDCO1Squarewave.Text = global::KorgEX800Editor.Resources.UiTextSquarewave;
            this.rdoDCO1Squarewave.UseVisualStyleBackColor = true;
            this.rdoDCO1Squarewave.CheckedChanged += new System.EventHandler(this.rdoDCO1Squarewave_CheckedChanged);
            // 
            // grpDCO1Octave
            // 
            this.grpDCO1Octave.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO1Octave.Controls.Add(this.rdoDCO1High);
            this.grpDCO1Octave.Controls.Add(this.rdoDCO1Mid);
            this.grpDCO1Octave.Controls.Add(this.rdoDCO1Low);
            this.grpDCO1Octave.Location = new System.Drawing.Point(7, 7);
            this.grpDCO1Octave.Name = "grpDCO1Octave";
            this.grpDCO1Octave.Size = new System.Drawing.Size(97, 99);
            this.grpDCO1Octave.TabIndex = 26;
            this.grpDCO1Octave.TabStop = false;
            this.grpDCO1Octave.Text = "Octave";
            // 
            // rdoDCO1High
            // 
            this.rdoDCO1High.AutoSize = true;
            this.rdoDCO1High.Location = new System.Drawing.Point(6, 19);
            this.rdoDCO1High.Name = "rdoDCO1High";
            this.rdoDCO1High.Size = new System.Drawing.Size(47, 17);
            this.rdoDCO1High.TabIndex = 3;
            this.rdoDCO1High.Text = global::KorgEX800Editor.Resources.UiTextHigh;
            this.rdoDCO1High.UseVisualStyleBackColor = true;
            this.rdoDCO1High.CheckedChanged += new System.EventHandler(this.rdoDCO1High_CheckedChanged);
            // 
            // rdoDCO1Mid
            // 
            this.rdoDCO1Mid.AutoSize = true;
            this.rdoDCO1Mid.Checked = true;
            this.rdoDCO1Mid.Location = new System.Drawing.Point(6, 42);
            this.rdoDCO1Mid.Name = "rdoDCO1Mid";
            this.rdoDCO1Mid.Size = new System.Drawing.Size(42, 17);
            this.rdoDCO1Mid.TabIndex = 4;
            this.rdoDCO1Mid.TabStop = true;
            this.rdoDCO1Mid.Text = global::KorgEX800Editor.Resources.UiTextMid;
            this.rdoDCO1Mid.UseVisualStyleBackColor = true;
            this.rdoDCO1Mid.CheckedChanged += new System.EventHandler(this.rdoDCO1Mid_CheckedChanged);
            // 
            // rdoDCO1Low
            // 
            this.rdoDCO1Low.AutoSize = true;
            this.rdoDCO1Low.Location = new System.Drawing.Point(6, 65);
            this.rdoDCO1Low.Name = "rdoDCO1Low";
            this.rdoDCO1Low.Size = new System.Drawing.Size(45, 17);
            this.rdoDCO1Low.TabIndex = 5;
            this.rdoDCO1Low.Text = global::KorgEX800Editor.Resources.UiTextLow;
            this.rdoDCO1Low.UseVisualStyleBackColor = true;
            this.rdoDCO1Low.CheckedChanged += new System.EventHandler(this.rdoDCO1Low_CheckedChanged);
            // 
            // tabDCO2
            // 
            this.tabDCO2.BackColor = System.Drawing.SystemColors.Control;
            this.tabDCO2.Controls.Add(this.grpDCO2EnvelopeMap);
            this.tabDCO2.Controls.Add(this.txtDCO2ModeWarning);
            this.tabDCO2.Controls.Add(this.grpDCO2Release);
            this.tabDCO2.Controls.Add(this.grpDCO2Sustain);
            this.tabDCO2.Controls.Add(this.grpDCO2Slope);
            this.tabDCO2.Controls.Add(this.grpDCO2Mode);
            this.tabDCO2.Controls.Add(this.grpDCO2Decay);
            this.tabDCO2.Controls.Add(this.grpDCO2Break);
            this.tabDCO2.Controls.Add(this.grpDCO2Attack);
            this.tabDCO2.Controls.Add(this.grpDCO2Level);
            this.tabDCO2.Controls.Add(this.grpDCO2Harmonics);
            this.tabDCO2.Controls.Add(this.grpDCO2Waveform);
            this.tabDCO2.Controls.Add(this.grpDCO2Octave);
            this.tabDCO2.Location = new System.Drawing.Point(4, 22);
            this.tabDCO2.Name = "tabDCO2";
            this.tabDCO2.Padding = new System.Windows.Forms.Padding(3);
            this.tabDCO2.Size = new System.Drawing.Size(532, 330);
            this.tabDCO2.TabIndex = 1;
            this.tabDCO2.Text = global::KorgEX800Editor.Resources.UiTextDCO2;
            // 
            // grpDCO2EnvelopeMap
            // 
            this.grpDCO2EnvelopeMap.Location = new System.Drawing.Point(110, 208);
            this.grpDCO2EnvelopeMap.Name = "grpDCO2EnvelopeMap";
            this.grpDCO2EnvelopeMap.Size = new System.Drawing.Size(208, 111);
            this.grpDCO2EnvelopeMap.TabIndex = 39;
            this.grpDCO2EnvelopeMap.TabStop = false;
            this.grpDCO2EnvelopeMap.Text = "DCO 2 Envelope Map";
            // 
            // txtDCO2ModeWarning
            // 
            this.txtDCO2ModeWarning.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO2ModeWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDCO2ModeWarning.Enabled = false;
            this.txtDCO2ModeWarning.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDCO2ModeWarning.Location = new System.Drawing.Point(110, 166);
            this.txtDCO2ModeWarning.Multiline = true;
            this.txtDCO2ModeWarning.Name = "txtDCO2ModeWarning";
            this.txtDCO2ModeWarning.ReadOnly = true;
            this.txtDCO2ModeWarning.Size = new System.Drawing.Size(208, 36);
            this.txtDCO2ModeWarning.TabIndex = 38;
            this.txtDCO2ModeWarning.TabStop = false;
            // 
            // grpDCO2Release
            // 
            this.grpDCO2Release.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO2Release.Controls.Add(this.txtDCO2Release);
            this.grpDCO2Release.Controls.Add(this.trkDCO2Release);
            this.grpDCO2Release.Location = new System.Drawing.Point(405, 7);
            this.grpDCO2Release.Name = "grpDCO2Release";
            this.grpDCO2Release.Size = new System.Drawing.Size(60, 153);
            this.grpDCO2Release.TabIndex = 36;
            this.grpDCO2Release.TabStop = false;
            this.grpDCO2Release.Text = "Release";
            // 
            // txtDCO2Release
            // 
            this.txtDCO2Release.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO2Release.Location = new System.Drawing.Point(8, 128);
            this.txtDCO2Release.Name = "txtDCO2Release";
            this.txtDCO2Release.ReadOnly = true;
            this.txtDCO2Release.Size = new System.Drawing.Size(39, 20);
            this.txtDCO2Release.TabIndex = 7;
            this.txtDCO2Release.TabStop = false;
            this.txtDCO2Release.Text = "0";
            this.txtDCO2Release.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO2Release
            // 
            this.trkDCO2Release.Location = new System.Drawing.Point(8, 14);
            this.trkDCO2Release.Maximum = 31;
            this.trkDCO2Release.Name = "trkDCO2Release";
            this.trkDCO2Release.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO2Release.Size = new System.Drawing.Size(45, 108);
            this.trkDCO2Release.TabIndex = 6;
            this.trkDCO2Release.Scroll += new System.EventHandler(this.trkDCO2Release_Scroll);
            // 
            // grpDCO2Sustain
            // 
            this.grpDCO2Sustain.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO2Sustain.Controls.Add(this.txtDCO2Sustain);
            this.grpDCO2Sustain.Controls.Add(this.trkDCO2Sustain);
            this.grpDCO2Sustain.Location = new System.Drawing.Point(346, 7);
            this.grpDCO2Sustain.Name = "grpDCO2Sustain";
            this.grpDCO2Sustain.Size = new System.Drawing.Size(60, 153);
            this.grpDCO2Sustain.TabIndex = 35;
            this.grpDCO2Sustain.TabStop = false;
            this.grpDCO2Sustain.Text = "Sustain";
            // 
            // txtDCO2Sustain
            // 
            this.txtDCO2Sustain.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO2Sustain.Location = new System.Drawing.Point(8, 127);
            this.txtDCO2Sustain.Name = "txtDCO2Sustain";
            this.txtDCO2Sustain.ReadOnly = true;
            this.txtDCO2Sustain.Size = new System.Drawing.Size(39, 20);
            this.txtDCO2Sustain.TabIndex = 7;
            this.txtDCO2Sustain.TabStop = false;
            this.txtDCO2Sustain.Text = "0";
            this.txtDCO2Sustain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO2Sustain
            // 
            this.trkDCO2Sustain.Location = new System.Drawing.Point(8, 14);
            this.trkDCO2Sustain.Maximum = 31;
            this.trkDCO2Sustain.Name = "trkDCO2Sustain";
            this.trkDCO2Sustain.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO2Sustain.Size = new System.Drawing.Size(45, 108);
            this.trkDCO2Sustain.TabIndex = 6;
            this.trkDCO2Sustain.Scroll += new System.EventHandler(this.trkDCO2Sustain_Scroll);
            // 
            // grpDCO2Slope
            // 
            this.grpDCO2Slope.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO2Slope.Controls.Add(this.txtDCO2Slope);
            this.grpDCO2Slope.Controls.Add(this.trkDCO2Slope);
            this.grpDCO2Slope.Location = new System.Drawing.Point(287, 7);
            this.grpDCO2Slope.Name = "grpDCO2Slope";
            this.grpDCO2Slope.Size = new System.Drawing.Size(60, 153);
            this.grpDCO2Slope.TabIndex = 34;
            this.grpDCO2Slope.TabStop = false;
            this.grpDCO2Slope.Text = "Slope";
            // 
            // txtDCO2Slope
            // 
            this.txtDCO2Slope.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO2Slope.Location = new System.Drawing.Point(8, 127);
            this.txtDCO2Slope.Name = "txtDCO2Slope";
            this.txtDCO2Slope.ReadOnly = true;
            this.txtDCO2Slope.Size = new System.Drawing.Size(39, 20);
            this.txtDCO2Slope.TabIndex = 7;
            this.txtDCO2Slope.TabStop = false;
            this.txtDCO2Slope.Text = "0";
            this.txtDCO2Slope.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO2Slope
            // 
            this.trkDCO2Slope.Location = new System.Drawing.Point(8, 14);
            this.trkDCO2Slope.Maximum = 31;
            this.trkDCO2Slope.Name = "trkDCO2Slope";
            this.trkDCO2Slope.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO2Slope.Size = new System.Drawing.Size(45, 108);
            this.trkDCO2Slope.TabIndex = 6;
            this.trkDCO2Slope.Scroll += new System.EventHandler(this.trkDCO2Slope_Scroll);
            // 
            // grpDCO2Mode
            // 
            this.grpDCO2Mode.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO2Mode.Controls.Add(this.grpDCO2Interval);
            this.grpDCO2Mode.Controls.Add(this.grpDCO2Detune);
            this.grpDCO2Mode.Controls.Add(this.rdoDCO2Whole);
            this.grpDCO2Mode.Controls.Add(this.rdoDCO2Double);
            this.grpDCO2Mode.Location = new System.Drawing.Point(324, 166);
            this.grpDCO2Mode.Name = "grpDCO2Mode";
            this.grpDCO2Mode.Size = new System.Drawing.Size(200, 153);
            this.grpDCO2Mode.TabIndex = 25;
            this.grpDCO2Mode.TabStop = false;
            this.grpDCO2Mode.Text = "DCO Mode";
            // 
            // grpDCO2Interval
            // 
            this.grpDCO2Interval.Controls.Add(this.txtDCO2Interval);
            this.grpDCO2Interval.Controls.Add(this.trkDCO2Interval);
            this.grpDCO2Interval.Location = new System.Drawing.Point(131, 13);
            this.grpDCO2Interval.Name = "grpDCO2Interval";
            this.grpDCO2Interval.Size = new System.Drawing.Size(61, 134);
            this.grpDCO2Interval.TabIndex = 38;
            this.grpDCO2Interval.TabStop = false;
            this.grpDCO2Interval.Text = "Interval";
            // 
            // txtDCO2Interval
            // 
            this.txtDCO2Interval.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO2Interval.Location = new System.Drawing.Point(8, 105);
            this.txtDCO2Interval.Name = "txtDCO2Interval";
            this.txtDCO2Interval.ReadOnly = true;
            this.txtDCO2Interval.Size = new System.Drawing.Size(39, 20);
            this.txtDCO2Interval.TabIndex = 7;
            this.txtDCO2Interval.TabStop = false;
            this.txtDCO2Interval.Text = "0";
            this.txtDCO2Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO2Interval
            // 
            this.trkDCO2Interval.Location = new System.Drawing.Point(8, 19);
            this.trkDCO2Interval.Maximum = 12;
            this.trkDCO2Interval.Name = "trkDCO2Interval";
            this.trkDCO2Interval.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO2Interval.Size = new System.Drawing.Size(45, 80);
            this.trkDCO2Interval.TabIndex = 6;
            this.trkDCO2Interval.Scroll += new System.EventHandler(this.trkDCO2Interval_Scroll);
            // 
            // grpDCO2Detune
            // 
            this.grpDCO2Detune.Controls.Add(this.txtDCO2Detune);
            this.grpDCO2Detune.Controls.Add(this.trkDCO2Detune);
            this.grpDCO2Detune.Location = new System.Drawing.Point(71, 13);
            this.grpDCO2Detune.Name = "grpDCO2Detune";
            this.grpDCO2Detune.Size = new System.Drawing.Size(60, 134);
            this.grpDCO2Detune.TabIndex = 29;
            this.grpDCO2Detune.TabStop = false;
            this.grpDCO2Detune.Text = "Detune";
            // 
            // txtDCO2Detune
            // 
            this.txtDCO2Detune.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO2Detune.Location = new System.Drawing.Point(8, 105);
            this.txtDCO2Detune.Name = "txtDCO2Detune";
            this.txtDCO2Detune.ReadOnly = true;
            this.txtDCO2Detune.Size = new System.Drawing.Size(39, 20);
            this.txtDCO2Detune.TabIndex = 11;
            this.txtDCO2Detune.TabStop = false;
            this.txtDCO2Detune.Text = "0";
            this.txtDCO2Detune.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO2Detune
            // 
            this.trkDCO2Detune.Location = new System.Drawing.Point(8, 19);
            this.trkDCO2Detune.Maximum = 3;
            this.trkDCO2Detune.Name = "trkDCO2Detune";
            this.trkDCO2Detune.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO2Detune.Size = new System.Drawing.Size(45, 80);
            this.trkDCO2Detune.TabIndex = 10;
            this.trkDCO2Detune.Scroll += new System.EventHandler(this.trkDCO2Detune_Scroll);
            // 
            // rdoDCO2Whole
            // 
            this.rdoDCO2Whole.AutoSize = true;
            this.rdoDCO2Whole.Location = new System.Drawing.Point(6, 19);
            this.rdoDCO2Whole.Name = "rdoDCO2Whole";
            this.rdoDCO2Whole.Size = new System.Drawing.Size(56, 17);
            this.rdoDCO2Whole.TabIndex = 7;
            this.rdoDCO2Whole.Text = global::KorgEX800Editor.Resources.UiTextWhole;
            this.rdoDCO2Whole.UseVisualStyleBackColor = true;
            this.rdoDCO2Whole.CheckedChanged += new System.EventHandler(this.rdoDCO2Whole_CheckedChanged);
            // 
            // rdoDCO2Double
            // 
            this.rdoDCO2Double.AutoSize = true;
            this.rdoDCO2Double.Checked = true;
            this.rdoDCO2Double.Location = new System.Drawing.Point(6, 42);
            this.rdoDCO2Double.Name = "rdoDCO2Double";
            this.rdoDCO2Double.Size = new System.Drawing.Size(59, 17);
            this.rdoDCO2Double.TabIndex = 6;
            this.rdoDCO2Double.TabStop = true;
            this.rdoDCO2Double.Text = global::KorgEX800Editor.Resources.UiTextDouble;
            this.rdoDCO2Double.UseVisualStyleBackColor = true;
            this.rdoDCO2Double.CheckedChanged += new System.EventHandler(this.rdoDCO2Double_CheckedChanged);
            // 
            // grpDCO2Decay
            // 
            this.grpDCO2Decay.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO2Decay.Controls.Add(this.txtDCO2Decay);
            this.grpDCO2Decay.Controls.Add(this.trkDCO2Decay);
            this.grpDCO2Decay.Location = new System.Drawing.Point(169, 7);
            this.grpDCO2Decay.Name = "grpDCO2Decay";
            this.grpDCO2Decay.Size = new System.Drawing.Size(60, 153);
            this.grpDCO2Decay.TabIndex = 32;
            this.grpDCO2Decay.TabStop = false;
            this.grpDCO2Decay.Text = "Decay";
            // 
            // txtDCO2Decay
            // 
            this.txtDCO2Decay.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO2Decay.Location = new System.Drawing.Point(8, 127);
            this.txtDCO2Decay.Name = "txtDCO2Decay";
            this.txtDCO2Decay.ReadOnly = true;
            this.txtDCO2Decay.Size = new System.Drawing.Size(39, 20);
            this.txtDCO2Decay.TabIndex = 7;
            this.txtDCO2Decay.TabStop = false;
            this.txtDCO2Decay.Text = "0";
            this.txtDCO2Decay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO2Decay
            // 
            this.trkDCO2Decay.Location = new System.Drawing.Point(8, 14);
            this.trkDCO2Decay.Maximum = 31;
            this.trkDCO2Decay.Name = "trkDCO2Decay";
            this.trkDCO2Decay.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO2Decay.Size = new System.Drawing.Size(45, 108);
            this.trkDCO2Decay.TabIndex = 6;
            this.trkDCO2Decay.Scroll += new System.EventHandler(this.trkDCO2Decay_Scroll);
            // 
            // grpDCO2Break
            // 
            this.grpDCO2Break.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO2Break.Controls.Add(this.txtDCO2Break);
            this.grpDCO2Break.Controls.Add(this.trkDCO2Break);
            this.grpDCO2Break.Location = new System.Drawing.Point(228, 7);
            this.grpDCO2Break.Name = "grpDCO2Break";
            this.grpDCO2Break.Size = new System.Drawing.Size(60, 153);
            this.grpDCO2Break.TabIndex = 33;
            this.grpDCO2Break.TabStop = false;
            this.grpDCO2Break.Text = "Break";
            // 
            // txtDCO2Break
            // 
            this.txtDCO2Break.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO2Break.Location = new System.Drawing.Point(8, 127);
            this.txtDCO2Break.Name = "txtDCO2Break";
            this.txtDCO2Break.ReadOnly = true;
            this.txtDCO2Break.Size = new System.Drawing.Size(39, 20);
            this.txtDCO2Break.TabIndex = 7;
            this.txtDCO2Break.TabStop = false;
            this.txtDCO2Break.Text = "0";
            this.txtDCO2Break.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO2Break
            // 
            this.trkDCO2Break.Location = new System.Drawing.Point(8, 14);
            this.trkDCO2Break.Maximum = 31;
            this.trkDCO2Break.Name = "trkDCO2Break";
            this.trkDCO2Break.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO2Break.Size = new System.Drawing.Size(45, 108);
            this.trkDCO2Break.TabIndex = 6;
            this.trkDCO2Break.Scroll += new System.EventHandler(this.trkDCO2Break_Scroll);
            // 
            // grpDCO2Attack
            // 
            this.grpDCO2Attack.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO2Attack.Controls.Add(this.txtDCO2Attack);
            this.grpDCO2Attack.Controls.Add(this.trkDCO2Attack);
            this.grpDCO2Attack.Location = new System.Drawing.Point(110, 7);
            this.grpDCO2Attack.Name = "grpDCO2Attack";
            this.grpDCO2Attack.Size = new System.Drawing.Size(60, 153);
            this.grpDCO2Attack.TabIndex = 31;
            this.grpDCO2Attack.TabStop = false;
            this.grpDCO2Attack.Text = "Attack";
            // 
            // txtDCO2Attack
            // 
            this.txtDCO2Attack.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO2Attack.Location = new System.Drawing.Point(8, 127);
            this.txtDCO2Attack.Name = "txtDCO2Attack";
            this.txtDCO2Attack.ReadOnly = true;
            this.txtDCO2Attack.Size = new System.Drawing.Size(39, 20);
            this.txtDCO2Attack.TabIndex = 7;
            this.txtDCO2Attack.TabStop = false;
            this.txtDCO2Attack.Text = "0";
            this.txtDCO2Attack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO2Attack
            // 
            this.trkDCO2Attack.Location = new System.Drawing.Point(8, 14);
            this.trkDCO2Attack.Maximum = 31;
            this.trkDCO2Attack.Name = "trkDCO2Attack";
            this.trkDCO2Attack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO2Attack.Size = new System.Drawing.Size(45, 108);
            this.trkDCO2Attack.TabIndex = 6;
            this.trkDCO2Attack.Scroll += new System.EventHandler(this.trkDCO2Attack_Scroll);
            // 
            // grpDCO2Level
            // 
            this.grpDCO2Level.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO2Level.Controls.Add(this.txtDCO2Level);
            this.grpDCO2Level.Controls.Add(this.trkDCO2Level);
            this.grpDCO2Level.Location = new System.Drawing.Point(464, 7);
            this.grpDCO2Level.Name = "grpDCO2Level";
            this.grpDCO2Level.Size = new System.Drawing.Size(60, 153);
            this.grpDCO2Level.TabIndex = 30;
            this.grpDCO2Level.TabStop = false;
            this.grpDCO2Level.Text = "Level";
            // 
            // txtDCO2Level
            // 
            this.txtDCO2Level.BackColor = System.Drawing.SystemColors.Control;
            this.txtDCO2Level.Location = new System.Drawing.Point(8, 127);
            this.txtDCO2Level.Name = "txtDCO2Level";
            this.txtDCO2Level.ReadOnly = true;
            this.txtDCO2Level.Size = new System.Drawing.Size(39, 20);
            this.txtDCO2Level.TabIndex = 7;
            this.txtDCO2Level.TabStop = false;
            this.txtDCO2Level.Text = "0";
            this.txtDCO2Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkDCO2Level
            // 
            this.trkDCO2Level.Location = new System.Drawing.Point(8, 14);
            this.trkDCO2Level.Maximum = 31;
            this.trkDCO2Level.Name = "trkDCO2Level";
            this.trkDCO2Level.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkDCO2Level.Size = new System.Drawing.Size(45, 108);
            this.trkDCO2Level.TabIndex = 6;
            this.trkDCO2Level.Scroll += new System.EventHandler(this.trkDCO2Level_Scroll);
            // 
            // grpDCO2Harmonics
            // 
            this.grpDCO2Harmonics.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO2Harmonics.Controls.Add(this.chkDCO2Harmonic2);
            this.grpDCO2Harmonics.Controls.Add(this.chkDCO2Harmonic4);
            this.grpDCO2Harmonics.Controls.Add(this.chkDCO2Harmonic8);
            this.grpDCO2Harmonics.Controls.Add(this.chkDCO2Harmonic16);
            this.grpDCO2Harmonics.Location = new System.Drawing.Point(7, 112);
            this.grpDCO2Harmonics.Name = "grpDCO2Harmonics";
            this.grpDCO2Harmonics.Size = new System.Drawing.Size(97, 125);
            this.grpDCO2Harmonics.TabIndex = 27;
            this.grpDCO2Harmonics.TabStop = false;
            this.grpDCO2Harmonics.Text = "Harmonics";
            // 
            // chkDCO2Harmonic2
            // 
            this.chkDCO2Harmonic2.AutoSize = true;
            this.chkDCO2Harmonic2.Location = new System.Drawing.Point(6, 89);
            this.chkDCO2Harmonic2.Name = "chkDCO2Harmonic2";
            this.chkDCO2Harmonic2.Size = new System.Drawing.Size(34, 17);
            this.chkDCO2Harmonic2.TabIndex = 3;
            this.chkDCO2Harmonic2.Text = "2\'";
            this.chkDCO2Harmonic2.UseVisualStyleBackColor = true;
            this.chkDCO2Harmonic2.CheckedChanged += new System.EventHandler(this.chkDCO2Harmonic2_CheckedChanged);
            // 
            // chkDCO2Harmonic4
            // 
            this.chkDCO2Harmonic4.AutoSize = true;
            this.chkDCO2Harmonic4.Location = new System.Drawing.Point(6, 66);
            this.chkDCO2Harmonic4.Name = "chkDCO2Harmonic4";
            this.chkDCO2Harmonic4.Size = new System.Drawing.Size(34, 17);
            this.chkDCO2Harmonic4.TabIndex = 2;
            this.chkDCO2Harmonic4.Text = "4\'";
            this.chkDCO2Harmonic4.UseVisualStyleBackColor = true;
            this.chkDCO2Harmonic4.CheckedChanged += new System.EventHandler(this.chkDCO2Harmonic4_CheckedChanged);
            // 
            // chkDCO2Harmonic8
            // 
            this.chkDCO2Harmonic8.AutoSize = true;
            this.chkDCO2Harmonic8.Location = new System.Drawing.Point(6, 43);
            this.chkDCO2Harmonic8.Name = "chkDCO2Harmonic8";
            this.chkDCO2Harmonic8.Size = new System.Drawing.Size(34, 17);
            this.chkDCO2Harmonic8.TabIndex = 1;
            this.chkDCO2Harmonic8.Text = "8\'";
            this.chkDCO2Harmonic8.UseVisualStyleBackColor = true;
            this.chkDCO2Harmonic8.CheckedChanged += new System.EventHandler(this.chkDCO2Harmonic8_CheckedChanged);
            // 
            // chkDCO2Harmonic16
            // 
            this.chkDCO2Harmonic16.AutoSize = true;
            this.chkDCO2Harmonic16.Location = new System.Drawing.Point(6, 19);
            this.chkDCO2Harmonic16.Name = "chkDCO2Harmonic16";
            this.chkDCO2Harmonic16.Size = new System.Drawing.Size(40, 17);
            this.chkDCO2Harmonic16.TabIndex = 0;
            this.chkDCO2Harmonic16.Text = "16\'";
            this.chkDCO2Harmonic16.UseVisualStyleBackColor = true;
            this.chkDCO2Harmonic16.CheckedChanged += new System.EventHandler(this.chkDCO2Harmonic16_CheckedChanged);
            // 
            // grpDCO2Waveform
            // 
            this.grpDCO2Waveform.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO2Waveform.Controls.Add(this.rdoDCO2Sawtooth);
            this.grpDCO2Waveform.Controls.Add(this.rdoDCO2Squarewave);
            this.grpDCO2Waveform.Location = new System.Drawing.Point(7, 243);
            this.grpDCO2Waveform.Name = "grpDCO2Waveform";
            this.grpDCO2Waveform.Size = new System.Drawing.Size(97, 76);
            this.grpDCO2Waveform.TabIndex = 29;
            this.grpDCO2Waveform.TabStop = false;
            this.grpDCO2Waveform.Text = "Waveform";
            // 
            // rdoDCO2Sawtooth
            // 
            this.rdoDCO2Sawtooth.AutoSize = true;
            this.rdoDCO2Sawtooth.Location = new System.Drawing.Point(6, 19);
            this.rdoDCO2Sawtooth.Name = "rdoDCO2Sawtooth";
            this.rdoDCO2Sawtooth.Size = new System.Drawing.Size(70, 17);
            this.rdoDCO2Sawtooth.TabIndex = 5;
            this.rdoDCO2Sawtooth.Text = global::KorgEX800Editor.Resources.UiTextSawtooth;
            this.rdoDCO2Sawtooth.UseVisualStyleBackColor = true;
            this.rdoDCO2Sawtooth.CheckedChanged += new System.EventHandler(this.rdoDCO2Sawtooth_CheckedChanged);
            // 
            // rdoDCO2Squarewave
            // 
            this.rdoDCO2Squarewave.AutoSize = true;
            this.rdoDCO2Squarewave.Checked = true;
            this.rdoDCO2Squarewave.Location = new System.Drawing.Point(6, 42);
            this.rdoDCO2Squarewave.Name = "rdoDCO2Squarewave";
            this.rdoDCO2Squarewave.Size = new System.Drawing.Size(85, 17);
            this.rdoDCO2Squarewave.TabIndex = 4;
            this.rdoDCO2Squarewave.TabStop = true;
            this.rdoDCO2Squarewave.Text = global::KorgEX800Editor.Resources.UiTextSquarewave;
            this.rdoDCO2Squarewave.UseVisualStyleBackColor = true;
            this.rdoDCO2Squarewave.CheckedChanged += new System.EventHandler(this.rdoDCO2Squarewave_CheckedChanged);
            // 
            // grpDCO2Octave
            // 
            this.grpDCO2Octave.BackColor = System.Drawing.SystemColors.Control;
            this.grpDCO2Octave.Controls.Add(this.rdoDCO2High);
            this.grpDCO2Octave.Controls.Add(this.rdoDCO2Mid);
            this.grpDCO2Octave.Controls.Add(this.rdoDCO2Low);
            this.grpDCO2Octave.Location = new System.Drawing.Point(7, 7);
            this.grpDCO2Octave.Name = "grpDCO2Octave";
            this.grpDCO2Octave.Size = new System.Drawing.Size(97, 99);
            this.grpDCO2Octave.TabIndex = 26;
            this.grpDCO2Octave.TabStop = false;
            this.grpDCO2Octave.Text = "Octave";
            // 
            // rdoDCO2High
            // 
            this.rdoDCO2High.AutoSize = true;
            this.rdoDCO2High.Location = new System.Drawing.Point(6, 19);
            this.rdoDCO2High.Name = "rdoDCO2High";
            this.rdoDCO2High.Size = new System.Drawing.Size(47, 17);
            this.rdoDCO2High.TabIndex = 3;
            this.rdoDCO2High.Text = global::KorgEX800Editor.Resources.UiTextHigh;
            this.rdoDCO2High.UseVisualStyleBackColor = true;
            this.rdoDCO2High.CheckedChanged += new System.EventHandler(this.rdoDCO2High_CheckedChanged);
            // 
            // rdoDCO2Mid
            // 
            this.rdoDCO2Mid.AutoSize = true;
            this.rdoDCO2Mid.Checked = true;
            this.rdoDCO2Mid.Location = new System.Drawing.Point(6, 42);
            this.rdoDCO2Mid.Name = "rdoDCO2Mid";
            this.rdoDCO2Mid.Size = new System.Drawing.Size(42, 17);
            this.rdoDCO2Mid.TabIndex = 4;
            this.rdoDCO2Mid.TabStop = true;
            this.rdoDCO2Mid.Text = global::KorgEX800Editor.Resources.UiTextMid;
            this.rdoDCO2Mid.UseVisualStyleBackColor = true;
            this.rdoDCO2Mid.CheckedChanged += new System.EventHandler(this.rdoDCO2Mid_CheckedChanged);
            // 
            // rdoDCO2Low
            // 
            this.rdoDCO2Low.AutoSize = true;
            this.rdoDCO2Low.Location = new System.Drawing.Point(6, 65);
            this.rdoDCO2Low.Name = "rdoDCO2Low";
            this.rdoDCO2Low.Size = new System.Drawing.Size(45, 17);
            this.rdoDCO2Low.TabIndex = 5;
            this.rdoDCO2Low.Text = global::KorgEX800Editor.Resources.UiTextLow;
            this.rdoDCO2Low.UseVisualStyleBackColor = true;
            this.rdoDCO2Low.CheckedChanged += new System.EventHandler(this.rdoDCO2Low_CheckedChanged);
            // 
            // tabVCF
            // 
            this.tabVCF.BackColor = System.Drawing.SystemColors.Control;
            this.tabVCF.Controls.Add(this.grpVCFEGIntensity);
            this.tabVCF.Controls.Add(this.grpVCFResonance);
            this.tabVCF.Controls.Add(this.grpVCFCutoff);
            this.tabVCF.Controls.Add(this.grpNoise);
            this.tabVCF.Controls.Add(this.grpChorus);
            this.tabVCF.Controls.Add(this.grpMG);
            this.tabVCF.Controls.Add(this.grpTrigger);
            this.tabVCF.Controls.Add(this.grpVCFRelease);
            this.tabVCF.Controls.Add(this.grpVCFSustain);
            this.tabVCF.Controls.Add(this.grpVCFSlope);
            this.tabVCF.Controls.Add(this.grpVCFDecay);
            this.tabVCF.Controls.Add(this.grpVCFBreak);
            this.tabVCF.Controls.Add(this.grpPolarity);
            this.tabVCF.Controls.Add(this.grpKBDTrack);
            this.tabVCF.Controls.Add(this.grpVCFAttack);
            this.tabVCF.Location = new System.Drawing.Point(4, 22);
            this.tabVCF.Name = "tabVCF";
            this.tabVCF.Size = new System.Drawing.Size(532, 330);
            this.tabVCF.TabIndex = 2;
            this.tabVCF.Text = global::KorgEX800Editor.Resources.UiTextVCFandMG;
            // 
            // grpVCFEGIntensity
            // 
            this.grpVCFEGIntensity.BackColor = System.Drawing.SystemColors.Control;
            this.grpVCFEGIntensity.Controls.Add(this.txtVCFEGIntensity);
            this.grpVCFEGIntensity.Controls.Add(this.trkVCFEGIntensity);
            this.grpVCFEGIntensity.Location = new System.Drawing.Point(243, 7);
            this.grpVCFEGIntensity.Name = "grpVCFEGIntensity";
            this.grpVCFEGIntensity.Size = new System.Drawing.Size(60, 153);
            this.grpVCFEGIntensity.TabIndex = 55;
            this.grpVCFEGIntensity.TabStop = false;
            this.grpVCFEGIntensity.Text = "EG Int.";
            // 
            // txtVCFEGIntensity
            // 
            this.txtVCFEGIntensity.BackColor = System.Drawing.SystemColors.Control;
            this.txtVCFEGIntensity.Location = new System.Drawing.Point(8, 127);
            this.txtVCFEGIntensity.Name = "txtVCFEGIntensity";
            this.txtVCFEGIntensity.ReadOnly = true;
            this.txtVCFEGIntensity.Size = new System.Drawing.Size(39, 20);
            this.txtVCFEGIntensity.TabIndex = 7;
            this.txtVCFEGIntensity.TabStop = false;
            this.txtVCFEGIntensity.Text = "0";
            this.txtVCFEGIntensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkVCFEGIntensity
            // 
            this.trkVCFEGIntensity.BackColor = System.Drawing.SystemColors.Control;
            this.trkVCFEGIntensity.Location = new System.Drawing.Point(8, 14);
            this.trkVCFEGIntensity.Maximum = 15;
            this.trkVCFEGIntensity.Name = "trkVCFEGIntensity";
            this.trkVCFEGIntensity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVCFEGIntensity.Size = new System.Drawing.Size(45, 108);
            this.trkVCFEGIntensity.TabIndex = 6;
            this.trkVCFEGIntensity.Scroll += new System.EventHandler(this.trkVCFEGIntensity_Scroll);
            // 
            // grpVCFResonance
            // 
            this.grpVCFResonance.BackColor = System.Drawing.SystemColors.Control;
            this.grpVCFResonance.Controls.Add(this.txtVCFResonance);
            this.grpVCFResonance.Controls.Add(this.trkVCFResonance);
            this.grpVCFResonance.Location = new System.Drawing.Point(184, 7);
            this.grpVCFResonance.Name = "grpVCFResonance";
            this.grpVCFResonance.Size = new System.Drawing.Size(60, 153);
            this.grpVCFResonance.TabIndex = 54;
            this.grpVCFResonance.TabStop = false;
            this.grpVCFResonance.Text = "Reson.";
            // 
            // txtVCFResonance
            // 
            this.txtVCFResonance.BackColor = System.Drawing.SystemColors.Control;
            this.txtVCFResonance.Location = new System.Drawing.Point(8, 127);
            this.txtVCFResonance.Name = "txtVCFResonance";
            this.txtVCFResonance.ReadOnly = true;
            this.txtVCFResonance.Size = new System.Drawing.Size(39, 20);
            this.txtVCFResonance.TabIndex = 7;
            this.txtVCFResonance.TabStop = false;
            this.txtVCFResonance.Text = "0";
            this.txtVCFResonance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkVCFResonance
            // 
            this.trkVCFResonance.BackColor = System.Drawing.SystemColors.Control;
            this.trkVCFResonance.Location = new System.Drawing.Point(8, 14);
            this.trkVCFResonance.Maximum = 15;
            this.trkVCFResonance.Name = "trkVCFResonance";
            this.trkVCFResonance.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVCFResonance.Size = new System.Drawing.Size(45, 108);
            this.trkVCFResonance.TabIndex = 6;
            this.trkVCFResonance.Scroll += new System.EventHandler(this.trkVCFResonance_Scroll);
            // 
            // grpVCFCutoff
            // 
            this.grpVCFCutoff.BackColor = System.Drawing.SystemColors.Control;
            this.grpVCFCutoff.Controls.Add(this.trkVCFCutoff);
            this.grpVCFCutoff.Controls.Add(this.txtVCFCutoff);
            this.grpVCFCutoff.Location = new System.Drawing.Point(125, 7);
            this.grpVCFCutoff.Name = "grpVCFCutoff";
            this.grpVCFCutoff.Size = new System.Drawing.Size(60, 153);
            this.grpVCFCutoff.TabIndex = 53;
            this.grpVCFCutoff.TabStop = false;
            this.grpVCFCutoff.Text = "Cutoff";
            // 
            // trkVCFCutoff
            // 
            this.trkVCFCutoff.BackColor = System.Drawing.SystemColors.Control;
            this.trkVCFCutoff.Location = new System.Drawing.Point(8, 14);
            this.trkVCFCutoff.Maximum = 99;
            this.trkVCFCutoff.Name = "trkVCFCutoff";
            this.trkVCFCutoff.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVCFCutoff.Size = new System.Drawing.Size(45, 108);
            this.trkVCFCutoff.TabIndex = 6;
            this.trkVCFCutoff.Scroll += new System.EventHandler(this.trkVCFCutoff_Scroll);
            // 
            // txtVCFCutoff
            // 
            this.txtVCFCutoff.BackColor = System.Drawing.SystemColors.Control;
            this.txtVCFCutoff.Location = new System.Drawing.Point(8, 127);
            this.txtVCFCutoff.Name = "txtVCFCutoff";
            this.txtVCFCutoff.ReadOnly = true;
            this.txtVCFCutoff.Size = new System.Drawing.Size(39, 20);
            this.txtVCFCutoff.TabIndex = 7;
            this.txtVCFCutoff.TabStop = false;
            this.txtVCFCutoff.Text = "0";
            this.txtVCFCutoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpNoise
            // 
            this.grpNoise.BackColor = System.Drawing.SystemColors.Control;
            this.grpNoise.Controls.Add(this.txtNoise);
            this.grpNoise.Controls.Add(this.trkNoise);
            this.grpNoise.Location = new System.Drawing.Point(315, 7);
            this.grpNoise.Name = "grpNoise";
            this.grpNoise.Size = new System.Drawing.Size(60, 153);
            this.grpNoise.TabIndex = 58;
            this.grpNoise.TabStop = false;
            this.grpNoise.Text = "Noise";
            // 
            // txtNoise
            // 
            this.txtNoise.BackColor = System.Drawing.SystemColors.Control;
            this.txtNoise.Location = new System.Drawing.Point(8, 127);
            this.txtNoise.Name = "txtNoise";
            this.txtNoise.ReadOnly = true;
            this.txtNoise.Size = new System.Drawing.Size(39, 20);
            this.txtNoise.TabIndex = 7;
            this.txtNoise.TabStop = false;
            this.txtNoise.Text = "0";
            this.txtNoise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkNoise
            // 
            this.trkNoise.BackColor = System.Drawing.SystemColors.Control;
            this.trkNoise.Location = new System.Drawing.Point(8, 14);
            this.trkNoise.Maximum = 15;
            this.trkNoise.Name = "trkNoise";
            this.trkNoise.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkNoise.Size = new System.Drawing.Size(45, 108);
            this.trkNoise.TabIndex = 6;
            this.trkNoise.Scroll += new System.EventHandler(this.trkNoise_Scroll);
            // 
            // grpChorus
            // 
            this.grpChorus.BackColor = System.Drawing.SystemColors.Control;
            this.grpChorus.Controls.Add(this.rdoChorusOn);
            this.grpChorus.Controls.Add(this.rdoChorusOff);
            this.grpChorus.Location = new System.Drawing.Point(7, 84);
            this.grpChorus.Name = "grpChorus";
            this.grpChorus.Size = new System.Drawing.Size(60, 76);
            this.grpChorus.TabIndex = 57;
            this.grpChorus.TabStop = false;
            this.grpChorus.Text = "Chorus";
            // 
            // rdoChorusOn
            // 
            this.rdoChorusOn.AutoSize = true;
            this.rdoChorusOn.Location = new System.Drawing.Point(6, 19);
            this.rdoChorusOn.Name = "rdoChorusOn";
            this.rdoChorusOn.Size = new System.Drawing.Size(39, 17);
            this.rdoChorusOn.TabIndex = 5;
            this.rdoChorusOn.Text = global::KorgEX800Editor.Resources.UiTextOn;
            this.rdoChorusOn.UseVisualStyleBackColor = true;
            this.rdoChorusOn.CheckedChanged += new System.EventHandler(this.rdoChorus_CheckedChanged);
            // 
            // rdoChorusOff
            // 
            this.rdoChorusOff.AutoSize = true;
            this.rdoChorusOff.Checked = true;
            this.rdoChorusOff.Location = new System.Drawing.Point(6, 42);
            this.rdoChorusOff.Name = "rdoChorusOff";
            this.rdoChorusOff.Size = new System.Drawing.Size(39, 17);
            this.rdoChorusOff.TabIndex = 4;
            this.rdoChorusOff.TabStop = true;
            this.rdoChorusOff.Text = global::KorgEX800Editor.Resources.UiTextOff;
            this.rdoChorusOff.UseVisualStyleBackColor = true;
            this.rdoChorusOff.CheckedChanged += new System.EventHandler(this.rdoChorus_CheckedChanged);
            // 
            // grpMG
            // 
            this.grpMG.Controls.Add(this.grpMGDelay);
            this.grpMG.Controls.Add(this.grpMGFrequency);
            this.grpMG.Controls.Add(this.grpMGVCF);
            this.grpMG.Controls.Add(this.grpMGDCO);
            this.grpMG.Location = new System.Drawing.Point(385, 7);
            this.grpMG.Name = "grpMG";
            this.grpMG.Size = new System.Drawing.Size(139, 312);
            this.grpMG.TabIndex = 56;
            this.grpMG.TabStop = false;
            this.grpMG.Text = "Modulation Generator";
            // 
            // grpMGDelay
            // 
            this.grpMGDelay.Controls.Add(this.txtMGDelay);
            this.grpMGDelay.Controls.Add(this.trkMGDelay);
            this.grpMGDelay.Location = new System.Drawing.Point(70, 19);
            this.grpMGDelay.Name = "grpMGDelay";
            this.grpMGDelay.Size = new System.Drawing.Size(60, 140);
            this.grpMGDelay.TabIndex = 43;
            this.grpMGDelay.TabStop = false;
            this.grpMGDelay.Text = "Delay";
            // 
            // txtMGDelay
            // 
            this.txtMGDelay.BackColor = System.Drawing.SystemColors.Control;
            this.txtMGDelay.Location = new System.Drawing.Point(8, 114);
            this.txtMGDelay.Name = "txtMGDelay";
            this.txtMGDelay.ReadOnly = true;
            this.txtMGDelay.Size = new System.Drawing.Size(39, 20);
            this.txtMGDelay.TabIndex = 7;
            this.txtMGDelay.TabStop = false;
            this.txtMGDelay.Text = "0";
            this.txtMGDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkMGDelay
            // 
            this.trkMGDelay.Location = new System.Drawing.Point(8, 16);
            this.trkMGDelay.Maximum = 15;
            this.trkMGDelay.Name = "trkMGDelay";
            this.trkMGDelay.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkMGDelay.Size = new System.Drawing.Size(45, 92);
            this.trkMGDelay.TabIndex = 6;
            this.trkMGDelay.Scroll += new System.EventHandler(this.trkMGDelay_Scroll);
            // 
            // grpMGFrequency
            // 
            this.grpMGFrequency.Controls.Add(this.txtMGFrequency);
            this.grpMGFrequency.Controls.Add(this.trkMGFrequency);
            this.grpMGFrequency.Location = new System.Drawing.Point(10, 19);
            this.grpMGFrequency.Name = "grpMGFrequency";
            this.grpMGFrequency.Size = new System.Drawing.Size(60, 140);
            this.grpMGFrequency.TabIndex = 42;
            this.grpMGFrequency.TabStop = false;
            this.grpMGFrequency.Text = "Freq.";
            // 
            // txtMGFrequency
            // 
            this.txtMGFrequency.BackColor = System.Drawing.SystemColors.Control;
            this.txtMGFrequency.Location = new System.Drawing.Point(8, 114);
            this.txtMGFrequency.Name = "txtMGFrequency";
            this.txtMGFrequency.ReadOnly = true;
            this.txtMGFrequency.Size = new System.Drawing.Size(39, 20);
            this.txtMGFrequency.TabIndex = 11;
            this.txtMGFrequency.TabStop = false;
            this.txtMGFrequency.Text = "0";
            this.txtMGFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkMGFrequency
            // 
            this.trkMGFrequency.Location = new System.Drawing.Point(8, 16);
            this.trkMGFrequency.Maximum = 15;
            this.trkMGFrequency.Name = "trkMGFrequency";
            this.trkMGFrequency.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkMGFrequency.Size = new System.Drawing.Size(45, 92);
            this.trkMGFrequency.TabIndex = 10;
            this.trkMGFrequency.Scroll += new System.EventHandler(this.trkMGFrequency_Scroll);
            // 
            // grpMGVCF
            // 
            this.grpMGVCF.Controls.Add(this.txtMGVCF);
            this.grpMGVCF.Controls.Add(this.trkMGVCF);
            this.grpMGVCF.Location = new System.Drawing.Point(70, 165);
            this.grpMGVCF.Name = "grpMGVCF";
            this.grpMGVCF.Size = new System.Drawing.Size(60, 140);
            this.grpMGVCF.TabIndex = 41;
            this.grpMGVCF.TabStop = false;
            this.grpMGVCF.Text = "VCF";
            // 
            // txtMGVCF
            // 
            this.txtMGVCF.BackColor = System.Drawing.SystemColors.Control;
            this.txtMGVCF.Location = new System.Drawing.Point(8, 114);
            this.txtMGVCF.Name = "txtMGVCF";
            this.txtMGVCF.ReadOnly = true;
            this.txtMGVCF.Size = new System.Drawing.Size(39, 20);
            this.txtMGVCF.TabIndex = 7;
            this.txtMGVCF.TabStop = false;
            this.txtMGVCF.Text = "0";
            this.txtMGVCF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkMGVCF
            // 
            this.trkMGVCF.Location = new System.Drawing.Point(8, 16);
            this.trkMGVCF.Maximum = 15;
            this.trkMGVCF.Name = "trkMGVCF";
            this.trkMGVCF.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkMGVCF.Size = new System.Drawing.Size(45, 92);
            this.trkMGVCF.TabIndex = 6;
            this.trkMGVCF.Scroll += new System.EventHandler(this.trkMGVCF_Scroll);
            // 
            // grpMGDCO
            // 
            this.grpMGDCO.Controls.Add(this.txtMGDCO);
            this.grpMGDCO.Controls.Add(this.trkMGDCO);
            this.grpMGDCO.Location = new System.Drawing.Point(10, 165);
            this.grpMGDCO.Name = "grpMGDCO";
            this.grpMGDCO.Size = new System.Drawing.Size(60, 140);
            this.grpMGDCO.TabIndex = 40;
            this.grpMGDCO.TabStop = false;
            this.grpMGDCO.Text = "DCO";
            // 
            // txtMGDCO
            // 
            this.txtMGDCO.BackColor = System.Drawing.SystemColors.Control;
            this.txtMGDCO.Location = new System.Drawing.Point(8, 114);
            this.txtMGDCO.Name = "txtMGDCO";
            this.txtMGDCO.ReadOnly = true;
            this.txtMGDCO.Size = new System.Drawing.Size(39, 20);
            this.txtMGDCO.TabIndex = 11;
            this.txtMGDCO.TabStop = false;
            this.txtMGDCO.Text = "0";
            this.txtMGDCO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkMGDCO
            // 
            this.trkMGDCO.Location = new System.Drawing.Point(8, 16);
            this.trkMGDCO.Maximum = 15;
            this.trkMGDCO.Name = "trkMGDCO";
            this.trkMGDCO.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkMGDCO.Size = new System.Drawing.Size(45, 92);
            this.trkMGDCO.TabIndex = 10;
            this.trkMGDCO.Scroll += new System.EventHandler(this.trkMGDCO_Scroll);
            // 
            // grpTrigger
            // 
            this.grpTrigger.BackColor = System.Drawing.SystemColors.Control;
            this.grpTrigger.Controls.Add(this.rdoTriggerSingle);
            this.grpTrigger.Controls.Add(this.rdoTriggerMulti);
            this.grpTrigger.Location = new System.Drawing.Point(67, 84);
            this.grpTrigger.Name = "grpTrigger";
            this.grpTrigger.Size = new System.Drawing.Size(59, 76);
            this.grpTrigger.TabIndex = 45;
            this.grpTrigger.TabStop = false;
            this.grpTrigger.Text = "Trigger";
            // 
            // rdoTriggerSingle
            // 
            this.rdoTriggerSingle.AutoSize = true;
            this.rdoTriggerSingle.Location = new System.Drawing.Point(6, 19);
            this.rdoTriggerSingle.Name = "rdoTriggerSingle";
            this.rdoTriggerSingle.Size = new System.Drawing.Size(54, 17);
            this.rdoTriggerSingle.TabIndex = 5;
            this.rdoTriggerSingle.Text = global::KorgEX800Editor.Resources.UiTextSingle;
            this.rdoTriggerSingle.UseVisualStyleBackColor = true;
            this.rdoTriggerSingle.CheckedChanged += new System.EventHandler(this.rdoTrigger_CheckedChanged);
            // 
            // rdoTriggerMulti
            // 
            this.rdoTriggerMulti.AutoSize = true;
            this.rdoTriggerMulti.Checked = true;
            this.rdoTriggerMulti.Location = new System.Drawing.Point(6, 42);
            this.rdoTriggerMulti.Name = "rdoTriggerMulti";
            this.rdoTriggerMulti.Size = new System.Drawing.Size(47, 17);
            this.rdoTriggerMulti.TabIndex = 4;
            this.rdoTriggerMulti.TabStop = true;
            this.rdoTriggerMulti.Text = global::KorgEX800Editor.Resources.UiTextMulti;
            this.rdoTriggerMulti.UseVisualStyleBackColor = true;
            this.rdoTriggerMulti.CheckedChanged += new System.EventHandler(this.rdoTrigger_CheckedChanged);
            // 
            // grpVCFRelease
            // 
            this.grpVCFRelease.BackColor = System.Drawing.SystemColors.Control;
            this.grpVCFRelease.Controls.Add(this.txtVCFRelease);
            this.grpVCFRelease.Controls.Add(this.trkVCFRelease);
            this.grpVCFRelease.Location = new System.Drawing.Point(302, 166);
            this.grpVCFRelease.Name = "grpVCFRelease";
            this.grpVCFRelease.Size = new System.Drawing.Size(60, 153);
            this.grpVCFRelease.TabIndex = 49;
            this.grpVCFRelease.TabStop = false;
            this.grpVCFRelease.Text = "Release";
            // 
            // txtVCFRelease
            // 
            this.txtVCFRelease.BackColor = System.Drawing.SystemColors.Control;
            this.txtVCFRelease.Location = new System.Drawing.Point(8, 128);
            this.txtVCFRelease.Name = "txtVCFRelease";
            this.txtVCFRelease.ReadOnly = true;
            this.txtVCFRelease.Size = new System.Drawing.Size(39, 20);
            this.txtVCFRelease.TabIndex = 7;
            this.txtVCFRelease.TabStop = false;
            this.txtVCFRelease.Text = "0";
            this.txtVCFRelease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkVCFRelease
            // 
            this.trkVCFRelease.Location = new System.Drawing.Point(8, 14);
            this.trkVCFRelease.Maximum = 31;
            this.trkVCFRelease.Name = "trkVCFRelease";
            this.trkVCFRelease.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVCFRelease.Size = new System.Drawing.Size(45, 108);
            this.trkVCFRelease.TabIndex = 6;
            this.trkVCFRelease.Scroll += new System.EventHandler(this.trkVCFRelease_Scroll);
            // 
            // grpVCFSustain
            // 
            this.grpVCFSustain.BackColor = System.Drawing.SystemColors.Control;
            this.grpVCFSustain.Controls.Add(this.txtVCFSustain);
            this.grpVCFSustain.Controls.Add(this.trkVCFSustain);
            this.grpVCFSustain.Location = new System.Drawing.Point(243, 166);
            this.grpVCFSustain.Name = "grpVCFSustain";
            this.grpVCFSustain.Size = new System.Drawing.Size(60, 153);
            this.grpVCFSustain.TabIndex = 48;
            this.grpVCFSustain.TabStop = false;
            this.grpVCFSustain.Text = "Sustain";
            // 
            // txtVCFSustain
            // 
            this.txtVCFSustain.BackColor = System.Drawing.SystemColors.Control;
            this.txtVCFSustain.Location = new System.Drawing.Point(8, 127);
            this.txtVCFSustain.Name = "txtVCFSustain";
            this.txtVCFSustain.ReadOnly = true;
            this.txtVCFSustain.Size = new System.Drawing.Size(39, 20);
            this.txtVCFSustain.TabIndex = 7;
            this.txtVCFSustain.TabStop = false;
            this.txtVCFSustain.Text = "0";
            this.txtVCFSustain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkVCFSustain
            // 
            this.trkVCFSustain.Location = new System.Drawing.Point(8, 14);
            this.trkVCFSustain.Maximum = 31;
            this.trkVCFSustain.Name = "trkVCFSustain";
            this.trkVCFSustain.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVCFSustain.Size = new System.Drawing.Size(45, 108);
            this.trkVCFSustain.TabIndex = 6;
            this.trkVCFSustain.Scroll += new System.EventHandler(this.trkVCFSustain_Scroll);
            // 
            // grpVCFSlope
            // 
            this.grpVCFSlope.BackColor = System.Drawing.SystemColors.Control;
            this.grpVCFSlope.Controls.Add(this.txtVCFSlope);
            this.grpVCFSlope.Controls.Add(this.trkVCFSlope);
            this.grpVCFSlope.Location = new System.Drawing.Point(184, 166);
            this.grpVCFSlope.Name = "grpVCFSlope";
            this.grpVCFSlope.Size = new System.Drawing.Size(60, 153);
            this.grpVCFSlope.TabIndex = 47;
            this.grpVCFSlope.TabStop = false;
            this.grpVCFSlope.Text = "Slope";
            // 
            // txtVCFSlope
            // 
            this.txtVCFSlope.BackColor = System.Drawing.SystemColors.Control;
            this.txtVCFSlope.Location = new System.Drawing.Point(8, 127);
            this.txtVCFSlope.Name = "txtVCFSlope";
            this.txtVCFSlope.ReadOnly = true;
            this.txtVCFSlope.Size = new System.Drawing.Size(39, 20);
            this.txtVCFSlope.TabIndex = 7;
            this.txtVCFSlope.TabStop = false;
            this.txtVCFSlope.Text = "0";
            this.txtVCFSlope.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkVCFSlope
            // 
            this.trkVCFSlope.Location = new System.Drawing.Point(8, 14);
            this.trkVCFSlope.Maximum = 31;
            this.trkVCFSlope.Name = "trkVCFSlope";
            this.trkVCFSlope.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVCFSlope.Size = new System.Drawing.Size(45, 108);
            this.trkVCFSlope.TabIndex = 6;
            this.trkVCFSlope.Scroll += new System.EventHandler(this.trkVCFSlope_Scroll);
            // 
            // grpVCFDecay
            // 
            this.grpVCFDecay.BackColor = System.Drawing.SystemColors.Control;
            this.grpVCFDecay.Controls.Add(this.txtVCFDecay);
            this.grpVCFDecay.Controls.Add(this.trkVCFDecay);
            this.grpVCFDecay.Location = new System.Drawing.Point(66, 166);
            this.grpVCFDecay.Name = "grpVCFDecay";
            this.grpVCFDecay.Size = new System.Drawing.Size(60, 153);
            this.grpVCFDecay.TabIndex = 45;
            this.grpVCFDecay.TabStop = false;
            this.grpVCFDecay.Text = "Decay";
            // 
            // txtVCFDecay
            // 
            this.txtVCFDecay.BackColor = System.Drawing.SystemColors.Control;
            this.txtVCFDecay.Location = new System.Drawing.Point(8, 127);
            this.txtVCFDecay.Name = "txtVCFDecay";
            this.txtVCFDecay.ReadOnly = true;
            this.txtVCFDecay.Size = new System.Drawing.Size(39, 20);
            this.txtVCFDecay.TabIndex = 7;
            this.txtVCFDecay.TabStop = false;
            this.txtVCFDecay.Text = "0";
            this.txtVCFDecay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkVCFDecay
            // 
            this.trkVCFDecay.Location = new System.Drawing.Point(8, 14);
            this.trkVCFDecay.Maximum = 31;
            this.trkVCFDecay.Name = "trkVCFDecay";
            this.trkVCFDecay.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVCFDecay.Size = new System.Drawing.Size(45, 108);
            this.trkVCFDecay.TabIndex = 6;
            this.trkVCFDecay.Scroll += new System.EventHandler(this.trkVCFDecay_Scroll);
            // 
            // grpVCFBreak
            // 
            this.grpVCFBreak.BackColor = System.Drawing.SystemColors.Control;
            this.grpVCFBreak.Controls.Add(this.txtVCFBreak);
            this.grpVCFBreak.Controls.Add(this.trkVCFBreak);
            this.grpVCFBreak.Location = new System.Drawing.Point(125, 166);
            this.grpVCFBreak.Name = "grpVCFBreak";
            this.grpVCFBreak.Size = new System.Drawing.Size(60, 153);
            this.grpVCFBreak.TabIndex = 46;
            this.grpVCFBreak.TabStop = false;
            this.grpVCFBreak.Text = "Break";
            // 
            // txtVCFBreak
            // 
            this.txtVCFBreak.BackColor = System.Drawing.SystemColors.Control;
            this.txtVCFBreak.Location = new System.Drawing.Point(8, 127);
            this.txtVCFBreak.Name = "txtVCFBreak";
            this.txtVCFBreak.ReadOnly = true;
            this.txtVCFBreak.Size = new System.Drawing.Size(39, 20);
            this.txtVCFBreak.TabIndex = 7;
            this.txtVCFBreak.TabStop = false;
            this.txtVCFBreak.Text = "0";
            this.txtVCFBreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkVCFBreak
            // 
            this.trkVCFBreak.Location = new System.Drawing.Point(8, 14);
            this.trkVCFBreak.Maximum = 31;
            this.trkVCFBreak.Name = "trkVCFBreak";
            this.trkVCFBreak.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVCFBreak.Size = new System.Drawing.Size(45, 108);
            this.trkVCFBreak.TabIndex = 6;
            this.trkVCFBreak.Scroll += new System.EventHandler(this.trkVCFBreak_Scroll);
            // 
            // grpPolarity
            // 
            this.grpPolarity.BackColor = System.Drawing.SystemColors.Control;
            this.grpPolarity.Controls.Add(this.rdoPolarityUp);
            this.grpPolarity.Controls.Add(this.rdoPolarityDown);
            this.grpPolarity.Location = new System.Drawing.Point(67, 7);
            this.grpPolarity.Name = "grpPolarity";
            this.grpPolarity.Size = new System.Drawing.Size(60, 76);
            this.grpPolarity.TabIndex = 44;
            this.grpPolarity.TabStop = false;
            this.grpPolarity.Text = "Polarity";
            // 
            // rdoPolarityUp
            // 
            this.rdoPolarityUp.AutoSize = true;
            this.rdoPolarityUp.Location = new System.Drawing.Point(6, 19);
            this.rdoPolarityUp.Name = "rdoPolarityUp";
            this.rdoPolarityUp.Size = new System.Drawing.Size(39, 17);
            this.rdoPolarityUp.TabIndex = 5;
            this.rdoPolarityUp.Text = global::KorgEX800Editor.Resources.UiTextUp;
            this.rdoPolarityUp.UseVisualStyleBackColor = true;
            this.rdoPolarityUp.CheckedChanged += new System.EventHandler(this.rdoPolarity_CheckedChanged);
            // 
            // rdoPolarityDown
            // 
            this.rdoPolarityDown.AutoSize = true;
            this.rdoPolarityDown.Checked = true;
            this.rdoPolarityDown.Location = new System.Drawing.Point(6, 42);
            this.rdoPolarityDown.Name = "rdoPolarityDown";
            this.rdoPolarityDown.Size = new System.Drawing.Size(53, 17);
            this.rdoPolarityDown.TabIndex = 4;
            this.rdoPolarityDown.TabStop = true;
            this.rdoPolarityDown.Text = global::KorgEX800Editor.Resources.UiTextDown;
            this.rdoPolarityDown.UseVisualStyleBackColor = true;
            this.rdoPolarityDown.CheckedChanged += new System.EventHandler(this.rdoPolarity_CheckedChanged);
            // 
            // grpKBDTrack
            // 
            this.grpKBDTrack.BackColor = System.Drawing.SystemColors.Control;
            this.grpKBDTrack.Controls.Add(this.rdoKBDTrackFull);
            this.grpKBDTrack.Controls.Add(this.rdoKBDTrackHalf);
            this.grpKBDTrack.Controls.Add(this.rdoKBDTrackOff);
            this.grpKBDTrack.Location = new System.Drawing.Point(7, 7);
            this.grpKBDTrack.Name = "grpKBDTrack";
            this.grpKBDTrack.Size = new System.Drawing.Size(60, 76);
            this.grpKBDTrack.TabIndex = 43;
            this.grpKBDTrack.TabStop = false;
            this.grpKBDTrack.Text = "Track";
            // 
            // rdoKBDTrackFull
            // 
            this.rdoKBDTrackFull.AutoSize = true;
            this.rdoKBDTrackFull.Location = new System.Drawing.Point(6, 19);
            this.rdoKBDTrackFull.Name = "rdoKBDTrackFull";
            this.rdoKBDTrackFull.Size = new System.Drawing.Size(41, 17);
            this.rdoKBDTrackFull.TabIndex = 3;
            this.rdoKBDTrackFull.Text = global::KorgEX800Editor.Resources.UiTextFull;
            this.rdoKBDTrackFull.UseVisualStyleBackColor = true;
            this.rdoKBDTrackFull.CheckedChanged += new System.EventHandler(this.rdoKBDTrack_CheckedChanged);
            // 
            // rdoKBDTrackHalf
            // 
            this.rdoKBDTrackHalf.AutoSize = true;
            this.rdoKBDTrackHalf.Checked = true;
            this.rdoKBDTrackHalf.Location = new System.Drawing.Point(6, 36);
            this.rdoKBDTrackHalf.Name = "rdoKBDTrackHalf";
            this.rdoKBDTrackHalf.Size = new System.Drawing.Size(44, 17);
            this.rdoKBDTrackHalf.TabIndex = 4;
            this.rdoKBDTrackHalf.TabStop = true;
            this.rdoKBDTrackHalf.Text = global::KorgEX800Editor.Resources.UiTextHalf;
            this.rdoKBDTrackHalf.UseVisualStyleBackColor = true;
            this.rdoKBDTrackHalf.CheckedChanged += new System.EventHandler(this.rdoKBDTrack_CheckedChanged);
            // 
            // rdoKBDTrackOff
            // 
            this.rdoKBDTrackOff.AutoSize = true;
            this.rdoKBDTrackOff.Location = new System.Drawing.Point(6, 53);
            this.rdoKBDTrackOff.Name = "rdoKBDTrackOff";
            this.rdoKBDTrackOff.Size = new System.Drawing.Size(39, 17);
            this.rdoKBDTrackOff.TabIndex = 5;
            this.rdoKBDTrackOff.Text = global::KorgEX800Editor.Resources.UiTextOff;
            this.rdoKBDTrackOff.UseVisualStyleBackColor = true;
            this.rdoKBDTrackOff.CheckedChanged += new System.EventHandler(this.rdoKBDTrack_CheckedChanged);
            // 
            // grpVCFAttack
            // 
            this.grpVCFAttack.BackColor = System.Drawing.SystemColors.Control;
            this.grpVCFAttack.Controls.Add(this.txtVCFAttack);
            this.grpVCFAttack.Controls.Add(this.trkVCFAttack);
            this.grpVCFAttack.Location = new System.Drawing.Point(7, 166);
            this.grpVCFAttack.Name = "grpVCFAttack";
            this.grpVCFAttack.Size = new System.Drawing.Size(60, 153);
            this.grpVCFAttack.TabIndex = 37;
            this.grpVCFAttack.TabStop = false;
            this.grpVCFAttack.Text = "Attack";
            // 
            // txtVCFAttack
            // 
            this.txtVCFAttack.BackColor = System.Drawing.SystemColors.Control;
            this.txtVCFAttack.Location = new System.Drawing.Point(8, 127);
            this.txtVCFAttack.Name = "txtVCFAttack";
            this.txtVCFAttack.ReadOnly = true;
            this.txtVCFAttack.Size = new System.Drawing.Size(39, 20);
            this.txtVCFAttack.TabIndex = 7;
            this.txtVCFAttack.TabStop = false;
            this.txtVCFAttack.Text = "0";
            this.txtVCFAttack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trkVCFAttack
            // 
            this.trkVCFAttack.BackColor = System.Drawing.SystemColors.Control;
            this.trkVCFAttack.Location = new System.Drawing.Point(8, 14);
            this.trkVCFAttack.Maximum = 31;
            this.trkVCFAttack.Name = "trkVCFAttack";
            this.trkVCFAttack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkVCFAttack.Size = new System.Drawing.Size(45, 108);
            this.trkVCFAttack.TabIndex = 6;
            this.trkVCFAttack.Scroll += new System.EventHandler(this.trkVCFAttack_Scroll);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextFile;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextNew;
            // 
            // emptyToolStripMenuItem
            // 
            this.emptyToolStripMenuItem.Name = "emptyToolStripMenuItem";
            this.emptyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+E";
            this.emptyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.emptyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.emptyToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextEmptyVoices;
            this.emptyToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            this.randomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.randomToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextRandomVoices;
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextOpen;
            this.openToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextSave;
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextExit;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextHelp;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextAbout;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.midiToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(726, 24);
            this.mnuMain.TabIndex = 8;
            // 
            // midiToolStripMenuItem
            // 
            this.midiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendBankToolStripMenuItem,
            this.requestBankToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem});
            this.midiToolStripMenuItem.Name = "midiToolStripMenuItem";
            this.midiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.midiToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextMIDI;
            // 
            // sendBankToolStripMenuItem
            // 
            this.sendBankToolStripMenuItem.Name = "sendBankToolStripMenuItem";
            this.sendBankToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sendBankToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextSendBank;
            this.sendBankToolStripMenuItem.Click += new System.EventHandler(this.sendBankToolStripMenuItem_Click);
            // 
            // requestBankToolStripMenuItem
            // 
            this.requestBankToolStripMenuItem.Name = "requestBankToolStripMenuItem";
            this.requestBankToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.requestBankToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextRequestBank;
            this.requestBankToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDeviceToolStripMenuItem,
            this.outputDeviceToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.optionsToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextOptions;
            // 
            // inputDeviceToolStripMenuItem
            // 
            this.inputDeviceToolStripMenuItem.Name = "inputDeviceToolStripMenuItem";
            this.inputDeviceToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.inputDeviceToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextInputDevice;
            this.inputDeviceToolStripMenuItem.Click += new System.EventHandler(this.inputDeviceToolStripMenuItem_Click);
            // 
            // outputDeviceToolStripMenuItem
            // 
            this.outputDeviceToolStripMenuItem.Name = "outputDeviceToolStripMenuItem";
            this.outputDeviceToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.outputDeviceToolStripMenuItem.Text = global::KorgEX800Editor.Resources.MenuTextOutputDevice;
            this.outputDeviceToolStripMenuItem.Click += new System.EventHandler(this.outputDeviceToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(726, 418);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.lstVoices);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korg EX-800 Voice Editor";
            this.grpMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabDCO1.ResumeLayout(false);
            this.tabDCO1.PerformLayout();
            this.grpDCO1Release.ResumeLayout(false);
            this.grpDCO1Release.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Release)).EndInit();
            this.grpDCO1Sustain.ResumeLayout(false);
            this.grpDCO1Sustain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Sustain)).EndInit();
            this.grpDCO1Slope.ResumeLayout(false);
            this.grpDCO1Slope.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Slope)).EndInit();
            this.grpDCO1Mode.ResumeLayout(false);
            this.grpDCO1Mode.PerformLayout();
            this.grpDCO1Interval.ResumeLayout(false);
            this.grpDCO1Interval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Interval)).EndInit();
            this.grpDCO1Detune.ResumeLayout(false);
            this.grpDCO1Detune.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Detune)).EndInit();
            this.grpDCO1Decay.ResumeLayout(false);
            this.grpDCO1Decay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Decay)).EndInit();
            this.grpDCO1Break.ResumeLayout(false);
            this.grpDCO1Break.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Break)).EndInit();
            this.grpDCO1Attack.ResumeLayout(false);
            this.grpDCO1Attack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Attack)).EndInit();
            this.grpDCO1Level.ResumeLayout(false);
            this.grpDCO1Level.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO1Level)).EndInit();
            this.grpDCO1Harmonics.ResumeLayout(false);
            this.grpDCO1Harmonics.PerformLayout();
            this.grpDCO1Waveform.ResumeLayout(false);
            this.grpDCO1Waveform.PerformLayout();
            this.grpDCO1Octave.ResumeLayout(false);
            this.grpDCO1Octave.PerformLayout();
            this.tabDCO2.ResumeLayout(false);
            this.tabDCO2.PerformLayout();
            this.grpDCO2Release.ResumeLayout(false);
            this.grpDCO2Release.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Release)).EndInit();
            this.grpDCO2Sustain.ResumeLayout(false);
            this.grpDCO2Sustain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Sustain)).EndInit();
            this.grpDCO2Slope.ResumeLayout(false);
            this.grpDCO2Slope.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Slope)).EndInit();
            this.grpDCO2Mode.ResumeLayout(false);
            this.grpDCO2Mode.PerformLayout();
            this.grpDCO2Interval.ResumeLayout(false);
            this.grpDCO2Interval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Interval)).EndInit();
            this.grpDCO2Detune.ResumeLayout(false);
            this.grpDCO2Detune.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Detune)).EndInit();
            this.grpDCO2Decay.ResumeLayout(false);
            this.grpDCO2Decay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Decay)).EndInit();
            this.grpDCO2Break.ResumeLayout(false);
            this.grpDCO2Break.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Break)).EndInit();
            this.grpDCO2Attack.ResumeLayout(false);
            this.grpDCO2Attack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Attack)).EndInit();
            this.grpDCO2Level.ResumeLayout(false);
            this.grpDCO2Level.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDCO2Level)).EndInit();
            this.grpDCO2Harmonics.ResumeLayout(false);
            this.grpDCO2Harmonics.PerformLayout();
            this.grpDCO2Waveform.ResumeLayout(false);
            this.grpDCO2Waveform.PerformLayout();
            this.grpDCO2Octave.ResumeLayout(false);
            this.grpDCO2Octave.PerformLayout();
            this.tabVCF.ResumeLayout(false);
            this.grpVCFEGIntensity.ResumeLayout(false);
            this.grpVCFEGIntensity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFEGIntensity)).EndInit();
            this.grpVCFResonance.ResumeLayout(false);
            this.grpVCFResonance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFResonance)).EndInit();
            this.grpVCFCutoff.ResumeLayout(false);
            this.grpVCFCutoff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFCutoff)).EndInit();
            this.grpNoise.ResumeLayout(false);
            this.grpNoise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkNoise)).EndInit();
            this.grpChorus.ResumeLayout(false);
            this.grpChorus.PerformLayout();
            this.grpMG.ResumeLayout(false);
            this.grpMGDelay.ResumeLayout(false);
            this.grpMGDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMGDelay)).EndInit();
            this.grpMGFrequency.ResumeLayout(false);
            this.grpMGFrequency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMGFrequency)).EndInit();
            this.grpMGVCF.ResumeLayout(false);
            this.grpMGVCF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMGVCF)).EndInit();
            this.grpMGDCO.ResumeLayout(false);
            this.grpMGDCO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkMGDCO)).EndInit();
            this.grpTrigger.ResumeLayout(false);
            this.grpTrigger.PerformLayout();
            this.grpVCFRelease.ResumeLayout(false);
            this.grpVCFRelease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFRelease)).EndInit();
            this.grpVCFSustain.ResumeLayout(false);
            this.grpVCFSustain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFSustain)).EndInit();
            this.grpVCFSlope.ResumeLayout(false);
            this.grpVCFSlope.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFSlope)).EndInit();
            this.grpVCFDecay.ResumeLayout(false);
            this.grpVCFDecay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFDecay)).EndInit();
            this.grpVCFBreak.ResumeLayout(false);
            this.grpVCFBreak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFBreak)).EndInit();
            this.grpPolarity.ResumeLayout(false);
            this.grpPolarity.PerformLayout();
            this.grpKBDTrack.ResumeLayout(false);
            this.grpKBDTrack.PerformLayout();
            this.grpVCFAttack.ResumeLayout(false);
            this.grpVCFAttack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVCFAttack)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVoices;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabDCO1;
        private System.Windows.Forms.TabPage tabDCO2;
        private System.Windows.Forms.TabPage tabVCF;

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem midiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestBankToolStripMenuItem;

        private System.Windows.Forms.GroupBox grpDCO1Release;
        private System.Windows.Forms.TextBox txtDCO1Release;
        private System.Windows.Forms.TrackBar trkDCO1Release;
        private System.Windows.Forms.GroupBox grpDCO1Sustain;
        private System.Windows.Forms.TextBox txtDCO1Sustain;
        private System.Windows.Forms.TrackBar trkDCO1Sustain;
        private System.Windows.Forms.GroupBox grpDCO1Slope;
        private System.Windows.Forms.TextBox txtDCO1Slope;
        private System.Windows.Forms.TrackBar trkDCO1Slope;
        private System.Windows.Forms.GroupBox grpDCO1Mode;
        private System.Windows.Forms.RadioButton rdoDCO1Whole;
        private System.Windows.Forms.RadioButton rdoDCO1Double;
        private System.Windows.Forms.GroupBox grpDCO1Decay;
        private System.Windows.Forms.TextBox txtDCO1Decay;
        private System.Windows.Forms.TrackBar trkDCO1Decay;
        private System.Windows.Forms.GroupBox grpDCO1Break;
        private System.Windows.Forms.TextBox txtDCO1Break;
        private System.Windows.Forms.TrackBar trkDCO1Break;
        private System.Windows.Forms.GroupBox grpDCO1Attack;
        private System.Windows.Forms.TextBox txtDCO1Attack;
        private System.Windows.Forms.TrackBar trkDCO1Attack;
        private System.Windows.Forms.GroupBox grpDCO1Level;
        private System.Windows.Forms.TextBox txtDCO1Level;
        private System.Windows.Forms.TrackBar trkDCO1Level;
        private System.Windows.Forms.GroupBox grpDCO1Harmonics;
        private System.Windows.Forms.CheckBox chkDCO1Harmonic2;
        private System.Windows.Forms.CheckBox chkDCO1Harmonic4;
        private System.Windows.Forms.CheckBox chkDCO1Harmonic8;
        private System.Windows.Forms.CheckBox chkDCO1Harmonic16;
        private System.Windows.Forms.GroupBox grpDCO1Waveform;
        private System.Windows.Forms.RadioButton rdoDCO1Sawtooth;
        private System.Windows.Forms.RadioButton rdoDCO1Squarewave;
        private System.Windows.Forms.GroupBox grpDCO1Octave;
        private System.Windows.Forms.RadioButton rdoDCO1High;
        private System.Windows.Forms.RadioButton rdoDCO1Mid;
        private System.Windows.Forms.RadioButton rdoDCO1Low;
        private System.Windows.Forms.GroupBox grpDCO1Interval;
        private System.Windows.Forms.TextBox txtDCO1Interval;
        private System.Windows.Forms.TrackBar trkDCO1Interval;
        private System.Windows.Forms.GroupBox grpDCO1Detune;
        private System.Windows.Forms.TextBox txtDCO1Detune;
        private System.Windows.Forms.TrackBar trkDCO1Detune;
        private System.Windows.Forms.TextBox txtDCO1ModeWarning;
        private System.Windows.Forms.GroupBox grpPolarity;
        private System.Windows.Forms.RadioButton rdoPolarityUp;
        private System.Windows.Forms.RadioButton rdoPolarityDown;
        private System.Windows.Forms.GroupBox grpKBDTrack;
        private System.Windows.Forms.RadioButton rdoKBDTrackFull;
        private System.Windows.Forms.RadioButton rdoKBDTrackHalf;
        private System.Windows.Forms.RadioButton rdoKBDTrackOff;
        private System.Windows.Forms.GroupBox grpVCFAttack;
        private System.Windows.Forms.TextBox txtVCFAttack;
        private System.Windows.Forms.TrackBar trkVCFAttack;
        private System.Windows.Forms.GroupBox grpTrigger;
        private System.Windows.Forms.RadioButton rdoTriggerSingle;
        private System.Windows.Forms.RadioButton rdoTriggerMulti;
        private System.Windows.Forms.GroupBox grpVCFRelease;
        private System.Windows.Forms.TextBox txtVCFRelease;
        private System.Windows.Forms.TrackBar trkVCFRelease;
        private System.Windows.Forms.GroupBox grpVCFSustain;
        private System.Windows.Forms.TextBox txtVCFSustain;
        private System.Windows.Forms.TrackBar trkVCFSustain;
        private System.Windows.Forms.GroupBox grpVCFSlope;
        private System.Windows.Forms.TextBox txtVCFSlope;
        private System.Windows.Forms.TrackBar trkVCFSlope;
        private System.Windows.Forms.GroupBox grpVCFDecay;
        private System.Windows.Forms.TextBox txtVCFDecay;
        private System.Windows.Forms.TrackBar trkVCFDecay;
        private System.Windows.Forms.GroupBox grpVCFBreak;
        private System.Windows.Forms.TextBox txtVCFBreak;
        private System.Windows.Forms.TrackBar trkVCFBreak;
        private System.Windows.Forms.GroupBox grpVCFEGIntensity;
        private System.Windows.Forms.TextBox txtVCFEGIntensity;
        private System.Windows.Forms.TrackBar trkVCFEGIntensity;
        private System.Windows.Forms.GroupBox grpVCFResonance;
        private System.Windows.Forms.TextBox txtVCFResonance;
        private System.Windows.Forms.TrackBar trkVCFResonance;
        private System.Windows.Forms.GroupBox grpVCFCutoff;
        private System.Windows.Forms.TextBox txtVCFCutoff;
        private System.Windows.Forms.TrackBar trkVCFCutoff;
        private System.Windows.Forms.GroupBox grpMG;
        private System.Windows.Forms.GroupBox grpMGDelay;
        private System.Windows.Forms.TextBox txtMGDelay;
        private System.Windows.Forms.TrackBar trkMGDelay;
        private System.Windows.Forms.GroupBox grpMGFrequency;
        private System.Windows.Forms.TextBox txtMGFrequency;
        private System.Windows.Forms.TrackBar trkMGFrequency;
        private System.Windows.Forms.GroupBox grpMGVCF;
        private System.Windows.Forms.TextBox txtMGVCF;
        private System.Windows.Forms.TrackBar trkMGVCF;
        private System.Windows.Forms.GroupBox grpMGDCO;
        private System.Windows.Forms.TextBox txtMGDCO;
        private System.Windows.Forms.TrackBar trkMGDCO;
        private System.Windows.Forms.GroupBox grpChorus;
        private System.Windows.Forms.RadioButton rdoChorusOn;
        private System.Windows.Forms.RadioButton rdoChorusOff;
        private System.Windows.Forms.TextBox txtDCO2ModeWarning;
        private System.Windows.Forms.GroupBox grpDCO2Release;
        private System.Windows.Forms.TextBox txtDCO2Release;
        private System.Windows.Forms.TrackBar trkDCO2Release;
        private System.Windows.Forms.GroupBox grpDCO2Sustain;
        private System.Windows.Forms.TextBox txtDCO2Sustain;
        private System.Windows.Forms.TrackBar trkDCO2Sustain;
        private System.Windows.Forms.GroupBox grpDCO2Slope;
        private System.Windows.Forms.TextBox txtDCO2Slope;
        private System.Windows.Forms.TrackBar trkDCO2Slope;
        private System.Windows.Forms.GroupBox grpDCO2Mode;
        private System.Windows.Forms.GroupBox grpDCO2Interval;
        private System.Windows.Forms.TextBox txtDCO2Interval;
        private System.Windows.Forms.TrackBar trkDCO2Interval;
        private System.Windows.Forms.GroupBox grpDCO2Detune;
        private System.Windows.Forms.TextBox txtDCO2Detune;
        private System.Windows.Forms.TrackBar trkDCO2Detune;
        private System.Windows.Forms.RadioButton rdoDCO2Whole;
        private System.Windows.Forms.RadioButton rdoDCO2Double;
        private System.Windows.Forms.GroupBox grpDCO2Decay;
        private System.Windows.Forms.TextBox txtDCO2Decay;
        private System.Windows.Forms.TrackBar trkDCO2Decay;
        private System.Windows.Forms.GroupBox grpDCO2Break;
        private System.Windows.Forms.TextBox txtDCO2Break;
        private System.Windows.Forms.TrackBar trkDCO2Break;
        private System.Windows.Forms.GroupBox grpDCO2Attack;
        private System.Windows.Forms.TextBox txtDCO2Attack;
        private System.Windows.Forms.TrackBar trkDCO2Attack;
        private System.Windows.Forms.GroupBox grpDCO2Level;
        private System.Windows.Forms.TextBox txtDCO2Level;
        private System.Windows.Forms.TrackBar trkDCO2Level;
        private System.Windows.Forms.GroupBox grpDCO2Harmonics;
        private System.Windows.Forms.CheckBox chkDCO2Harmonic2;
        private System.Windows.Forms.CheckBox chkDCO2Harmonic4;
        private System.Windows.Forms.CheckBox chkDCO2Harmonic8;
        private System.Windows.Forms.CheckBox chkDCO2Harmonic16;
        private System.Windows.Forms.GroupBox grpDCO2Waveform;
        private System.Windows.Forms.RadioButton rdoDCO2Sawtooth;
        private System.Windows.Forms.RadioButton rdoDCO2Squarewave;
        private System.Windows.Forms.GroupBox grpDCO2Octave;
        private System.Windows.Forms.RadioButton rdoDCO2High;
        private System.Windows.Forms.RadioButton rdoDCO2Mid;
        private System.Windows.Forms.RadioButton rdoDCO2Low;
        private System.Windows.Forms.GroupBox grpNoise;
        private System.Windows.Forms.TextBox txtNoise;
        private System.Windows.Forms.TrackBar trkNoise;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox grpDCO1EnvelopeMap;
        private System.Windows.Forms.GroupBox grpDCO2EnvelopeMap;
    }
}

