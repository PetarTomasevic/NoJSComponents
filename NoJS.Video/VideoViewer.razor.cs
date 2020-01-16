using Microsoft.AspNetCore.Components;
using NoJS.Video.Data;
using System.Collections.Generic;

namespace NoJS.Video
{
    public class VideoViewerBase : ComponentBase
    {
        [Parameter] public string VideoSource { get; set; }
        [Parameter] public string VideoType { get; set; }
        [Parameter] public string VideoWidth { get; set; }
        [Parameter] public string NotSupportedText { get; set; } = "Sorry, your browser doesn't support embedded videos.";
        [Parameter] public string PosterImage { get; set; }
        [Parameter] public string VideoId { get; set; }
        [Parameter] public List<TrackItem> SubtitlesList { get; set; }

        protected override void OnInitialized()
        {
        }
    }
}