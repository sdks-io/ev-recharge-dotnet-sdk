// <copyright file="Environment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShellEV.Standard
{
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// Production Server.
        /// </summary>
        [EnumMember(Value = "production")]
        Production,

        /// <summary>
        /// Test Server.
        /// </summary>
        [EnumMember(Value = "environment2")]
        Environment2,
    }
}
