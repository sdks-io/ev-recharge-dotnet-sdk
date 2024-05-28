// <copyright file="ConnectorVOUpdatedByEnum.cs" company="APIMatic">
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
    /// ConnectorVOUpdatedByEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectorVOUpdatedByEnum
    {
        /// <summary>
        /// Feed.
        /// </summary>
        [EnumMember(Value = "Feed")]
        Feed,

        /// <summary>
        /// Admin.
        /// </summary>
        [EnumMember(Value = "Admin")]
        Admin,

        /// <summary>
        /// TariffService.
        /// </summary>
        [EnumMember(Value = "TariffService")]
        TariffService,

        /// <summary>
        /// Defaults.
        /// </summary>
        [EnumMember(Value = "Defaults")]
        Defaults
    }
}