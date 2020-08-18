using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker.Animation
{
	/*public class ColorChangeAnimation
	{
		public string ID { get; set; }
		private int _Duration;
		public int Duration
		{
			get
			{
				return this._Duration;
			}
			set
			{
				if (_Duration != value && value >= 100)
				{
					_Duration = value;
					Rstep = (float)((TargetColor.R - StartColor.R) * Program.AnimationInterval) / _Duration;
					Gstep = (float)((TargetColor.G - StartColor.G) * Program.AnimationInterval) / _Duration;
					Bstep = (float)((TargetColor.B - StartColor.B) * Program.AnimationInterval) / _Duration;
				}
			}
		}
		//private int Interval = 15; 15 ms ~= 66 fps
		public int ExecutionTime;
		
		public delegate void ControlMethod();
		private ControlMethod InvalidateControl;

		private Color _StartColor;
		public Color StartColor
        {
			get => _StartColor;
            set
            {
				if (_StartColor != value)
                {
					_StartColor = value;
					RValue = StartColor.R;
					GValue = StartColor.G;
					BValue = StartColor.B;
					Rstep = (float)((TargetColor.R - StartColor.R) * Program.AnimationInterval) / this.Duration;
					Gstep = (float)((TargetColor.G - StartColor.G) * Program.AnimationInterval) / this.Duration;
					Bstep = (float)((TargetColor.B - StartColor.B) * Program.AnimationInterval) / this.Duration;
				}
			}
        }
		public Color TargetColor;

		public Color Value;

		private static float RValue; // Red, Green and Blue value of current color
		private static float GValue;
		private static float BValue;

		private static float Rstep; // Step for every interval(frame) of animation
		private static float Gstep;
		private static float Bstep;

		public AnimationStatus Status { get; set; }
		public enum AnimationStatus
		{
			Requested,
			Active,
			Completed
		}

		public void UpdateValue()
		{
			if (Status == AnimationStatus.Completed) return;
			Status = AnimationStatus.Active;
			
			if (Math.Abs(RValue - TargetColor.R) < Math.Abs(Rstep))
			{
				Rstep = 0.0F;
				RValue = TargetColor.R;
			}
			if (Math.Abs(GValue - TargetColor.G) < Math.Abs(Gstep))
			{
				Gstep = 0.0F;
				GValue = TargetColor.G;
			}
			if (Math.Abs(BValue - TargetColor.B) < Math.Abs(Bstep))
			{
				Bstep = 0.0F;
				BValue = TargetColor.B;
			}

			if (Rstep == 0.0F && Gstep == 0.0F && Bstep == 0.0F)
			{
                Value = TargetColor;
				Status = AnimationStatus.Completed;
			}
			else
            {
				RValue += Rstep;
				GValue += Gstep;
				BValue += Bstep;

				Value = Color.FromArgb((int)RValue, (int)GValue, (int)BValue);

				ExecutionTime += Program.AnimationInterval;
			}

			InvalidateControl.Invoke();
		}

		public ColorChangeAnimation() { }
		public ColorChangeAnimation(string id, ControlMethod InvalidateControl, Color StartColor, Color TargetColor, int Duration)
		{
			ID = id;
			ExecutionTime = 0;
			this.InvalidateControl = InvalidateControl;
			this.StartColor = StartColor;
			Value = StartColor;
			this.TargetColor = TargetColor;

			RValue = StartColor.R;
			GValue = StartColor.G;
			BValue = StartColor.B;

			this.Duration = Duration;
		}
	}

    public class Standartanimation
    {
        public string ID { get; set; }

        public float Value;

        public float StartValue;

        private float targetValue;
        public float TargetValue
        {
            get => targetValue;
            set
            {
                targetValue = value;
                Reverse = value < Value ? true : false;
            }
        }

        public float Volume;

        public bool Reverse = false;

        public AnimationStatus Status { get; set; }
        public enum AnimationStatus
        {
            Requested,
            Active,
            Completed
        }

        private float p15, p30, p70, p85;

        public int StepDivider = 11;

        private float Step()
        {
            float basicStep = Math.Abs(Volume) / StepDivider; // Math.Abs - превращает числа 0< в >0
            float resultStep = 0;

            if (Reverse == false)
            {
                if (Value <= p15 || Value >= p85)
                {
                    resultStep = basicStep / 3.5f;
                }
                else if (Value <= p30 || Value >= p70)
                {
                    resultStep = basicStep / 2f;
                }
                else if (Value > p30 && Value < p70)
                {
                    resultStep = basicStep;
                }
            }
            else
            {
                if (Value >= p15 || Value <= p85)
                {
                    resultStep = basicStep / 3.5f;
                }
                else if (Value >= p30 || Value <= p70)
                {
                    resultStep = basicStep / 2f;
                }
                else if (Value < p30 && Value > p70)
                {
                    resultStep = basicStep;
                }
            }

            return Math.Abs(resultStep);
        }

        private float ValueByPercent(float Percent)
        {
            float COEFF = Percent / 100;
            float VolumeInPercent = Volume * COEFF;
            float ValueInPercent = StartValue + VolumeInPercent;

            return ValueInPercent;
        }

        public delegate void ControlMethod();
        private ControlMethod InvalidateControl;

        public void UpdateFrame()
        {
            Status = AnimationStatus.Active;

            if (Reverse == false)
            {
                if (Value <= targetValue)
                {
                    Value += Step();

                    if (Value >= targetValue)
                    {
                        Value = targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }
            else
            {
                if (Value >= targetValue)
                {
                    Value -= Step();

                    if (Value <= targetValue)
                    {
                        Value = targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }

            InvalidateControl.Invoke();
        }

        public Standartanimation() { }

        public Standartanimation(string ID, ControlMethod InvalidateControl, float Value, float TargetValue)
        {
            this.ID = ID;

            this.InvalidateControl = InvalidateControl;

            this.Value = Value;
            this.TargetValue = TargetValue;

            StartValue = Value;
            Volume = TargetValue - Value;

            p15 = ValueByPercent(15);
            p30 = ValueByPercent(30);
            p70 = ValueByPercent(70);
            p85 = ValueByPercent(85);
        }
    }

    public class ImageChangeAnimation
	{

	}*/
}