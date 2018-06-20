using System;
using System.Collections.Generic;

namespace KorgEX800Editor
{
    internal class Voice
    {
        public DCO DCO1 = new DCO();
        public DCO DCO2 = new DCO();

        public Parameter DCOMode = new Parameter(
            Convert.ToByte(enuDcoMode.Whole),
            Convert.ToByte(enuDcoMode.Double),
            Convert.ToByte(enuDcoMode.Double));
        public Parameter DCOInterval = new Parameter(0, 12);
        public Parameter DCODetune = new Parameter(0, 3);

        public VCF VCF = new VCF();
        public MG MG = new MG();

        public Parameter Noise = new Parameter(0, 15);
        public Parameter Chorus = new Parameter(0, 1);

        public void Randomize()
        {
            this.DCO1.Randomize();
            this.DCO2.Randomize();
            this.DCOMode.Randomize();
            this.DCOInterval.Randomize();
            this.DCODetune.Randomize();
            this.VCF.Randomize();
            this.MG.Randomize();
            this.Noise.Randomize();
            this.Chorus.Randomize();
        }

        public void Reset()
        {
            this.DCO1.Reset();
            this.DCO2.Reset();
            this.DCOMode.Reset();
            this.DCOInterval.Reset();
            this.DCODetune.Reset();
            this.VCF.Reset();
            this.MG.Reset();
            this.Noise.Reset();
            this.Chorus.Reset();
        }

        public bool HasChanges
        {
            get
            {
                return (
                    this.DCO1.HasChanges ||
                    this.DCO2.HasChanges ||
                    this.DCOMode.HasChanges ||
                    this.DCOInterval.HasChanges ||
                    this.DCODetune.HasChanges ||
                    this.VCF.HasChanges ||
                    this.MG.HasChanges ||
                    this.Noise.HasChanges ||
                    this.Chorus.HasChanges
                    );
            }
            set
            {
                this.DCO1.HasChanges =
                this.DCO2.HasChanges =
                this.DCOMode.HasChanges =
                this.DCOInterval.HasChanges =
                this.DCODetune.HasChanges =
                this.VCF.HasChanges =
                this.MG.HasChanges =
                this.Noise.HasChanges =
                this.Chorus.HasChanges = value;
            }
        }

        public int Length
        {
            // We only have get; we're read-only for length.
            get { return 21; }
        }

