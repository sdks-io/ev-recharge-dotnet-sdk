// <copyright file="GetChargeSessionRetrieveResponse200JsonStatusEnum.cs" company="APIMatic">
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
    /// GetChargeSessionRetrieveResponse200JsonStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetChargeSessionRetrieveResponse200JsonStatusEnum
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