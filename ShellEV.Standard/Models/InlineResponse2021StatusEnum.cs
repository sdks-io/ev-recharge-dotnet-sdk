// <copyright file="InlineResponse2021StatusEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using ShellEV.Standard;
using ShellEV.Standard.Utilities;

namespace ShellEV.Standard.Models
{
    /// <summary>
    /// InlineResponse2021StatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InlineResponse2021StatusEnum
    {
        /// <summary>
        /// SUCCESS.
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        /// <summary>
        /// FAILED.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED
    }
}