// <copyright file="EvseVOStatusEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellEV.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using ShellEV.Standard;
    using ShellEV.Standard.Utilities;

    /// <summary>
    /// EvseVOStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EvseVOStatusEnum
    {
        /// <summary>
        /// Available.
        /// </summary>
        [EnumMember(Value = "Available")]
        Available,

        /// <summary>
        /// Occupied.
        /// </summary>
        [EnumMember(Value = "Occupied")]
        Occupied,

        /// <summary>
        /// Unavailable.
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable,

        /// <summary>
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
}