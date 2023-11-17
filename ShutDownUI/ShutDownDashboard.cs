using ShutDownUI.interfaces;
using System.Diagnostics;

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

        private void sdButtonStart_Click(object sender, EventArgs e)
        {
            logic.HitTimer(sdBoxInput.Text);

            sdLabelTime.Text = sdBoxInput.Text;
            sdLabelTime.Left = (Width - (sdLabelTime.Width + 8)) / 2;

            if (logic.isStarted())
            {
                DisableUI();
            }
            else
            {
                EnableUI();
            }
        }

        public void UpdateTimer(int time)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => sdLabelTime.Text = time.ToString()), null);
                BeginInvoke(new Action(() => sdLabelTime.Left = (Width - (sdLabelTime.Width + 10)) / 2), null);

                if (time == 0)
                {
                    BeginInvoke(new Action(() => EnableUI()), null);
                    BeginInvoke(new Action(() => EnterState()), null);
                }
            }
        }

        private void EnterState()
        {
            if (sdRadio1.Checked)
            {
                Application.SetSuspendState(PowerState.Suspend, true, false);
            }
            else if (sdRadio2.Checked)
            {
                Application.SetSuspendState(PowerState.Hibernate, true, false);
            }
            else if (sdRadio3.Checked)
            {
                Process.Start("shutdown", "/s /t 0");
            }
        }

        private void EnableUI()
        {
            sdBoxInput.Enabled = true;
            sdGroupMode.Enabled = true;
            sdButtonStart.Text = "Start";
        }

        private void DisableUI()
        {
            sdBoxInput.Enabled = false;
            sdGroupMode.Enabled = false;
            sdButtonStart.Text = "Stop";
        }

    }
}