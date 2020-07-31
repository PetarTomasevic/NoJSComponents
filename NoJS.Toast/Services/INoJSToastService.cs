using System;
using System.Timers;

namespace NoJS.Toast.Services
{
    public interface INoJSToastService
    {
        event Action OnHide;

        event Action<string, NoJSToastLevel, string> OnShow;

        void ShowToast(string message, NoJSToastLevel level, double interval, string headerTitle);

        void StartCountdown(double interval);

        void SetCountdown(double interval);

        void HideToast(object source, ElapsedEventArgs args);

        void Dispose();
    }
}