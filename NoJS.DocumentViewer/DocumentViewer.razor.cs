﻿using Microsoft.AspNetCore.Components;

namespace NoJS.DocumentViewer
{
    public class DocumentViewerBase : ComponentBase
    {
        [Parameter] public byte[] Document { get; set; }

        [Parameter] public string DocumentWidth { get; set; }
        [Parameter] public string DocumentHeight { get; set; }
        [Parameter] public string SaveBtnImage { get; set; }
        [Parameter] public string DocumentName { get; set; }

        [Parameter] public string DocumentType { get; set; }
    }
}