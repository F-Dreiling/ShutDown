using System.Diagnostics;

namespace ShutDownUI
{
    public partial class ShutDownUI : Form
    {
        private int time;
        private bool started = false;

        public ShutDownUI()
        {
            InitializeComponent();
        }

        private void sdButtonStart_Click(object sender, EventArgs e)
        {
            time = Convert.ToInt32(sdBoxInput.Text);

            if (started)
            {
                started = false;

                sdLabelTime.Text = sdBoxInput.Text;
                sdLabelTime.Left = (this.Width - (sdLabelTime.Width + 8)) / 2;

                sdBoxInput.Enabled = true;
                sdButtonStart.Text = "Start";

                sdTimer.Stop();
                time = 0;
            }
            else if (time > 0)
            {
                started = true;

                sdLabelTime.Text = sdBoxInput.Text;
                sdLabelTime.Left = (this.Width - (sdLabelTime.Width + 8)) / 2;

                sdBoxInput.Enabled = false;
                sdButtonStart.Text = "Stop";

                sdTimer.Start();
            }
        }

        private void sdTimer_Tick(object sender, EventArgs e)
        {
            time--;
            sdLabelTime.Text = time.ToString();
            sdLabelTime.Left = (this.Width - (sdLabelTime.Width + 8)) / 2;

            if (time <= 0)
            {
                started = false;

                sdBoxInput.Enabled = true;
                sdButtonStart.Text = "Start";

                sdTimer.Stop();

                Process.Start("shutdown", "/s /t 0");
            }
        }

    }
}