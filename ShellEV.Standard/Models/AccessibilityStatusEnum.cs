// <copyright file="AccessibilityStatusEnum.cs" company="APIMatic">
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
    /// AccessibilityStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccessibilityStatusEnum
    {
        /// <summary>
        /// FreePublic.
        /// </summary>
        [EnumMember(Value = "FreePublic")]
        FreePublic,

        /// <summary>
        /// PayingPublic.
        /// </summary>
        [EnumMember(Value = "PayingPublic")]
        PayingPublic,

        /// <summary>
        /// Restricted.
        /// </summary>
        [EnumMember(Value = "Restricted")]
        Restricted,

        /// <summary>
        /// Unspecified.
        /// </summary>
        [EnumMember(Value = "Unspecified")]
        Unspecified
    }
}