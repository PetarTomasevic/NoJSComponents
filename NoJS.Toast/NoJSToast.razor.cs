using Microsoft.AspNetCore.Components;
using NoJS.Toast.Services;
using System;

namespace NoJS.Toast
{
    public class NoJSToastBase : ComponentBase, IDisposable
    {
        [Inject] protected INoJSToastService NoJSToastService { get; set; }

        protected string Heading { get; set; }
        protected string Message { get; set; }
        protected bool IsVisible { get; set; }
        protected string BackgroundCssClass { get; set; }
        protected string IconCssClass { get; set; }

        protected override void OnInitialized()
        {
            ((NoJSToastService)NoJSToastService).OnShow += ShowToast;
            NoJSToastService.OnHide += HideToast;
        }

        public void ShowToast(string message, NoJSToastLevel level)
        {
            BuildToastSettings(level, message);
            IsVisible = true;
            //StateHasChanged();
            InvokeAsync(() =>
            {
                StateHasChanged();
            });
        }

        public void HideToast()
        {
            IsVisible = false;
            //StateHasChanged();
            InvokeAsync(() =>
            {
                StateHasChanged();
            });
        }

        public void BuildToastSettings(NoJSToastLevel level, string message)
        {
            switch (level)
            {
                case NoJSToastLevel.Info:
                    BackgroundCssClass = $"bg-info";
                    IconCssClass = "info";
                    Heading = "Info";
                    break;

                case NoJSToastLevel.Success:
                    BackgroundCssClass = $"bg-success";
                    IconCssClass = "check";
                    Heading = "Success";
                    break;

                case NoJSToastLevel.Warning:
                    BackgroundCssClass = $"bg-warning";
                    IconCssClass = "exclamation";
                    Heading = "Warning";
                    break;

                case NoJSToastLevel.Error:
                    BackgroundCssClass = $"bg-danger";
                    IconCssClass = "times";
                    Heading = "Error";
                    break;
            }

            Message = message;
        }

        public void Dispose()
        {
            NoJSToastService.OnShow -= ShowToast;
        }
    }
}