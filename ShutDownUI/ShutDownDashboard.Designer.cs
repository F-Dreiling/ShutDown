namespace ShutDownUI
{
    partial class ShutDownDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutDownDashboard));
            sdButtonStart = new Button();
            sdLabelTime = new Label();
            sdBoxInput = new TextBox();
            sdLabelInput = new Label();
            sdModeCheck = new CheckBox();
            sdGraphicBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)sdGraphicBox).BeginInit();
            SuspendLayout();
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
            // sdLabelTime
            // 
            sdLabelTime.AutoSize = true;
            sdLabelTime.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            sdLabelTime.ForeColor = SystemColors.ButtonHighlight;
            sdLabelTime.Location = new Point(90, 52);
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
            // sdModeCheck
            // 
            sdModeCheck.AutoSize = true;
            sdModeCheck.Checked = true;
            sdModeCheck.CheckState = CheckState.Checked;
            sdModeCheck.Location = new Point(64, 160);
            sdModeCheck.Name = "sdModeCheck";
            sdModeCheck.Size = new Size(109, 25);
            sdModeCheck.TabIndex = 5;
            sdModeCheck.Text = "sleep mode";
            sdModeCheck.UseVisualStyleBackColor = true;
            // 
            // sdGraphicBox
            // 
            sdGraphicBox.Image = Properties.Resources.circle;
            sdGraphicBox.Location = new Point(48, 20);
            sdGraphicBox.Name = "sdGraphicBox";
            sdGraphicBox.Size = new Size(128, 128);
            sdGraphicBox.TabIndex = 6;
            sdGraphicBox.TabStop = false;
            // 
            // ShutDownDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(224, 281);
            Controls.Add(sdModeCheck);
            Controls.Add(sdLabelInput);
            Controls.Add(sdBoxInput);
            Controls.Add(sdLabelTime);
            Controls.Add(sdButtonStart);
            Controls.Add(sdGraphicBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ShutDownDashboard";
            Text = "ShutDown";
            ((System.ComponentModel.ISupportInitialize)sdGraphicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button sdButtonStart;
        private Label sdLabelTime;
        private TextBox sdBoxInput;
        private Label sdLabelInput;
        private CheckBox sdModeCheck;
        private PictureBox sdGraphicBox;
    }
}