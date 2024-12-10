// <copyright file="LocationResponeObject.cs" company="APIMatic">
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
    /// LocationResponeObject.
    /// </summary>
    public class LocationResponeObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResponeObject"/> class.
        /// </summary>
        public LocationResponeObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResponeObject"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="coordinates">coordinates.</param>
        /// <param name="operatorName">operatorName.</param>
        /// <param name="address">address.</param>
        /// <param name="accessibility">accessibility.</param>
        /// <param name="evses">evses.</param>
        /// <param name="openingHours">openingHours.</param>
        /// <param name="updated">updated.</param>
        /// <param name="operatorComment">operatorComment.</param>
        /// <param name="locationType">locationType.</param>
        public LocationResponeObject(
            int? uid = null,
            string externalId = null,
            Models.Coordinates coordinates = null,
            string operatorName = null,
            Models.Address address = null,
            Models.Accessibility accessibility = null,
            List<Models.EvseVO> evses = null,
            List<Models.OpeningHoursObject> openingHours = null,
            string updated = null,
            string operatorComment = null,
            string locationType = null)
        {
            this.Uid = uid;
            this.ExternalId = externalId;
            this.Coordinates = coordinates;
            this.OperatorName = operatorName;
            this.Address = address;
            this.Accessibility = accessibility;
            this.Evses = evses;
            this.OpeningHours = openingHours;
            this.Updated = updated;
            this.OperatorComment = operatorComment;
            this.LocationType = locationType;
        }

        /// <summary>
        /// Unique Internal identifier used to refer to this Location by Shell Recharge
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Uid { get; set; }

        /// <summary>
        /// Identifier as given by the Shell Recharge Operator, unique for that Operator
        /// </summary>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Coordinates of the Shell Recharge Site Location
        /// </summary>
        [JsonProperty("coordinates", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Coordinates Coordinates { get; set; }

        /// <summary>
        /// Operator of this Shell Recharge Location
        /// </summary>
        [JsonProperty("operatorName", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorName { get; set; }

        /// <summary>
        /// Address of the Shell Recharge Location
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address Address { get; set; }

        /// <summary>
        /// Accessibility of the Location
        /// </summary>
        [JsonProperty("accessibility", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Accessibility Accessibility { get; set; }

        /// <summary>
        /// Gets or sets Evses.
        /// </summary>
        [JsonProperty("evses", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.EvseVO> Evses { get; set; }

        /// <summary>
        /// Optional Opening Hours of the Location. Please note that it is not available for all sites.
        /// </summary>
        [JsonProperty("openingHours", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OpeningHoursObject> OpeningHours { get; set; }

        /// <summary>
        /// ISO8601-compliant UTC datetime of the last update of the location
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// optional Operator-wide arbitrary text (eg promotional, warning)
        /// </summary>
        [JsonProperty("operatorComment", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorComment { get; set; }

        /// <summary>
        /// the type of the location. Could be "UNKNOWN".
        /// </summary>
        [JsonProperty("locationType", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"LocationResponeObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is LocationResponeObject other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.ExternalId == null && other.ExternalId == null ||
                 this.ExternalId?.Equals(other.ExternalId) == true) &&
                (this.Coordinates == null && other.Coordinates == null ||
                 this.Coordinates?.Equals(other.Coordinates) == true) &&
                (this.OperatorName == null && other.OperatorName == null ||
                 this.OperatorName?.Equals(other.OperatorName) == true) &&
                (this.Address == null && other.Address == null ||
                 this.Address?.Equals(other.Address) == true) &&
                (this.Accessibility == null && other.Accessibility == null ||
                 this.Accessibility?.Equals(other.Accessibility) == true) &&
                (this.Evses == null && other.Evses == null ||
                 this.Evses?.Equals(other.Evses) == true) &&
                (this.OpeningHours == null && other.OpeningHours == null ||
                 this.OpeningHours?.Equals(other.OpeningHours) == true) &&
                (this.Updated == null && other.Updated == null ||
                 this.Updated?.Equals(other.Updated) == true) &&
                (this.OperatorComment == null && other.OperatorComment == null ||
                 this.OperatorComment?.Equals(other.OperatorComment) == true) &&
                (this.LocationType == null && other.LocationType == null ||
                 this.LocationType?.Equals(other.LocationType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid.ToString())}");
            toStringOutput.Add($"this.ExternalId = {this.ExternalId ?? "null"}");
            toStringOutput.Add($"this.Coordinates = {(this.Coordinates == null ? "null" : this.Coordinates.ToString())}");
            toStringOutput.Add($"this.OperatorName = {this.OperatorName ?? "null"}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.Accessibility = {(this.Accessibility == null ? "null" : this.Accessibility.ToString())}");
            toStringOutput.Add($"this.Evses = {(this.Evses == null ? "null" : $"[{string.Join(", ", this.Evses)} ]")}");
            toStringOutput.Add($"this.OpeningHours = {(this.OpeningHours == null ? "null" : $"[{string.Join(", ", this.OpeningHours)} ]")}");
            toStringOutput.Add($"this.Updated = {this.Updated ?? "null"}");
            toStringOutput.Add($"this.OperatorComment = {this.OperatorComment ?? "null"}");
            toStringOutput.Add($"this.LocationType = {this.LocationType ?? "null"}");
        }
    }
}