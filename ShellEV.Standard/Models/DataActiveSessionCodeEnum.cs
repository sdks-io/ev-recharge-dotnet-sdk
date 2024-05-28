// <copyright file="DataActiveSessionCodeEnum.cs" company="APIMatic">
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
    /// DataActiveSessionCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataActiveSessionCodeEnum
    {
        /// <summary>
        /// InternalError.
        /// </summary>
        [EnumMember(Value = "InternalError")]
        InternalError,

        /// <summary>
        /// ServiceUnavailable.
        /// </summary>
        [EnumMember(Value = "ServiceUnavailable")]
        ServiceUnavailable,

        /// <summary>
        /// ChargeTokenNotSupported.
        /// </summary>
        [EnumMember(Value = "ChargeTokenNotSupported")]
        ChargeTokenNotSupported,

        /// <summary>
        /// SessionInvalid.
        /// </summary>
        [EnumMember(Value = "SessionInvalid")]
        SessionInvalid,

        /// <summary>
        /// EvNotConnectedToEvse.
        /// </summary>
        [EnumMember(Value = "EvNotConnectedToEvse")]
        EvNotConnectedToEvse,

        /// <summary>
        /// EvseInUse.
        /// </summary>
        [EnumMember(Value = "EvseInUse")]
        EvseInUse,

        /// <summary>
        /// EvseOutOfService.
        /// </summary>
        [EnumMember(Value = "EvseOutOfService")]
        EvseOutOfService,

        /// <summary>
        /// EvseNotFound.
        /// </summary>
        [EnumMember(Value = "EvseNotFound")]
        EvseNotFound,

        /// <summary>
        /// EvseNotSupported.
        /// </summary>
        [EnumMember(Value = "EvseNotSupported")]
        EvseNotSupported
    }
}