using ShutDownUI.interfaces;
using System.Diagnostics;
using System.Timers;

namespace ShutDownUI
{
    public class ShutDownLogic: ILogic
    {
        private int time;
        private bool sleep = true;
        private bool started = false;
        private System.Timers.Timer timer;
        private IDashboard dashboard;

        public ShutDownLogic(IDashboard gui)
        {
            dashboard = gui;
        }

        public void HitTimer(string input, bool sleepMode) {

            time = Convert.ToInt32(input);
            sleep = sleepMode;

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

            if (time <= 0)
            {
                Stop();

                if (sleep)
                {
                    Process.Start("shutdown", "/h /f");
                }
                else
                {
                    Process.Start("shutdown", "/s /t 0");
                }
            }

            dashboard.UpdateTimer(time);
        }

        private void Start()
        {
            started = true;
            timer = new System.Timers.Timer(1000);
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
