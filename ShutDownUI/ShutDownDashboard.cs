using ShutDownUI.interfaces;

namespace ShutDownUI
{
    public partial class ShutDownDashboard : Form, IDashboard
    {
        private ILogic logic;

        public ShutDownDashboard()
        {
            InitializeComponent();
            logic = new ShutDownLogic(this);
        }

        public void UpdateTimer(int time)
        {
            if (InvokeRequired)
            {
                if (logic.isStarted())
                {
                    BeginInvoke(new Action(() => sdLabelTime.Text = time.ToString()), null);
                    BeginInvoke(new Action(() => sdBoxInput.Enabled = false), null);
                    BeginInvoke(new Action(() => sdModeCheck.Enabled = false), null);
                    BeginInvoke(new Action(() => sdButtonStart.Text = "Stop"), null);
                }
                else
                {
                    BeginInvoke(new Action(() => sdLabelTime.Text = sdBoxInput.Text), null);
                    BeginInvoke(new Action(() => sdBoxInput.Enabled = true), null);
                    BeginInvoke(new Action(() => sdModeCheck.Enabled = true), null);
                    BeginInvoke(new Action(() => sdButtonStart.Text = "Start"), null);
                }

                BeginInvoke(new Action(() => sdLabelTime.Left = (this.Width - (sdLabelTime.Width + 8)) / 2), null);
            }
        }

        private void sdButtonStart_Click(object sender, EventArgs e)
        {
            logic.HitTimer(sdBoxInput.Text, sdModeCheck.Checked);

            sdLabelTime.Text = sdBoxInput.Text;

            if (logic.isStarted())
            {
                sdBoxInput.Enabled = false;
                sdModeCheck.Enabled = false;
                sdButtonStart.Text = "Stop";
            }
            else
            {
                sdBoxInput.Enabled = true;
                sdModeCheck.Enabled = true;
                sdButtonStart.Text = "Start";
            }

            sdLabelTime.Left = (this.Width - (sdLabelTime.Width + 8)) / 2;
        }

    }
}