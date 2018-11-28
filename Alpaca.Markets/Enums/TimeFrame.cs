﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    /// <summary>
    /// Supported bar duration for Alpaca REST API.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TimeFrame
    {
        /// <summary>
        /// One minute bars.
        /// </summary>
        [EnumMember(Value = "1Min")]
        Minute,

        /// <summary>
        /// Five minutes bars.
        /// </summary>
        [EnumMember(Value = "5Min")]
        FiveMinute,

        /// <summary>
        /// Fifteen minutes bars.
        /// </summary>
        [EnumMember(Value = "15Min")]
        FiftyMinute,

        /// <summary>
        /// Daily bars.
        /// </summary>
        [EnumMember(Value = "1D")]
        Day,
    }
}