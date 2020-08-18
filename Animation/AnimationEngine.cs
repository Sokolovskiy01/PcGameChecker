using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker.Animation
{
	/*public static class AnimationEngine
	{
		public static List<Standartanimation> AnimationList = new List<Standartanimation>();
		public static List<ColorChangeAnimation> ColorChangeAnimationList = new List<ColorChangeAnimation>();
		public static List<ImageChangeAnimation> ImageChangeAnimationList = new List<ImageChangeAnimation>();

		private static Thread AnimatorThread;
		public static bool IsWorking;

		public static void Start()
		{
			IsWorking = true;
			AnimatorThread = new Thread(AnimationInvoker)
			{
				IsBackground = true,
				Name = "UI Animation"
			};

			AnimatorThread.Start();
		}

		private static void AnimationInvoker()
		{
			while (IsWorking)
			{
				ColorChangeAnimationList.RemoveAll(a => a == null || a.Status == ColorChangeAnimation.AnimationStatus.Completed);
				//LengthChangeAnimationList.RemoveAll(a => a == null || a.Status == LengthChangeAnimation.AnimationStatus.Completed);
				//ImageChangeAnimationList.RemoveAll(a => a == null || a.Status == ImageChangeAnimation.AnimationStatus.Completed);

				AnimationList.RemoveAll(a => a == null || a.Status == Standartanimation.AnimationStatus.Completed);

				Parallel.For(0, AnimationList.Count(), index =>
				{
					AnimationList[index].UpdateFrame();
				});

				Parallel.For(0, ColorChangeAnimationList.Count(), index =>
				{
					ColorChangeAnimationList[index].UpdateValue();
				});

				Thread.Sleep(Program.AnimationInterval);
			}
		}

		public static void Request(ColorChangeAnimation Anim, bool ReplaceIfExists = true)
		{
			Debug.WriteLine("Request animation: " + Anim.ID + " | StartColor" + Anim.StartColor.ToString()
				+ "\n | TargetColor: " + Anim.TargetColor.ToString() + " | Duration : " + Anim.Duration.ToString());
			Anim.Status = ColorChangeAnimation.AnimationStatus.Requested;

			ColorChangeAnimation dupAnim = GetDuplicate(Anim);

			if (dupAnim != null)
			{
				Debug.WriteLine("Found duplicate animation : " + Anim.ID);
				if (ReplaceIfExists)
				{
					Debug.WriteLine("Ended duplicate animation : " + dupAnim.ID);
					dupAnim.Status = ColorChangeAnimation.AnimationStatus.Completed;
				}
                else
                {
					return;
                }
			}

			ColorChangeAnimationList.Add(Anim);
		}

		private static ColorChangeAnimation GetDuplicate(ColorChangeAnimation Anim)
		{
			return ColorChangeAnimationList.Find(a => a.ID == Anim.ID);
		}

		public static void Request(Standartanimation Anim, bool ReplaceIfExists = true)
		{
			Debug.WriteLine("Запуск анимации: " + Anim.ID + "| TargetValue: " + Anim.TargetValue);
			Anim.Status = Standartanimation.AnimationStatus.Requested;

			Standartanimation dupAnim = GetDuplicate(Anim);

			if (dupAnim != null)
			{
				if (ReplaceIfExists == true)
				{
					dupAnim.Status = Standartanimation.AnimationStatus.Completed;
				}
				else
				{
					return;
				}
			}

			AnimationList.Add(Anim);
		}

		private static Standartanimation GetDuplicate(Standartanimation Anim)
		{
			return AnimationList.Find(a => a.ID == Anim.ID);
		}

		//public AnimationEngine() { }
	}*/
}