// <copyright file="DataActiveSessionStateEnum.cs" company="APIMatic">
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
    /// DataActiveSessionStateEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataActiveSessionStateEnum
    {
        /// <summary>
        /// Started.
        /// </summary>
        [EnumMember(Value = "started")]
        Started,

        /// <summary>
        /// Stopped.
        /// </summary>
        [EnumMember(Value = "stopped")]
        Stopped,

        /// <summary>
        /// Startrequested.
        /// </summary>
        [EnumMember(Value = "start-requested")]
        Startrequested,

        /// <summary>
        /// Stoprequested.
        /// </summary>
        [EnumMember(Value = "stop-requested")]
        Stoprequested,

        /// <summary>
        /// Failedtostart.
        /// </summary>
        [EnumMember(Value = "failed-to-start")]
        Failedtostart,

        /// <summary>
        /// Failedtostop.
        /// </summary>
        [EnumMember(Value = "failed-to-stop")]
        Failedtostop
    }
}