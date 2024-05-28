// <copyright file="ElectricalProperties.cs" company="APIMatic">
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
    /// ElectricalProperties.
    /// </summary>
    public class ElectricalProperties
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricalProperties"/> class.
        /// </summary>
        public ElectricalProperties()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricalProperties"/> class.
        /// </summary>
        /// <param name="powerType">powerType.</param>
        /// <param name="voltage">voltage.</param>
        /// <param name="amperage">amperage.</param>
        /// <param name="maxElectricPower">maxElectricPower.</param>
        public ElectricalProperties(
            Models.ElectricalPropertiesPowerTypeEnum? powerType = null,
            double? voltage = null,
            double? amperage = null,
            double? maxElectricPower = null)
        {
            this.PowerType = powerType;
            this.Voltage = voltage;
            this.Amperage = amperage;
            this.MaxElectricPower = maxElectricPower;
        }

        /// <summary>
        /// Power Type used in this connector.
        /// </summary>
        [JsonProperty("powerType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectricalPropertiesPowerTypeEnum? PowerType { get; set; }

        /// <summary>
        /// Voltage in Volts for this connector
        /// </summary>
        [JsonProperty("voltage", NullValueHandling = NullValueHandling.Ignore)]
        public double? Voltage { get; set; }

        /// <summary>
        /// Electric Current in Amperes for this connector
        /// </summary>
        [JsonProperty("amperage", NullValueHandling = NullValueHandling.Ignore)]
        public double? Amperage { get; set; }

        /// <summary>
        /// Power in Kilowatts for this connector
        /// </summary>
        [JsonProperty("maxElectricPower", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxElectricPower { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ElectricalProperties : ({string.Join(", ", toStringOutput)})";
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
            return obj is ElectricalProperties other &&                ((this.PowerType == null && other.PowerType == null) || (this.PowerType?.Equals(other.PowerType) == true)) &&
                ((this.Voltage == null && other.Voltage == null) || (this.Voltage?.Equals(other.Voltage) == true)) &&
                ((this.Amperage == null && other.Amperage == null) || (this.Amperage?.Equals(other.Amperage) == true)) &&
                ((this.MaxElectricPower == null && other.MaxElectricPower == null) || (this.MaxElectricPower?.Equals(other.MaxElectricPower) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PowerType = {(this.PowerType == null ? "null" : this.PowerType.ToString())}");
            toStringOutput.Add($"this.Voltage = {(this.Voltage == null ? "null" : this.Voltage.ToString())}");
            toStringOutput.Add($"this.Amperage = {(this.Amperage == null ? "null" : this.Amperage.ToString())}");
            toStringOutput.Add($"this.MaxElectricPower = {(this.MaxElectricPower == null ? "null" : this.MaxElectricPower.ToString())}");
        }
    }
}