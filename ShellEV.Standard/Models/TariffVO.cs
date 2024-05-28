// <copyright file="TariffVO.cs" company="APIMatic">
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
    /// TariffVO.
    /// </summary>
    public class TariffVO
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TariffVO"/> class.
        /// </summary>
        public TariffVO()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TariffVO"/> class.
        /// </summary>
        /// <param name="startFee">startFee.</param>
        /// <param name="perMinute">perMinute.</param>
        /// <param name="perKWh">perKWh.</param>
        /// <param name="currency">currency.</param>
        /// <param name="updated">updated.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="structure">structure.</param>
        public TariffVO(
            double? startFee = null,
            double? perMinute = null,
            double? perKWh = null,
            string currency = null,
            string updated = null,
            Models.TariffVOUpdatedByEnum? updatedBy = null,
            string structure = null)
        {
            this.StartFee = startFee;
            this.PerMinute = perMinute;
            this.PerKWh = perKWh;
            this.Currency = currency;
            this.Updated = updated;
            this.UpdatedBy = updatedBy;
            this.Structure = structure;
        }

        /// <summary>
        /// Tariff to start a charging session
        /// </summary>
        [JsonProperty("startFee", NullValueHandling = NullValueHandling.Ignore)]
        public double? StartFee { get; set; }

        /// <summary>
        /// Tariff per minute of charging time
        /// </summary>
        [JsonProperty("perMinute", NullValueHandling = NullValueHandling.Ignore)]
        public double? PerMinute { get; set; }

        /// <summary>
        /// Tariff per kWh of energy consumed
        /// </summary>
        [JsonProperty("perKWh", NullValueHandling = NullValueHandling.Ignore)]
        public double? PerKWh { get; set; }

        /// <summary>
        /// ISO 4217 Curreny Code of the local currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// ISO8601-compliant UTC datetime of the last update of the Tariff
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// Source of the last update of the tariff details
        /// </summary>
        [JsonProperty("updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TariffVOUpdatedByEnum? UpdatedBy { get; set; }

        /// <summary>
        /// Tariff structure that this tariff belongs to, typically Default unless specific tariff is defined for provider
        /// </summary>
        [JsonProperty("structure", NullValueHandling = NullValueHandling.Ignore)]
        public string Structure { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TariffVO : ({string.Join(", ", toStringOutput)})";
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
            return obj is TariffVO other &&                ((this.StartFee == null && other.StartFee == null) || (this.StartFee?.Equals(other.StartFee) == true)) &&
                ((this.PerMinute == null && other.PerMinute == null) || (this.PerMinute?.Equals(other.PerMinute) == true)) &&
                ((this.PerKWh == null && other.PerKWh == null) || (this.PerKWh?.Equals(other.PerKWh) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.Updated == null && other.Updated == null) || (this.Updated?.Equals(other.Updated) == true)) &&
                ((this.UpdatedBy == null && other.UpdatedBy == null) || (this.UpdatedBy?.Equals(other.UpdatedBy) == true)) &&
                ((this.Structure == null && other.Structure == null) || (this.Structure?.Equals(other.Structure) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartFee = {(this.StartFee == null ? "null" : this.StartFee.ToString())}");
            toStringOutput.Add($"this.PerMinute = {(this.PerMinute == null ? "null" : this.PerMinute.ToString())}");
            toStringOutput.Add($"this.PerKWh = {(this.PerKWh == null ? "null" : this.PerKWh.ToString())}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.Updated = {(this.Updated == null ? "null" : this.Updated)}");
            toStringOutput.Add($"this.UpdatedBy = {(this.UpdatedBy == null ? "null" : this.UpdatedBy.ToString())}");
            toStringOutput.Add($"this.Structure = {(this.Structure == null ? "null" : this.Structure)}");
        }
    }
}