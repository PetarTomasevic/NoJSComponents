using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoJS.Video
{
    public class VideoViewerBase : ComponentBase
    {
        [Parameter] public string VideoSource { get; set; }
        [Parameter] public string VideoType { get; set; }
        [Parameter] public string VideoWidth { get; set; }
    }
}