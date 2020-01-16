﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace NoJS.Storage.JsonConverters
{
    /// <summary>
    /// The new Json.NET doesn't support Timespan at this time
    /// https://github.com/dotnet/corefx/issues/38641
    /// </summary>
    public class TimespanJsonConverter : JsonConverter<TimeSpan>
    {
        /// <summary>
        /// Format: Days.Hours:Minutes:Seconds:Milliseconds
        /// </summary>
        public const string TimeSpanFormatString = @"d\.hh\:mm\:ss\:FFF";

        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            if (string.IsNullOrWhiteSpace(s))
            {
                return TimeSpan.Zero;
            }
            else
            {
                TimeSpan parsedTimeSpan;
                if (!TimeSpan.TryParseExact(s, TimeSpanFormatString, null, out parsedTimeSpan))
                {
                    throw new FormatException($"Input timespan is not in an expected format : expected {Regex.Unescape(TimeSpanFormatString)}. Please retrieve this key as a string and parse manually.");
                }
                else
                {
                    return parsedTimeSpan;
                }
            }
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
        {
            var timespanFormatted = $"{value.ToString(TimeSpanFormatString)}";
            writer.WriteStringValue(timespanFormatted);
        }
    }
}