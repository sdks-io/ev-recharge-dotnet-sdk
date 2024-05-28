// <copyright file="GetNearbyLocationsConnectorTypesEnum.cs" company="APIMatic">
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
    /// GetNearbyLocationsConnectorTypesEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetNearbyLocationsConnectorTypesEnum
    {
        /// <summary>
        /// Avcon.
        /// </summary>
        [EnumMember(Value = "Avcon")]
        Avcon,

        /// <summary>
        /// Domestic.
        /// </summary>
        [EnumMember(Value = "Domestic")]
        Domestic,

        /// <summary>
        /// Industrial2PDc.
        /// </summary>
        [EnumMember(Value = "Industrial2PDc")]
        Industrial2PDc,

        /// <summary>
        /// IndustrialPneAc.
        /// </summary>
        [EnumMember(Value = "IndustrialPneAc")]
        IndustrialPneAc,

        /// <summary>
        /// Industrial3PEAc.
        /// </summary>
        [EnumMember(Value = "Industrial3PEAc")]
        Industrial3PEAc,

        /// <summary>
        /// Industrial3PENAc.
        /// </summary>
        [EnumMember(Value = "Industrial3PENAc")]
        Industrial3PENAc,

        /// <summary>
        /// Type1.
        /// </summary>
        [EnumMember(Value = "Type1")]
        Type1,

        /// <summary>
        /// Type1Combo.
        /// </summary>
        [EnumMember(Value = "Type1Combo")]
        Type1Combo,

        /// <summary>
        /// Type2.
        /// </summary>
        [EnumMember(Value = "Type2")]
        Type2,

        /// <summary>
        /// Type2Combo.
        /// </summary>
        [EnumMember(Value = "Type2Combo")]
        Type2Combo,

        /// <summary>
        /// Type3.
        /// </summary>
        [EnumMember(Value = "Type3")]
        Type3,

        /// <summary>
        /// LPI.
        /// </summary>
        [EnumMember(Value = "LPI")]
        LPI,

        /// <summary>
        /// Nema520.
        /// </summary>
        [EnumMember(Value = "Nema520")]
        Nema520,

        /// <summary>
        /// SAEJ1772.
        /// </summary>
        [EnumMember(Value = "SAEJ1772")]
        SAEJ1772,

        /// <summary>
        /// SPI.
        /// </summary>
        [EnumMember(Value = "SPI")]
        SPI,

        /// <summary>
        /// TepcoCHAdeMO.
        /// </summary>
        [EnumMember(Value = "TepcoCHAdeMO")]
        TepcoCHAdeMO,

        /// <summary>
        /// Tesla.
        /// </summary>
        [EnumMember(Value = "Tesla")]
        Tesla,

        /// <summary>
        /// Unspecified.
        /// </summary>
        [EnumMember(Value = "Unspecified")]
        Unspecified
    }
}