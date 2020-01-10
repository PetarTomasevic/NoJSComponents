using System;
using System.Timers;

namespace NoJS.Toast.Services
{
    public class NoJSToastService : INoJSToastService, IDisposable
    {
        public event Action<string, NoJSToastLevel> OnShow;

        public event Action OnHide;

        private Timer Countdown;

        public void ShowToast(string message, NoJSToastLevel level, double interval)
        {
            OnShow?.Invoke(message, level);
            StartCountdown(interval);
        }

        public void StartCountdown(double interval)
        {
            SetCountdown(interval);

            if (Countdown.Enabled)
            {
                Countdown.Stop();
                Countdown.Start();
            }
            else
            {
                Countdown.Start();
            }
        }

        public void SetCountdown(double interval)
        {
            if (Countdown == null)
            {
                Countdown = new Timer(interval);
                Countdown.Elapsed += HideToast;
                Countdown.AutoReset = false;
            }
        }

        public void HideToast(object source, ElapsedEventArgs args)
        {
            OnHide?.Invoke();
        }

        public void Dispose()
        {
            Countdown?.Dispose();
        }
    }
}