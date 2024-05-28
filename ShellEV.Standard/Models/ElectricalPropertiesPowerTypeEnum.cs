// <copyright file="ElectricalPropertiesPowerTypeEnum.cs" company="APIMatic">
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
    /// ElectricalPropertiesPowerTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElectricalPropertiesPowerTypeEnum
    {
        /// <summary>
        /// AC1Phase.
        /// </summary>
        [EnumMember(Value = "AC1Phase")]
        AC1Phase,

        /// <summary>
        /// AC3Phase.
        /// </summary>
        [EnumMember(Value = "AC3Phase")]
        AC3Phase,

        /// <summary>
        /// DC.
        /// </summary>
        [EnumMember(Value = "DC")]
        DC
    }
}