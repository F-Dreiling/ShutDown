using ShutDownUI.interfaces;
using System.Diagnostics;
using System.Timers;

namespace ShutDownUI
{
    public class ShutDownLogic: ILogic
    {
        private int time;
        private bool started = false;
        private int mode;
        private System.Timers.Timer timer;
        private IDashboard dashboard;

        public ShutDownLogic(IDashboard gui)
        {
            dashboard = gui;
        }

        public void HitTimer(string input, int mode) {

            time = Convert.ToInt32(input);
            this.mode = mode;

            if (started)
            {
                Stop();
            }
            else if (time > 0)
            {
                Start();
            }
        }

        private void TickTimer(object? sender, ElapsedEventArgs e)
        {
            time--;
            dashboard.UpdateTimer(time);

            if (time <= 0)
            {
                Stop();
                EnterState();
            }
        }

        private void EnterState()
        {
            if (mode == 2)
            {
                Process.Start("shutdown", "/s /t 0");
            }
            else if (mode == 1)
            {
                Application.SetSuspendState(PowerState.Hibernate, true, false);
            }
            else
            {
                Application.SetSuspendState(PowerState.Suspend, true, false);
            }
        }

        private void Start()
        {
            started = true;
            timer = new System.Timers.Timer(60000);
            timer.Elapsed += TickTimer;
            timer.Start();
        }

        private void Stop()
        {
            started = false;
            timer.Stop();
            timer.Dispose();
        }

        public bool isStarted()
        {
            return started;
        }

    }
}
