// <copyright file="ConnectorVO.cs" company="APIMatic">
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
    /// ConnectorVO.
    /// </summary>
    public class ConnectorVO
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorVO"/> class.
        /// </summary>
        public ConnectorVO()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorVO"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="connectorType">connectorType.</param>
        /// <param name="electricalProperties">electricalProperties.</param>
        /// <param name="fixedCable">fixedCable.</param>
        /// <param name="tariff">tariff.</param>
        /// <param name="updated">updated.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="deleted">deleted.</param>
        public ConnectorVO(
            int? uid = null,
            string externalId = null,
            Models.ConnectorVOConnectorTypeEnum? connectorType = null,
            Models.ElectricalProperties electricalProperties = null,
            bool? fixedCable = null,
            Models.Tariff tariff = null,
            string updated = null,
            Models.ConnectorVOUpdatedByEnum? updatedBy = null,
            string deleted = null)
        {
            this.Uid = uid;
            this.ExternalId = externalId;
            this.ConnectorType = connectorType;
            this.ElectricalProperties = electricalProperties;
            this.FixedCable = fixedCable;
            this.Tariff = tariff;
            this.Updated = updated;
            this.UpdatedBy = updatedBy;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Internal identifier used to refer to this Connector
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Uid { get; set; }

        /// <summary>
        /// Identifier of the Evse as given by the Operator, unique for the containing EVSE'
        /// </summary>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets ConnectorType.
        /// </summary>
        [JsonProperty("connectorType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ConnectorVOConnectorTypeEnum? ConnectorType { get; set; }

        /// <summary>
        /// Electrical Properties of the Connector
        /// </summary>
        [JsonProperty("electricalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ElectricalProperties ElectricalProperties { get; set; }

        /// <summary>
        /// Indicates whether Connector has a fixed cable attached. False by default (not sent in this case)
        /// </summary>
        [JsonProperty("fixedCable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FixedCable { get; set; }

        /// <summary>
        /// Gets or sets Tariff.
        /// </summary>
        [JsonProperty("tariff", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Tariff Tariff { get; set; }

        /// <summary>
        /// ISO8601-compliant UTC datetime of the last update of the Connector’s data
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// Gets or sets UpdatedBy.
        /// </summary>
        [JsonProperty("updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ConnectorVOUpdatedByEnum? UpdatedBy { get; set; }

        /// <summary>
        /// optional  ISO8601-compliant UTC deletion timestamp of the connector
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public string Deleted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ConnectorVO : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ConnectorVO other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.ExternalId == null && other.ExternalId == null ||
                 this.ExternalId?.Equals(other.ExternalId) == true) &&
                (this.ConnectorType == null && other.ConnectorType == null ||
                 this.ConnectorType?.Equals(other.ConnectorType) == true) &&
                (this.ElectricalProperties == null && other.ElectricalProperties == null ||
                 this.ElectricalProperties?.Equals(other.ElectricalProperties) == true) &&
                (this.FixedCable == null && other.FixedCable == null ||
                 this.FixedCable?.Equals(other.FixedCable) == true) &&
                (this.Tariff == null && other.Tariff == null ||
                 this.Tariff?.Equals(other.Tariff) == true) &&
                (this.Updated == null && other.Updated == null ||
                 this.Updated?.Equals(other.Updated) == true) &&
                (this.UpdatedBy == null && other.UpdatedBy == null ||
                 this.UpdatedBy?.Equals(other.UpdatedBy) == true) &&
                (this.Deleted == null && other.Deleted == null ||
                 this.Deleted?.Equals(other.Deleted) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid.ToString())}");
            toStringOutput.Add($"this.ExternalId = {this.ExternalId ?? "null"}");
            toStringOutput.Add($"this.ConnectorType = {(this.ConnectorType == null ? "null" : this.ConnectorType.ToString())}");
            toStringOutput.Add($"this.ElectricalProperties = {(this.ElectricalProperties == null ? "null" : this.ElectricalProperties.ToString())}");
            toStringOutput.Add($"this.FixedCable = {(this.FixedCable == null ? "null" : this.FixedCable.ToString())}");
            toStringOutput.Add($"this.Tariff = {(this.Tariff == null ? "null" : this.Tariff.ToString())}");
            toStringOutput.Add($"this.Updated = {this.Updated ?? "null"}");
            toStringOutput.Add($"this.UpdatedBy = {(this.UpdatedBy == null ? "null" : this.UpdatedBy.ToString())}");
            toStringOutput.Add($"this.Deleted = {this.Deleted ?? "null"}");
        }
    }
}