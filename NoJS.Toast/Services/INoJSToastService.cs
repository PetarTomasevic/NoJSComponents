using Microsoft.AspNetCore.Components;
using System;
using System.Timers;

namespace NoJS.Toast.Services
{
    public interface INoJSToastService
    {
        event Action OnHide;
        event Action<string, NoJSToastLevel> OnShow;
        void ShowToast(string message, NoJSToastLevel level);
        void StartCountdown();
        void SetCountdown();
        void HideToast(object source, ElapsedEventArgs args);
        void Dispose();
    }
}
