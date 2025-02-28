// <copyright file="SingleLocationMarker.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace ShellEV.Standard.Models
{
    /// <summary>
    /// SingleLocationMarker.
    /// </summary>
    public class SingleLocationMarker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLocationMarker"/> class.
        /// </summary>
        public SingleLocationMarker()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLocationMarker"/> class.
        /// </summary>
        /// <param name="markerType">markerType.</param>
        /// <param name="uniqueKey">uniqueKey.</param>
        /// <param name="status">status.</param>
        /// <param name="coordinates">coordinates.</param>
        /// <param name="evseCount">evseCount.</param>
        /// <param name="maxPower">maxPower.</param>
        /// <param name="geoHash">geoHash.</param>
        /// <param name="locationUid">locationUid.</param>
        /// <param name="authorizationMethods">authorizationMethods.</param>
        /// <param name="operatorId">operatorId.</param>
        public SingleLocationMarker(
            string markerType,
            string uniqueKey = null,
            Models.SingleLocationMarkerStatusEnum? status = null,
            Models.Coordinates coordinates = null,
            double? evseCount = null,
            double? maxPower = null,
            string geoHash = null,
            double? locationUid = null,
            List<Models.SingleLocationMarkerAuthorizationMethodsItemsEnum> authorizationMethods = null,
            string operatorId = null)
        {
            this.MarkerType = markerType;
            this.UniqueKey = uniqueKey;
            this.Status = status;
            this.Coordinates = coordinates;
            this.EvseCount = evseCount;
            this.MaxPower = maxPower;
            this.GeoHash = geoHash;
            this.LocationUid = locationUid;
            this.AuthorizationMethods = authorizationMethods;
            this.OperatorId = operatorId;
        }

        /// <summary>
        /// Identifies the marker type. If it’s a `SingleLocationMarker`, then the value is `SingleLocation`
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
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SingleLocationMarkerStatusEnum? Status { get; set; }

        /// <summary>
        /// Coordinates of the Shell Recharge Site Location
        /// </summary>
        [JsonProperty("coordinates", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Coordinates Coordinates { get; set; }

        /// <summary>
        /// Total number of Evse units in Locations that this Marker represents
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

        /// <summary>
        /// Unique ID of the Location this Marker represents
        /// </summary>
        [JsonProperty("locationUid", NullValueHandling = NullValueHandling.Ignore)]
        public double? LocationUid { get; set; }

        /// <summary>
        /// Methods that can be used to Authorize sessions on this EVSE
        /// </summary>
        [JsonProperty("authorizationMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SingleLocationMarkerAuthorizationMethodsItemsEnum> AuthorizationMethods { get; set; }

        /// <summary>
        /// Unique Id of the operator
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("operatorId", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SingleLocationMarker : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SingleLocationMarker other &&
                (this.MarkerType == null && other.MarkerType == null ||
                 this.MarkerType?.Equals(other.MarkerType) == true) &&
                (this.UniqueKey == null && other.UniqueKey == null ||
                 this.UniqueKey?.Equals(other.UniqueKey) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Coordinates == null && other.Coordinates == null ||
                 this.Coordinates?.Equals(other.Coordinates) == true) &&
                (this.EvseCount == null && other.EvseCount == null ||
                 this.EvseCount?.Equals(other.EvseCount) == true) &&
                (this.MaxPower == null && other.MaxPower == null ||
                 this.MaxPower?.Equals(other.MaxPower) == true) &&
                (this.GeoHash == null && other.GeoHash == null ||
                 this.GeoHash?.Equals(other.GeoHash) == true) &&
                (this.LocationUid == null && other.LocationUid == null ||
                 this.LocationUid?.Equals(other.LocationUid) == true) &&
                (this.AuthorizationMethods == null && other.AuthorizationMethods == null ||
                 this.AuthorizationMethods?.Equals(other.AuthorizationMethods) == true) &&
                (this.OperatorId == null && other.OperatorId == null ||
                 this.OperatorId?.Equals(other.OperatorId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MarkerType = {this.MarkerType ?? "null"}");
            toStringOutput.Add($"UniqueKey = {this.UniqueKey ?? "null"}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Coordinates = {(this.Coordinates == null ? "null" : this.Coordinates.ToString())}");
            toStringOutput.Add($"EvseCount = {(this.EvseCount == null ? "null" : this.EvseCount.ToString())}");
            toStringOutput.Add($"MaxPower = {(this.MaxPower == null ? "null" : this.MaxPower.ToString())}");
            toStringOutput.Add($"GeoHash = {this.GeoHash ?? "null"}");
            toStringOutput.Add($"LocationUid = {(this.LocationUid == null ? "null" : this.LocationUid.ToString())}");
            toStringOutput.Add($"AuthorizationMethods = {(this.AuthorizationMethods == null ? "null" : $"[{string.Join(", ", this.AuthorizationMethods)} ]")}");
            toStringOutput.Add($"OperatorId = {this.OperatorId ?? "null"}");
        }
    }
}