        public byte[] SysexData
        {
            // Get sysex data from voice.
            get
            {
                byte[] data =
                {
                    // byte 01
                        Convert.ToByte((this.DCO2.Waveform.Value << 6) | (this.DCO1.Waveform.Value << 4) | (this.DCO2.Octave.Value << 2) | this.DCO1.Octave.Value),
                    // byte 02
                        Convert.ToByte((this.DCO2.Harmonics.Value << 4) | this.DCO1.Harmonics.Value),
                    // byte 03 - NOTE: for some @#$% reason the chorus value is reversed in the sysex stream
                        Convert.ToByte((((this.Chorus.Value==(byte)enuChorus.On) ? 0 : 1) << 7) | (this.DCOMode.Value << 6) | this.DCODetune.Value),
                    // byte 04
                        Convert.ToByte((this.Noise.Value << 4) | this.DCOInterval.Value),
                    // byte 05
                        Convert.ToByte(((this.DCO1.Level.Value >> 2) << 5 ) | (this.VCF.Polarity.Value << 4) | this.VCF.EGIntensity.Value),
                    // byte 06
                        Convert.ToByte((this.DCO2.Level.Value << 2) | (this.DCO1.Level.Value & 3)),
                    // byte 07
                        Convert.ToByte(this.VCF.Cutoff.Value | (this.VCF.Trigger.Value << 7)),
                    // byte 08
                        Convert.ToByte((this.MG.Delay.Value << 4) | this.MG.Frequency.Value),
                    // byte 09
                        Convert.ToByte((this.MG.VCF.Value << 4) | this.MG.DCO.Value),
                    // byte 10
                        Convert.ToByte(((this.DCO1.Envelope.Decay.Value & 7) << 5) | this.DCO1.Envelope.Attack.Value),
                    // byte 11
                        Convert.ToByte(((this.DCO1.Envelope.Slope.Value & 1) << 7) | (this.DCO1.Envelope.Break.Value << 2) | (this.DCO1.Envelope.Decay.Value >> 3)),
                    // byte 12
                        Convert.ToByte(((this.DCO1.Envelope.Sustain.Value & 15) << 4) | (this.DCO1.Envelope.Slope.Value >> 1)),
                    // byte 13
                        Convert.ToByte(((this.DCO2.Envelope.Attack.Value & 3) << 6) | (this.DCO1.Envelope.Release.Value << 1) | (this.DCO1.Envelope.Sustain.Value >> 4)),
                    // byte 14
                        Convert.ToByte((this.DCO2.Envelope.Decay.Value << 3) | (this.DCO2.Envelope.Attack.Value >> 2) ),
                    // byte 15
                        Convert.ToByte(((this.DCO2.Envelope.Slope.Value & 7) << 5) | this.DCO2.Envelope.Break.Value),
                    // byte 16
                        Convert.ToByte(((this.DCO2.Envelope.Release.Value & 1) << 7) | (this.DCO2.Envelope.Sustain.Value << 2) | (this.DCO2.Envelope.Slope.Value >> 3)),
                    // byte 17
                        Convert.ToByte(((this.VCF.Envelope.Attack.Value & 15) << 4) | (this.DCO2.Envelope.Release.Value >> 1)),
                    // byte 18
                        Convert.ToByte(((this.VCF.Envelope.Break.Value & 3) << 6) | (this.VCF.Envelope.Decay.Value << 1) | (this.VCF.Envelope.Attack.Value >> 4)),
                    // byte 19
                        Convert.ToByte((this.VCF.Envelope.Slope.Value << 3) | (this.VCF.Envelope.Break.Value >> 2)),
                    // byte 20
                        Convert.ToByte(((this.VCF.Envelope.Release.Value & 7) << 5) | this.VCF.Envelope.Sustain.Value),
                    // byte 21
                        Convert.ToByte((this.VCF.KeyboardTracking.Value << 6) | (this.VCF.Resonance.Value << 2) | (this.VCF.Envelope.Release.Value >> 3))
                };
                return data;
            }
            // Set sysex data in voice.
            set
            {
                // byte 01
                    this.DCO1.Octave.Value = Convert.ToByte((value[0] >> 0) & 3);
                    this.DCO2.Octave.Value = Convert.ToByte((value[0] >> 2) & 3);
                    this.DCO1.Waveform.Value = Convert.ToByte((value[0] >> 4) & 3);
                    this.DCO2.Waveform.Value = Convert.ToByte((value[0] >> 6) & 3);
                // byte 02
                    this.DCO1.Harmonics.Value = Convert.ToByte((value[1] >> 0) & 15);
                    this.DCO2.Harmonics.Value = Convert.ToByte((value[1] >> 4) & 15);
                // byte 03 - NOTE: for some @#$% reason the chorus value is reversed in the sysex stream
                    this.DCODetune.Value = Convert.ToByte((value[2] >> 0) & 3);
                    this.DCOMode.Value = Convert.ToByte((((value[2] >> 6) & 1) == 0) ? enuWaveform.Squarewave : enuWaveform.Sawtooth);
                    this.Chorus.Value = Convert.ToByte(((value[2] >> 7) == 0) ? enuChorus.On : enuChorus.Off);
                // byte 04
                    this.DCOInterval.Value = Convert.ToByte((value[3] >> 0) & 15);
                    this.Noise.Value = Convert.ToByte((value[3] >> 4) & 15);
                // byte 05
                    this.VCF.EGIntensity.Value = Convert.ToByte((value[4] >> 0) & 15);
                    this.VCF.Polarity.Value = Convert.ToByte((((value[4] >> 4) & 1) == 0) ? enuPolarity.Down : enuPolarity.Up);
                    this.DCO1.Level.Value = Convert.ToByte(((value[4] >> 5) & 7) << 2);
                // byte 06
                    this.DCO1.Level.Value |= Convert.ToByte(value[5] & 3);
                    this.DCO2.Level.Value = Convert.ToByte((value[5] >> 2) & 31);
                // byte 07
                    this.VCF.Cutoff.Value = Convert.ToByte(value[6] & 127);
                    this.VCF.Trigger.Value = Convert.ToByte((value[6] >> 7) & 1);
                // byte 08
                    this.MG.Frequency.Value = Convert.ToByte((value[7] >> 0) & 15);
                    this.MG.Delay.Value = Convert.ToByte((value[7] >> 4) & 15);
                // byte 09
                    this.MG.DCO.Value = Convert.ToByte((value[8] >> 0) & 15);
                    this.MG.VCF.Value = Convert.ToByte((value[8] >> 4) & 15);
                // byte 10
                    this.DCO1.Envelope.Attack.Value = Convert.ToByte((value[9] >> 0) & 31);
                    this.DCO1.Envelope.Decay.Value = Convert.ToByte((value[9] >> 5) & 7);
                // byte 11
                    this.DCO1.Envelope.Decay.Value |= Convert.ToByte((value[10] & 3) << 3);
                    this.DCO1.Envelope.Break.Value = Convert.ToByte((value[10] >> 2) & 31);
                    this.DCO1.Envelope.Slope.Value = Convert.ToByte((value[10] >> 7) & 1);
                // byte 12
                    this.DCO1.Envelope.Slope.Value |= Convert.ToByte((value[11] & 15) << 1);
                    this.DCO1.Envelope.Sustain.Value = Convert.ToByte((value[11] >> 4) & 15);
                // byte 13
                    this.DCO1.Envelope.Sustain.Value |= Convert.ToByte((value[12] & 1) << 4);
                    this.DCO1.Envelope.Release.Value = Convert.ToByte((value[12] >> 1) & 31);
                    this.DCO2.Envelope.Attack.Value = Convert.ToByte((value[12] >> 6) & 3);
                // byte 14
                    this.DCO2.Envelope.Attack.Value |= Convert.ToByte((value[13] & 7) << 2);
                    this.DCO2.Envelope.Decay.Value = Convert.ToByte((value[13] >> 3) & 31);
                // byte 15
                    this.DCO2.Envelope.Break.Value = Convert.ToByte(value[14] & 31);
                    this.DCO2.Envelope.Slope.Value = Convert.ToByte((value[14] >> 5) & 7);
                // byte 16
                    this.DCO2.Envelope.Slope.Value |= Convert.ToByte((value[15] & 3) << 3);
                    this.DCO2.Envelope.Sustain.Value = Convert.ToByte((value[15] >> 2) & 31);
                    this.DCO2.Envelope.Release.Value = Convert.ToByte((value[15] >> 7) & 1);
                // byte 17
                    this.DCO2.Envelope.Release.Value |= Convert.ToByte((value[16] & 15) << 1);
                    this.VCF.Envelope.Attack.Value = Convert.ToByte((value[16] >> 4) & 15);
                // byte 18
                    this.VCF.Envelope.Attack.Value |= Convert.ToByte((value[17] & 1) << 4);
                    this.VCF.Envelope.Decay.Value = Convert.ToByte((value[17] >> 1) & 31);
                    this.VCF.Envelope.Break.Value = Convert.ToByte((value[17] >> 6) & 3);
                // byte 19
                    this.VCF.Envelope.Break.Value |= Convert.ToByte((value[18] & 7) << 2);
                    this.VCF.Envelope.Slope.Value = Convert.ToByte((value[18] >> 3) & 31);
                // byte 20
                    this.VCF.Envelope.Sustain.Value = Convert.ToByte(value[19] & 31);
                    this.VCF.Envelope.Release.Value = Convert.ToByte((value[19] >> 5) & 7);
                // byte 21
                    this.VCF.Envelope.Release.Value |= Convert.ToByte((value[20] & 3) << 3);
                    this.VCF.Resonance.Value = Convert.ToByte((value[20] >> 2) & 15);
                    this.VCF.KeyboardTracking.Value = Convert.ToByte((value[20] >> 6) & 3);
            }

        }
    }

