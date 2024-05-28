// <copyright file="StopChargeSessionRequestBodyJson.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellEV.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using ShellEV.Standard;
    using ShellEV.Standard.Utilities;

    /// <summary>
    /// StopChargeSessionRequestBodyJson.
    /// </summary>
    public class StopChargeSessionRequestBodyJson
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StopChargeSessionRequestBodyJson"/> class.
        /// </summary>
        public StopChargeSessionRequestBodyJson()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopChargeSessionRequestBodyJson"/> class.
        /// </summary>
        /// <param name="sesssionId">SesssionId.</param>
        public StopChargeSessionRequestBodyJson(
            string sesssionId)
        {
            this.SesssionId = sesssionId;
        }

        /// <summary>
        /// Session Id is to be fetched
        /// </summary>
        [JsonProperty("SesssionId")]
        public string SesssionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StopChargeSessionRequestBodyJson : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is StopChargeSessionRequestBodyJson other &&                ((this.SesssionId == null && other.SesssionId == null) || (this.SesssionId?.Equals(other.SesssionId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SesssionId = {(this.SesssionId == null ? "null" : this.SesssionId)}");
        }
    }
}