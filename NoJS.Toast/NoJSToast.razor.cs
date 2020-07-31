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

        public void ShowToast(string message, NoJSToastLevel level, string headerTitle)
        {
            BuildToastSettings(level, message, headerTitle);
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

        public void BuildToastSettings(NoJSToastLevel level, string message, string headerTitle)
        {
            switch (level)
            {
                case NoJSToastLevel.Info:
                    BackgroundCssClass = $"bg-info";
                    IconCssClass = "info";
                    Heading = headerTitle;// "Info";
                    break;

                case NoJSToastLevel.Success:
                    BackgroundCssClass = $"bg-success";
                    IconCssClass = "check";
                    Heading = headerTitle; //"Success";
                    break;

                case NoJSToastLevel.Warning:
                    BackgroundCssClass = $"bg-warning";
                    IconCssClass = "exclamation";
                    Heading = headerTitle;// "Warning";
                    break;

                case NoJSToastLevel.Error:
                    BackgroundCssClass = $"bg-danger";
                    IconCssClass = "times";
                    Heading = headerTitle; // "Error";
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