    internal class DCO
    {
        public Parameter Octave = new Parameter(
            Convert.ToByte(enuOctave.Low),
            Convert.ToByte(enuOctave.High),
            Convert.ToByte(enuOctave.Mid));
        public Parameter Waveform = new Parameter(
            Convert.ToByte(enuWaveform.Squarewave),
            Convert.ToByte(enuWaveform.Sawtooth));
        public Parameter Level = new Parameter(0, 31, 0);
        public Parameter Harmonics = new Parameter(
            Convert.ToByte(enuHarmonics.None),
            Convert.ToByte(enuHarmonics.All));
        public DEG Envelope = new DEG();

        public void Randomize()
        {
            this.Octave.Randomize();
            this.Waveform.Randomize();
            this.Level.Randomize();
            this.Harmonics.Randomize();
            this.Envelope.Randomize();
        }

        public void Reset()
        {
            this.Octave.Reset();
            this.Waveform.Reset();
            this.Level.Reset();
            this.Harmonics.Reset();
            this.Envelope.Reset();
        }

        public bool HasChanges
        {
            get
            {
                return (
                    this.Octave.HasChanges ||
                    this.Waveform.HasChanges ||
                    this.Level.HasChanges ||
                    this.Harmonics.HasChanges ||
                    this.Envelope.HasChanges
                    );
            }
            set
            {
                this.Octave.HasChanges =
                this.Waveform.HasChanges =
                this.Level.HasChanges =
                this.Harmonics.HasChanges =
                this.Envelope.HasChanges = value;
            }
        }
    }

