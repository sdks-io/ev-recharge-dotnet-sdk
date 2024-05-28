// <copyright file="ChargesessionStartBody.cs" company="APIMatic">
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
    /// ChargesessionStartBody.
    /// </summary>
    public class ChargesessionStartBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargesessionStartBody"/> class.
        /// </summary>
        public ChargesessionStartBody()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargesessionStartBody"/> class.
        /// </summary>
        /// <param name="evChargeNumber">EvChargeNumber.</param>
        /// <param name="evseId">EvseId.</param>
        public ChargesessionStartBody(
            string evChargeNumber,
            string evseId)
        {
            this.EvChargeNumber = evChargeNumber;
            this.EvseId = evseId;
        }

        /// <summary>
        /// The EV Charge Number which can be found on the back of the Shell EV Card
        /// </summary>
        [JsonProperty("EvChargeNumber")]
        public string EvChargeNumber { get; set; }

        /// <summary>
        /// Standard EVSE (Electric Vehicle Supply Equipment) Id identifier (ISO-IEC-15118)
        /// </summary>
        [JsonProperty("EvseId")]
        public string EvseId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ChargesessionStartBody : ({string.Join(", ", toStringOutput)})";
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
            return obj is ChargesessionStartBody other &&                ((this.EvChargeNumber == null && other.EvChargeNumber == null) || (this.EvChargeNumber?.Equals(other.EvChargeNumber) == true)) &&
                ((this.EvseId == null && other.EvseId == null) || (this.EvseId?.Equals(other.EvseId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EvChargeNumber = {(this.EvChargeNumber == null ? "null" : this.EvChargeNumber)}");
            toStringOutput.Add($"this.EvseId = {(this.EvseId == null ? "null" : this.EvseId)}");
        }
    }
}