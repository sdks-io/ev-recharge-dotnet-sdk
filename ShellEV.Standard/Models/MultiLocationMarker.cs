// <copyright file="MultiLocationMarker.cs" company="APIMatic">
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
    /// MultiLocationMarker.
    /// </summary>
    public class MultiLocationMarker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiLocationMarker"/> class.
        /// </summary>
        public MultiLocationMarker()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiLocationMarker"/> class.
        /// </summary>
        /// <param name="markerType">markerType.</param>
        /// <param name="uniqueKey">uniqueKey.</param>
        /// <param name="coordinates">coordinates.</param>
        /// <param name="locationCount">locationCount.</param>
        /// <param name="evseCount">evseCount.</param>
        /// <param name="maxPower">maxPower.</param>
        /// <param name="geoHash">geoHash.</param>
        public MultiLocationMarker(
            string markerType,
            string uniqueKey = null,
            Models.Coordinates coordinates = null,
            double? locationCount = null,
            double? evseCount = null,
            double? maxPower = null,
            string geoHash = null)
        {
            this.MarkerType = markerType;
            this.UniqueKey = uniqueKey;
            this.Coordinates = coordinates;
            this.LocationCount = locationCount;
            this.EvseCount = evseCount;
            this.MaxPower = maxPower;
            this.GeoHash = geoHash;
        }

        /// <summary>
        /// Identifies the marker type. If it's a `MultiLocationMarker`, then the value is `MultiLocation`
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("markerType")]
        [JsonRequired]
        public string MarkerType { get; set; }

        /// <summary>
        /// Uniquely identifies the marker object
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("uniqueKey", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueKey { get; set; }

        /// <summary>
        /// Coordinates of the Shell Recharge Site Location
        /// </summary>
        [JsonProperty("coordinates", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Coordinates Coordinates { get; set; }

        /// <summary>
        /// Number of Locations that this Marker represents in the given set of bounds
        /// </summary>
        [JsonProperty("locationCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? LocationCount { get; set; }

        /// <summary>
        /// Total number of Evses in Locations that this Marker represents
        /// </summary>
        [JsonProperty("evseCount", NullValueHandling = NullValueHandling.Ignore)]
        public double? EvseCount { get; set; }

        /// <summary>
        /// Maximum power in kW across all locations grouped in this marker (disregarding availability)
        /// </summary>
        [JsonProperty("maxPower", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxPower { get; set; }

        /// <summary>
        /// GeoHash of marker coordinates
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("geoHash", NullValueHandling = NullValueHandling.Ignore)]
        public string GeoHash { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MultiLocationMarker : ({string.Join(", ", toStringOutput)})";
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
            return obj is MultiLocationMarker other &&                ((this.MarkerType == null && other.MarkerType == null) || (this.MarkerType?.Equals(other.MarkerType) == true)) &&
                ((this.UniqueKey == null && other.UniqueKey == null) || (this.UniqueKey?.Equals(other.UniqueKey) == true)) &&
                ((this.Coordinates == null && other.Coordinates == null) || (this.Coordinates?.Equals(other.Coordinates) == true)) &&
                ((this.LocationCount == null && other.LocationCount == null) || (this.LocationCount?.Equals(other.LocationCount) == true)) &&
                ((this.EvseCount == null && other.EvseCount == null) || (this.EvseCount?.Equals(other.EvseCount) == true)) &&
                ((this.MaxPower == null && other.MaxPower == null) || (this.MaxPower?.Equals(other.MaxPower) == true)) &&
                ((this.GeoHash == null && other.GeoHash == null) || (this.GeoHash?.Equals(other.GeoHash) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MarkerType = {(this.MarkerType == null ? "null" : this.MarkerType)}");
            toStringOutput.Add($"this.UniqueKey = {(this.UniqueKey == null ? "null" : this.UniqueKey)}");
            toStringOutput.Add($"this.Coordinates = {(this.Coordinates == null ? "null" : this.Coordinates.ToString())}");
            toStringOutput.Add($"this.LocationCount = {(this.LocationCount == null ? "null" : this.LocationCount.ToString())}");
            toStringOutput.Add($"this.EvseCount = {(this.EvseCount == null ? "null" : this.EvseCount.ToString())}");
            toStringOutput.Add($"this.MaxPower = {(this.MaxPower == null ? "null" : this.MaxPower.ToString())}");
            toStringOutput.Add($"this.GeoHash = {(this.GeoHash == null ? "null" : this.GeoHash)}");
        }
    }
}