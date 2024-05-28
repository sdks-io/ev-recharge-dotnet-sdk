// <copyright file="OpeningHoursObjectWeekDayEnum.cs" company="APIMatic">
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
    /// OpeningHoursObjectWeekDayEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OpeningHoursObjectWeekDayEnum
    {
        /// <summary>
        /// Sun.
        /// </summary>
        [EnumMember(Value = "Sun")]
        Sun,

        /// <summary>
        /// Mon.
        /// </summary>
        [EnumMember(Value = "Mon")]
        Mon,

        /// <summary>
        /// Tue.
        /// </summary>
        [EnumMember(Value = "Tue")]
        Tue,

        /// <summary>
        /// Wed.
        /// </summary>
        [EnumMember(Value = "Wed")]
        Wed,

        /// <summary>
        /// Thu.
        /// </summary>
        [EnumMember(Value = "Thu")]
        Thu,

        /// <summary>
        /// Fri.
        /// </summary>
        [EnumMember(Value = "Fri")]
        Fri,

        /// <summary>
        /// Sat.
        /// </summary>
        [EnumMember(Value = "Sat")]
        Sat
    }
}