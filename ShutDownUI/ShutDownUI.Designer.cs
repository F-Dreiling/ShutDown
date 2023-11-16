namespace ShutDownUI
{
    partial class ShutDownUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutDownUI));
            sdTimer = new System.Windows.Forms.Timer(components);
            sdButtonStart = new Button();
            sdGraphicCircle = new PictureBox();
            sdLabelTime = new Label();
            sdBoxInput = new TextBox();
            sdLabelInput = new Label();
            ((System.ComponentModel.ISupportInitialize)sdGraphicCircle).BeginInit();
            SuspendLayout();
            // 
            // sdTimer
            // 
            sdTimer.Interval = 60000;
            sdTimer.Tick += sdTimer_Tick;
            // 
            // sdButtonStart
            // 
            sdButtonStart.BackColor = SystemColors.ButtonHighlight;
            sdButtonStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sdButtonStart.ForeColor = SystemColors.ActiveCaptionText;
            sdButtonStart.Location = new Point(64, 192);
            sdButtonStart.Margin = new Padding(4);
            sdButtonStart.Name = "sdButtonStart";
            sdButtonStart.Size = new Size(96, 32);
            sdButtonStart.TabIndex = 0;
            sdButtonStart.Text = "Start";
            sdButtonStart.UseVisualStyleBackColor = false;
            sdButtonStart.Click += sdButtonStart_Click;
            // 
            // sdGraphicCircle
            // 
            sdGraphicCircle.Image = (Image)resources.GetObject("sdGraphicCircle.Image");
            sdGraphicCircle.Location = new Point(48, 40);
            sdGraphicCircle.Name = "sdGraphicCircle";
            sdGraphicCircle.Size = new Size(128, 128);
            sdGraphicCircle.TabIndex = 1;
            sdGraphicCircle.TabStop = false;
            // 
            // sdLabelTime
            // 
            sdLabelTime.AutoSize = true;
            sdLabelTime.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            sdLabelTime.ForeColor = SystemColors.ButtonHighlight;
            sdLabelTime.Location = new Point(90, 72);
            sdLabelTime.Name = "sdLabelTime";
            sdLabelTime.Size = new Size(50, 59);
            sdLabelTime.TabIndex = 2;
            sdLabelTime.Text = "0";
            // 
            // sdBoxInput
            // 
            sdBoxInput.Location = new Point(64, 231);
            sdBoxInput.Name = "sdBoxInput";
            sdBoxInput.Size = new Size(50, 29);
            sdBoxInput.TabIndex = 3;
            sdBoxInput.Text = "0";
            // 
            // sdLabelInput
            // 
            sdLabelInput.AutoSize = true;
            sdLabelInput.Location = new Point(124, 234);
            sdLabelInput.Name = "sdLabelInput";
            sdLabelInput.Size = new Size(37, 21);
            sdLabelInput.TabIndex = 4;
            sdLabelInput.Text = "min";
            // 
            // ShutDownUI
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(224, 281);
            Controls.Add(sdLabelInput);
            Controls.Add(sdBoxInput);
            Controls.Add(sdLabelTime);
            Controls.Add(sdGraphicCircle);
            Controls.Add(sdButtonStart);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ShutDownUI";
            Text = "ShutDown";
            ((System.ComponentModel.ISupportInitialize)sdGraphicCircle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer sdTimer;
        private Button sdButtonStart;
        private PictureBox sdGraphicCircle;
        private Label sdLabelTime;
        private TextBox sdBoxInput;
        private Label sdLabelInput;
    }
}