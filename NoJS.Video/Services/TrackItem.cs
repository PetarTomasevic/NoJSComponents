﻿namespace NoJS.Video.Data
{
    public class TrackItem
    {
        public string Label { get; set; }
        public string Kind { get; set; }
        public string SrcLang { get; set; }
        public string Src { get; set; }
        public bool SetAsDefault { get; set; } = false;
    }
}