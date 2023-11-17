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
            sdGraphicBox = new PictureBox();
            sdGroupMode = new GroupBox();
            sdRadio3 = new RadioButton();
            sdRadio2 = new RadioButton();
            sdRadio1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)sdGraphicBox).BeginInit();
            sdGroupMode.SuspendLayout();
            SuspendLayout();
            // 
            // sdButtonStart
            // 
            sdButtonStart.BackColor = SystemColors.ButtonHighlight;
            sdButtonStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sdButtonStart.ForeColor = SystemColors.ActiveCaptionText;
            sdButtonStart.Location = new Point(20, 243);
            sdButtonStart.Margin = new Padding(4);
            sdButtonStart.Name = "sdButtonStart";
            sdButtonStart.Size = new Size(128, 32);
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
            sdLabelTime.Location = new Point(62, 44);
            sdLabelTime.Name = "sdLabelTime";
            sdLabelTime.Size = new Size(50, 59);
            sdLabelTime.TabIndex = 2;
            sdLabelTime.Text = "0";
            // 
            // sdBoxInput
            // 
            sdBoxInput.Location = new Point(24, 282);
            sdBoxInput.Name = "sdBoxInput";
            sdBoxInput.Size = new Size(60, 29);
            sdBoxInput.TabIndex = 3;
            sdBoxInput.Text = "0";
            // 
            // sdLabelInput
            // 
            sdLabelInput.AutoSize = true;
            sdLabelInput.Location = new Point(104, 285);
            sdLabelInput.Name = "sdLabelInput";
            sdLabelInput.Size = new Size(44, 21);
            sdLabelInput.TabIndex = 4;
            sdLabelInput.Text = "mins";
            // 
            // sdGraphicBox
            // 
            sdGraphicBox.Image = Properties.Resources.circle;
            sdGraphicBox.Location = new Point(20, 12);
            sdGraphicBox.Name = "sdGraphicBox";
            sdGraphicBox.Size = new Size(128, 128);
            sdGraphicBox.TabIndex = 6;
            sdGraphicBox.TabStop = false;
            // 
            // sdGroupMode
            // 
            sdGroupMode.Controls.Add(sdRadio3);
            sdGroupMode.Controls.Add(sdRadio2);
            sdGroupMode.Controls.Add(sdRadio1);
            sdGroupMode.Location = new Point(20, 146);
            sdGroupMode.Name = "sdGroupMode";
            sdGroupMode.Size = new Size(128, 90);
            sdGroupMode.TabIndex = 7;
            sdGroupMode.TabStop = false;
            sdGroupMode.Text = "Mode";
            // 
            // sdRadio3
            // 
            sdRadio3.AutoSize = true;
            sdRadio3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sdRadio3.Location = new Point(10, 62);
            sdRadio3.Name = "sdRadio3";
            sdRadio3.Size = new Size(95, 23);
            sdRadio3.TabIndex = 2;
            sdRadio3.Text = "Shut Down";
            sdRadio3.UseVisualStyleBackColor = true;
            // 
            // sdRadio2
            // 
            sdRadio2.AutoSize = true;
            sdRadio2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sdRadio2.Location = new Point(10, 42);
            sdRadio2.Name = "sdRadio2";
            sdRadio2.Size = new Size(87, 23);
            sdRadio2.TabIndex = 1;
            sdRadio2.Text = "Hibernate";
            sdRadio2.UseVisualStyleBackColor = true;
            // 
            // sdRadio1
            // 
            sdRadio1.AutoSize = true;
            sdRadio1.Checked = true;
            sdRadio1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sdRadio1.Location = new Point(10, 22);
            sdRadio1.Name = "sdRadio1";
            sdRadio1.Size = new Size(59, 23);
            sdRadio1.TabIndex = 0;
            sdRadio1.TabStop = true;
            sdRadio1.Text = "Sleep";
            sdRadio1.UseVisualStyleBackColor = true;
            // 
            // ShutDownDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(168, 321);
            Controls.Add(sdGroupMode);
            Controls.Add(sdLabelInput);
            Controls.Add(sdBoxInput);
            Controls.Add(sdLabelTime);
            Controls.Add(sdButtonStart);
            Controls.Add(sdGraphicBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ShutDownDashboard";
            ((System.ComponentModel.ISupportInitialize)sdGraphicBox).EndInit();
            sdGroupMode.ResumeLayout(false);
            sdGroupMode.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button sdButtonStart;
        private Label sdLabelTime;
        private TextBox sdBoxInput;
        private Label sdLabelInput;
        private PictureBox sdGraphicBox;
        private GroupBox sdGroupMode;
        private RadioButton sdRadio3;
        private RadioButton sdRadio2;
        private RadioButton sdRadio1;
    }
}