// <copyright file="GetEVLocationsAuthorizationMethodsEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using ShellEV.Standard;
using ShellEV.Standard.Utilities;

namespace ShellEV.Standard.Models
{
    /// <summary>
    /// GetEVLocationsAuthorizationMethodsEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetEVLocationsAuthorizationMethodsEnum
    {
        /// <summary>
        /// NewMotionApp.
        /// </summary>
        [EnumMember(Value = "NewMotionApp")]
        NewMotionApp,

        /// <summary>
        /// RFIDToken.
        /// </summary>
        [EnumMember(Value = "RFIDToken")]
        RFIDToken,

        /// <summary>
        /// PnC.
        /// </summary>
        [EnumMember(Value = "PnC")]
        PnC
    }
}