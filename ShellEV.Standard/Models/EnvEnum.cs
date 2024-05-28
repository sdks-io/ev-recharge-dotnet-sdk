// <copyright file="EnvEnum.cs" company="APIMatic">
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
    /// EnvEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnvEnum
    {
        /// <summary>
        /// EnumApitestshellcom.
        /// </summary>
        [EnumMember(Value = "api-test.shell.com")]
        EnumApitestshellcom,

        /// <summary>
        /// EnumApishellcom.
        /// </summary>
        [EnumMember(Value = "api.shell.com")]
        EnumApishellcom
    }
}