namespace BlinkingTimer
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.IntervalTimer = new System.Windows.Forms.Timer(this.components);
			this.BtnStart = new System.Windows.Forms.Button();
			this.BtnStop = new System.Windows.Forms.Button();
			this.Blinker = new System.Windows.Forms.Label();
			this.TextBoxInterval = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnSetTimer = new System.Windows.Forms.Button();
			this.BlinkLengthTimer = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.LabelCurInterval = new System.Windows.Forms.Label();
			this.BtnBlinkerColor = new System.Windows.Forms.Button();
			this.BlinkerColorDialog = new System.Windows.Forms.ColorDialog();
			this.SuspendLayout();
			// 
			// IntervalTimer
			// 
			this.IntervalTimer.Tick += new System.EventHandler(this.IntervalTimer_Tick);
			// 
			// BtnStart
			// 
			resources.ApplyResources(this.BtnStart, "BtnStart");
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.UseVisualStyleBackColor = true;
			this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// BtnStop
			// 
			resources.ApplyResources(this.BtnStop, "BtnStop");
			this.BtnStop.Name = "BtnStop";
			this.BtnStop.UseVisualStyleBackColor = true;
			this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
			// 
			// Blinker
			// 
			resources.ApplyResources(this.Blinker, "Blinker");
			this.Blinker.BackColor = System.Drawing.Color.Black;
			this.Blinker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Blinker.Name = "Blinker";
			// 
			// TextBoxInterval
			// 
			resources.ApplyResources(this.TextBoxInterval, "TextBoxInterval");
			this.TextBoxInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TextBoxInterval.Name = "TextBoxInterval";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// BtnSetTimer
			// 
			resources.ApplyResources(this.BtnSetTimer, "BtnSetTimer");
			this.BtnSetTimer.Name = "BtnSetTimer";
			this.BtnSetTimer.UseVisualStyleBackColor = true;
			this.BtnSetTimer.Click += new System.EventHandler(this.BtnSetTimer_Click);
			// 
			// BlinkLengthTimer
			// 
			this.BlinkLengthTimer.Interval = 50;
			this.BlinkLengthTimer.Tick += new System.EventHandler(this.BlinkLengthTimer_Tick);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// LabelCurInterval
			// 
			resources.ApplyResources(this.LabelCurInterval, "LabelCurInterval");
			this.LabelCurInterval.Name = "LabelCurInterval";
			// 
			// BtnBlinkerColor
			// 
			resources.ApplyResources(this.BtnBlinkerColor, "BtnBlinkerColor");
			this.BtnBlinkerColor.Name = "BtnBlinkerColor";
			this.BtnBlinkerColor.UseVisualStyleBackColor = true;
			this.BtnBlinkerColor.Click += new System.EventHandler(this.BtnBlinkerColor_Click);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.BtnBlinkerColor);
			this.Controls.Add(this.LabelCurInterval);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BtnSetTimer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TextBoxInterval);
			this.Controls.Add(this.Blinker);
			this.Controls.Add(this.BtnStop);
			this.Controls.Add(this.BtnStart);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer IntervalTimer;
		private System.Windows.Forms.Button BtnStart;
		private System.Windows.Forms.Button BtnStop;
		private System.Windows.Forms.Label Blinker;
		private System.Windows.Forms.MaskedTextBox TextBoxInterval;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnSetTimer;
		private System.Windows.Forms.Timer BlinkLengthTimer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LabelCurInterval;
		private System.Windows.Forms.Button BtnBlinkerColor;
		private System.Windows.Forms.ColorDialog BlinkerColorDialog;
	}
}

