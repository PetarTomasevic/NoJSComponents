using System;
using System.Timers;

namespace NoJS.Toast.Services
{
    public interface INoJSToastService
    {
        event Action OnHide;

        event Action<string, NoJSToastLevel> OnShow;

        void ShowToast(string message, NoJSToastLevel level, double interval);

        void StartCountdown(double interval);

        void SetCountdown(double interval);

        void HideToast(object source, ElapsedEventArgs args);

        void Dispose();
    }
}