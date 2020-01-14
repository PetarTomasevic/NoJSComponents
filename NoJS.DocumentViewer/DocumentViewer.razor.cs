using Microsoft.AspNetCore.Components;
using NoJS.DocumentViewer.Services;
using System;

namespace NoJS.DocumentViewer
{
    public class DocumentViewerBase : ComponentBase, IDisposable
    {
        [Parameter] public byte[] Document { get; set; }

        [Parameter] public string DocumentWidth { get; set; }
        [Parameter] public string DocumentHeight { get; set; }
        [Parameter] public string SaveBtnImage { get; set; }
        [Parameter] public string DocumentName { get; set; }

        [Parameter] public string DocumentType { get; set; }

        public void Dispose()
        {
        }
    }
}