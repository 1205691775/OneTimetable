﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Quicktype;
//
//    var oneTimetableData = OneTimetableData.FromJson(jsonString);

namespace Quicktype
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class OneTimetableData
    {
        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("Sunday")]
        public List<string> Sunday { get; set; }

        [JsonProperty("Monday")]
        public List<string> Monday { get; set; }

        [JsonProperty("Tuesday")]
        public List<string> Tuesday { get; set; }

        [JsonProperty("Wednesday")]
        public List<string> Wednesday { get; set; }

        [JsonProperty("Thursday")]
        public List<string> Thursday { get; set; }

        [JsonProperty("Friday")]
        public List<string> Friday { get; set; }

        [JsonProperty("Saturday")]
        public List<string> Saturday { get; set; }
    }

    public partial class Description
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
    }

    public partial class OneTimetableData
    {
        public static OneTimetableData FromJson(string json) => JsonConvert.DeserializeObject<OneTimetableData>(json, Quicktype.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this OneTimetableData self) => JsonConvert.SerializeObject(self, Quicktype.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
