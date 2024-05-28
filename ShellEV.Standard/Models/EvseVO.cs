// <copyright file="EvseVO.cs" company="APIMatic">
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
    /// EvseVO.
    /// </summary>
    public class EvseVO
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvseVO"/> class.
        /// </summary>
        public EvseVO()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvseVO"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="evseId">evseId.</param>
        /// <param name="status">status.</param>
        /// <param name="connectors">connectors.</param>
        /// <param name="authorizationMethods">authorizationMethods.</param>
        /// <param name="updated">updated.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="physicalReference">physicalReference.</param>
        public EvseVO(
            int? uid = null,
            string externalId = null,
            string evseId = null,
            Models.EvseVOStatusEnum? status = null,
            List<Models.ConnectorVO> connectors = null,
            Models.EvseVOAuthorizationMethodsEnum? authorizationMethods = null,
            string updated = null,
            string deleted = null,
            string physicalReference = null)
        {
            this.Uid = uid;
            this.ExternalId = externalId;
            this.EvseId = evseId;
            this.Status = status;
            this.Connectors = connectors;
            this.AuthorizationMethods = authorizationMethods;
            this.Updated = updated;
            this.Deleted = deleted;
            this.PhysicalReference = physicalReference;
        }

        /// <summary>
        /// Internal identifier used to refer to single individual  EVSE unit.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Uid { get; set; }

        /// <summary>
        /// Identifier of the Evse as given by the Operator, unique for that Operator
        /// </summary>
        [JsonProperty("externalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Standard EVSEId identifier (ISO-IEC-15118)
        /// </summary>
        [JsonProperty("evseId", NullValueHandling = NullValueHandling.Ignore)]
        public string EvseId { get; set; }

        /// <summary>
        /// The current status of the EVSE units availability
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EvseVOStatusEnum? Status { get; set; }

        /// <summary>
        /// List of all connectors available on this EVSE unit.
        /// </summary>
        [JsonProperty("connectors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ConnectorVO> Connectors { get; set; }

        /// <summary>
        /// Methods that can be used to Authorize sessions on this EVSE
        /// </summary>
        [JsonProperty("authorizationMethods", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EvseVOAuthorizationMethodsEnum? AuthorizationMethods { get; set; }

        /// <summary>
        /// ISO8601-compliant UTC datetime of the last update of the EVSE
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// optional  ISO8601-compliant UTC deletion timestamp of the Evse
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public string Deleted { get; set; }

        /// <summary>
        /// An optional number/string printed on the outside of the EVSE for visual identification
        /// </summary>
        [JsonProperty("physicalReference", NullValueHandling = NullValueHandling.Ignore)]
        public string PhysicalReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EvseVO : ({string.Join(", ", toStringOutput)})";
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
            return obj is EvseVO other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.ExternalId == null && other.ExternalId == null) || (this.ExternalId?.Equals(other.ExternalId) == true)) &&
                ((this.EvseId == null && other.EvseId == null) || (this.EvseId?.Equals(other.EvseId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Connectors == null && other.Connectors == null) || (this.Connectors?.Equals(other.Connectors) == true)) &&
                ((this.AuthorizationMethods == null && other.AuthorizationMethods == null) || (this.AuthorizationMethods?.Equals(other.AuthorizationMethods) == true)) &&
                ((this.Updated == null && other.Updated == null) || (this.Updated?.Equals(other.Updated) == true)) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true)) &&
                ((this.PhysicalReference == null && other.PhysicalReference == null) || (this.PhysicalReference?.Equals(other.PhysicalReference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid.ToString())}");
            toStringOutput.Add($"this.ExternalId = {(this.ExternalId == null ? "null" : this.ExternalId)}");
            toStringOutput.Add($"this.EvseId = {(this.EvseId == null ? "null" : this.EvseId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Connectors = {(this.Connectors == null ? "null" : $"[{string.Join(", ", this.Connectors)} ]")}");
            toStringOutput.Add($"this.AuthorizationMethods = {(this.AuthorizationMethods == null ? "null" : this.AuthorizationMethods.ToString())}");
            toStringOutput.Add($"this.Updated = {(this.Updated == null ? "null" : this.Updated)}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted)}");
            toStringOutput.Add($"this.PhysicalReference = {(this.PhysicalReference == null ? "null" : this.PhysicalReference)}");
        }
    }
}