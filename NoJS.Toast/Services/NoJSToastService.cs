using System;
using System.Timers;

namespace NoJS.Toast.Services
{
    public class NoJSToastService : INoJSToastService,IDisposable
    {
        public event Action<string, NoJSToastLevel> OnShow;
        public event Action OnHide;
        private Timer Countdown;

        public void ShowToast(string message, NoJSToastLevel level)
        {
            OnShow?.Invoke(message, level);
            StartCountdown();
        }

        public void StartCountdown()
        {
            SetCountdown();

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

        public void SetCountdown()
        {
            if (Countdown == null)
            {
                Countdown = new Timer(5000);
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
