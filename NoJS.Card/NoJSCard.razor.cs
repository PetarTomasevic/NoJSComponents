using Microsoft.AspNetCore.Components;
using NoJS.Card.Services;
using System;

namespace NoJS.Card
{
    public class NoJSCardBase : ComponentBase, IDisposable
    {
        private const string DefaultStyle = "nojs-card";
        [Inject] protected INoJSCardService NoJSCardService { get; set; }
        [Parameter] public string Style { get; set; }
        [Parameter] public bool FooterIsVisible { get; set; }
        [Parameter] public bool HeaderIsVisible { get; set; }
        [Parameter] public MarkupString Title { get; set; }
        [Parameter] public MarkupString Footer { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        protected string ComponentStyle { get; set; }
        protected bool ComponentHeaderIsVisible { get; set; }
        protected bool ComponentFooterIsVisible { get; set; }

        private void SetCardOptions(NoJSCardOptions options)
        {
            ComponentStyle = string.IsNullOrWhiteSpace(options.Style) ? Style : options.Style;
            if (string.IsNullOrWhiteSpace(ComponentStyle))
                ComponentStyle = DefaultStyle;

            ComponentHeaderIsVisible = options.HeaderIsVisible ? HeaderIsVisible : options.HeaderIsVisible;
            ComponentFooterIsVisible = options.FooterIsVisible ? FooterIsVisible : options.FooterIsVisible;
        }

        public void Dispose()
        { }
    }
}