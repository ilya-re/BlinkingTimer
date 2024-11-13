using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlinkingTimer {
	public partial class Form1 : Form
	{
		private const int IntervalPrecision = 10;
		private Color BlinkerColor = Color.Green;
		private string IntervalStr;
		public Form1() {
			InitializeComponent();
			UpdateIntervalLabel();
		}

		private void BtnStart_Click(object sender, EventArgs e) {
			IntervalTimer.Stop();
			Blink(); // first blink, to see that the timer has started running
			IntervalTimer.Start();
		}

		private void Blink() {
			Blinker.BackColor = BlinkerColor;
			BlinkLengthTimer.Start();
		}

		/// <summary>
		/// Sets the timer's interval from the "Timer" text box
		/// </summary>
		private void BtnSetTimer_Click(object sender, EventArgs e) {
			IntervalStr = TextBoxInterval.Text.Replace(TextBoxInterval.PromptChar, ' ');
			try {
				var days = Clamp(Convert.ToInt32(IntervalStr.Substring(0, 2)), max: 23);
				var hours = Clamp(Convert.ToInt32(IntervalStr.Substring(3, 2)), max: 23);
				var minutes = Clamp(Convert.ToInt32(IntervalStr.Substring(6, 2)), max: 59);
				var seconds = Clamp(Convert.ToInt32(IntervalStr.Substring(9, 2)), max: 59);
				var millis = Convert.ToInt32(IntervalStr.Substring(12, 2)) * IntervalPrecision;
				if (days == 0 && hours == 0 && minutes == 0 && seconds == 0) { millis = Clamp(millis, min: 1000 / IntervalPrecision); }
				var ts = new TimeSpan(days, hours, minutes, seconds, millis);
				IntervalTimer.Interval = Convert.ToInt32(ts.TotalMilliseconds);
				UpdateIntervalLabel();
			}
			catch (FormatException) {
				_ = MessageBox.Show(
					Properties.Resources.StringCannotConvertInterval,
					Properties.Resources.StringFormatError,
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
			}
		}

		/// <summary>
		/// Updates the "Current interval" label with the timer's interval value
		/// </summary>
		private void UpdateIntervalLabel() {
			LabelCurInterval.Text = $"{IntervalTimer.Interval / 1000f:f2} {Properties.Resources.StringSeconds}";
		}

		private void BtnStop_Click(object sender, EventArgs e) {
			IntervalTimer.Stop();
		}

		private int Clamp(int value, int max = int.MaxValue, int min = 0) {
			value = Math.Max(value, min);
			value = Math.Min(value, max);
			return value;
		}

		private void BlinkLengthTimer_Tick(object sender, EventArgs e) {
			Blinker.BackColor = Color.Black;
			BlinkLengthTimer.Stop();
		}

		private void IntervalTimer_Tick(object sender, EventArgs e) {
			Blink();
		}

		private void BtnBlinkerColor_Click(object sender, EventArgs e) {
			if (BlinkerColorDialog.ShowDialog() == DialogResult.OK) { BlinkerColor = BlinkerColorDialog.Color; }
		}
	}
}