    internal class VCF
    {
        public Parameter Cutoff = new Parameter(0, 99);
        public Parameter Resonance = new Parameter(0, 15);
        public Parameter KeyboardTracking = new Parameter(
            Convert.ToByte(enuKbdTrack.Off),
            Convert.ToByte(enuKbdTrack.Full));
        public Parameter Polarity = new Parameter(
            Convert.ToByte(enuPolarity.Down),
            Convert.ToByte(enuPolarity.Up));
        public Parameter EGIntensity = new Parameter(0, 15);
        public Parameter Trigger = new Parameter(
            Convert.ToByte(enuTrigger.Single),
            Convert.ToByte(enuTrigger.Multi));
        public DEG Envelope = new DEG();

        public void Randomize()
        {
            this.Cutoff.Randomize();
            this.Resonance.Randomize();
            this.KeyboardTracking.Randomize();
            this.Polarity.Randomize();
            this.EGIntensity.Randomize();
            this.Trigger.Randomize();
            this.Envelope.Randomize();
        }

        public void Reset()
        {
            this.Cutoff.Reset();
            this.Resonance.Reset();
            this.KeyboardTracking.Reset();
            this.Polarity.Reset();
            this.EGIntensity.Reset();
            this.Trigger.Reset();
            this.Envelope.Reset();
        }

        public bool HasChanges
        {
            get
            {
                return (
                    this.Cutoff.HasChanges ||
                    this.Resonance.HasChanges ||
                    this.KeyboardTracking.HasChanges ||
                    this.Polarity.HasChanges ||
                    this.EGIntensity.HasChanges ||
                    this.Trigger.HasChanges ||
                    this.Envelope.HasChanges
                    );
            }
            set
            {
                this.Cutoff.HasChanges =
                this.Resonance.HasChanges =
                this.KeyboardTracking.HasChanges =
                this.Polarity.HasChanges =
                this.EGIntensity.HasChanges =
                this.Trigger.HasChanges =
                this.Envelope.HasChanges = value;
            }
        }
    }

    internal class DEG
    {
        public Parameter Attack = new Parameter(0, 31);
        public Parameter Decay = new Parameter(0, 31);
        public Parameter Break = new Parameter(0, 31);
        public Parameter Sustain = new Parameter(0, 31);
        public Parameter Slope = new Parameter(0, 31);
        public Parameter Release = new Parameter(0, 31);

        public void Randomize()
        {
            this.Attack.Randomize();
            this.Decay.Randomize();
            this.Break.Randomize();
            this.Sustain.Randomize();
            this.Slope.Randomize();
            this.Release.Randomize();
        }

        public void Reset()
        {
            this.Attack.Reset();
            this.Decay.Reset();
            this.Break.Reset();
            this.Sustain.Reset();
            this.Slope.Reset();
            this.Release.Reset();
        }

        public bool HasChanges
        {
            get
            {
                return (
                    this.Attack.HasChanges ||
                    this.Decay.HasChanges ||
                    this.Break.HasChanges ||
                    this.Sustain.HasChanges ||
                    this.Slope.HasChanges ||
                    this.Release.HasChanges
                    );
            }
            set
            {
                this.Attack.HasChanges =
                    this.Decay.HasChanges =
                    this.Break.HasChanges =
                    this.Sustain.HasChanges =
                    this.Slope.HasChanges =
                    this.Release.HasChanges = value;
            }
        }
    }

    internal class MG
    {
        public Parameter Frequency = new Parameter(0, 15);
        public Parameter Delay = new Parameter(0, 15);
        public Parameter DCO = new Parameter(0, 15);
        public Parameter VCF = new Parameter(0, 15);

        public void Randomize()
        {
            this.Frequency.Randomize();
            this.Delay.Randomize();
            this.DCO.Randomize();
            this.VCF.Randomize();
        }

