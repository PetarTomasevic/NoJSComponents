using NoJS.Modal.Services;
using Microsoft.AspNetCore.Components;
using System;

namespace NoJS.Modal
{
    public class NoJSModalBase : ComponentBase, IDisposable
    {
        const string DefaultStyle = "nojs-modal";
        const string DefaultPosition = "nojs-modal-center";

        [Inject] protected INoJSModalService NoJSModalService { get; set; }

        [Parameter] public bool HideCloseButton { get; set; }
        [Parameter] public string Position { get; set; }
        [Parameter] public string Style { get; set; }

        protected bool ComponentHideCloseButton { get; set; }
        protected string ComponentPosition { get; set; }
        protected string ComponentStyle { get; set; }
        protected NoJSModalOptions Options { get; set; }
        protected bool IsVisible { get; set; }
        protected string Title { get; set; }
        protected RenderFragment Content { get; set; }
        protected NoJSModalParameters Parameters { get; set; }

        protected override void OnInitialized()
        {
            ((NoJSModalService)NoJSModalService).OnShow += ShowModal;
            NoJSModalService.OnClose += CloseModal;
        }

        public void ShowModal(string title, RenderFragment content, NoJSModalParameters parameters, NoJSModalOptions options)
        {
            Title = title;
            Content = content;
            Parameters = parameters;

            SetModalOptions(options);

            IsVisible = true;
            StateHasChanged();
        }

        internal void CloseModal(NoJSModalResult modalResult)
        {
            IsVisible = false;
            Title = "";
            Content = null;
            ComponentStyle = "";

            StateHasChanged();
        }

        public void Dispose()
        {
            ((NoJSModalService)NoJSModalService).OnShow -= ShowModal;
            NoJSModalService.OnClose -= CloseModal;
        }

        private void SetModalOptions(NoJSModalOptions options)
        {
            ComponentHideCloseButton = HideCloseButton;
            if (options.HideCloseButton.HasValue)
                ComponentHideCloseButton = options.HideCloseButton.Value;

            ComponentPosition = string.IsNullOrWhiteSpace(options.Position) ? Position : options.Position;
            if (string.IsNullOrWhiteSpace(ComponentPosition))
                ComponentPosition = DefaultPosition;

            ComponentStyle = string.IsNullOrWhiteSpace(options.Style) ? Style : options.Style;
            if (string.IsNullOrWhiteSpace(ComponentStyle))
                ComponentStyle = DefaultStyle;
        }
    }
}