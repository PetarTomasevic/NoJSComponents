﻿using Microsoft.AspNetCore.Components;
using System;

namespace NoJS.PDFViewer
{
    public class PDFViewerBase : ComponentBase, IDisposable
    {
        [Parameter] public byte[] Document { get; set; }

        [Parameter] public string DocumentWidth { get; set; }
        [Parameter] public string DocumentHeight { get; set; }
        [Parameter] public string SaveBtnImage { get; set; }
        [Parameter] public string DocumentName { get; set; }

        public void Dispose()
        {
        }
    }
}