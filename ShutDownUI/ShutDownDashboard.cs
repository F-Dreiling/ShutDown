using ShutDownUI.interfaces;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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

        public void UpdateTimer(int time)
        {
            if (InvokeRequired)
            {
                if (logic.isStarted())
                {
                    BeginInvoke(new Action(() => sdLabelTime.Text = time.ToString()), null);
                }
                else if (time == 0)
                {
                    BeginInvoke(new Action(() => EnterState()), null);
                }

                BeginInvoke(new Action(() => sdLabelTime.Left = (this.Width - (sdLabelTime.Width + 8)) / 2), null);
            }
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        private void EnterState()
        {
            if (sdModeCheck.Checked)
            {
                SendMessage(Handle.ToInt32(), 0x112, 0xF170, 1);
            }
            else
            {
                Application.SetSuspendState(PowerState.Hibernate, true, true);
            }
        }

    }
}