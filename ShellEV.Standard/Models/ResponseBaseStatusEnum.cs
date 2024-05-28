// <copyright file="ResponseBaseStatusEnum.cs" company="APIMatic">
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
    /// ResponseBaseStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResponseBaseStatusEnum
    {
        /// <summary>
        /// FAILED.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,

        /// <summary>
        /// PARTIALSUCCESS.
        /// </summary>
        [EnumMember(Value = "PARTIAL_SUCCESS")]
        PARTIALSUCCESS,

        /// <summary>
        /// SUCCESS.
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS
    }
}