        public void Reset()
        {
            this.Frequency.Reset();
            this.Delay.Reset();
            this.DCO.Reset();
            this.VCF.Reset();
        }

        public bool HasChanges
        {
            get
            {
                return (
                    this.Frequency.HasChanges ||
                    this.Delay.HasChanges ||
                    this.DCO.HasChanges ||
                    this.VCF.HasChanges
                    );
            }
            set
            {
                this.Frequency.HasChanges =
                    this.Delay.HasChanges =
                    this.DCO.HasChanges =
                    this.VCF.HasChanges = value;
            }
        }
    }

    internal class Parameter
    {
        private const byte defaultMinValue = 0;
        private const byte defaultMaxValue = 31;

        private byte bytMinLevel = defaultMinValue;
        private byte bytMaxLevel = defaultMaxValue;
        private byte bytCurrentValue = defaultMinValue;
        private byte bytDefaultValue = defaultMinValue;

        private bool blnHasChanges = false;

        private static Random rndValue = new Random(Convert.ToInt32(DateTime.Now.Ticks & 0xFFFF));

        #region Constructors

        // Default constructor with no parameters.
        public Parameter()
        {
            bytMinLevel = defaultMinValue;
            bytMaxLevel = defaultMaxValue;
            bytCurrentValue = defaultMinValue;
            bytDefaultValue = defaultMinValue;
        }

        // Constructor with a single parameter (MAX).
        public Parameter(byte MaxValue)
        {
            bytMinLevel = defaultMinValue;
            bytMaxLevel = MaxValue;
            bytCurrentValue = defaultMinValue;
            bytDefaultValue = defaultMinValue;
        }

        // Constructor with two parameters (MIN/MAX).
        public Parameter(byte MinValue, byte MaxValue)
        {
            bytMinLevel = MinValue;
            bytMaxLevel = MaxValue;
            bytCurrentValue = MinValue;
            bytDefaultValue = MinValue;
        }

        // Constructor with three parameters (MIN/MAX/DEFAULT).
        public Parameter(byte MinValue, byte MaxValue, byte DefaultValue)
        {
            bytMinLevel = MinValue;
            bytMaxLevel = MaxValue;
            bytCurrentValue = DefaultValue;
            bytDefaultValue = DefaultValue;
        }

        #endregion // Constructors

        public byte Value
        {
            get { return bytCurrentValue; }
            set
            {
                if ((value >= bytMinLevel) &&
                    (value <= bytMaxLevel) &&
                    (value != bytCurrentValue))
                {
                    bytCurrentValue = value;
                    blnHasChanges = true;
                }
            }
        }

        public bool HasChanges
        {
            get { return blnHasChanges; }
            set { blnHasChanges = value; }
        }

        public void Randomize()
        {
            this.Value = Convert.ToByte(
                rndValue.Next(Convert.ToInt32(bytMinLevel),
                Convert.ToInt32(bytMaxLevel) + 1));
            blnHasChanges = true;
        }

        public void Reset()
        {
            this.Value = bytDefaultValue;
            blnHasChanges = false;
        }
    }

    #region Internal Enumerations

    // -------------------------------------------------- //
    // NOTE: Values in the enumerations are based on
    // the sysex values, not the display values!!!
    // -------------------------------------------------- //

    internal enum enuWaveform
    {
        Squarewave = 0, // displays as 1
        Sawtooth = 1    // displays as 2
    }
    internal enum enuOctave
    {
        Low = 0,        // displays as 1
        Mid = 1,        // displays as 2
        High = 2        // displays as 3
    }
    internal enum enuDcoMode
    {
        Whole = 0,      // displays as 1
        Double = 1      // displays as 2
    }
    internal enum enuChorus
    {
        Off = 0,        // displays as 0, but is 1 in sysex (@#$%!!!)
        On = 1          // displays as 1, but is 0 in sysex (@#$%!!!)
    }
    internal enum enuPolarity
    {
        Down = 0,       // displays as 1
        Up = 1          // displays as 2
    }
    internal enum enuKbdTrack
    {
        Off = 0,        // displays as 0
        Half = 1,       // displays as 1
        Full = 2        // displays as 2
    }
    internal enum enuTrigger
    {
        Single = 0,     // displays as 1
        Multi = 1       // displays as 2
    }
    internal enum enuHarmonics
    {
        None = 0,
        Second = 8,
        Fourth = 4,
        Eighth = 2,
        Sixteenth = 1,
        All = 15
    }

    #endregion // Enumerations
}
