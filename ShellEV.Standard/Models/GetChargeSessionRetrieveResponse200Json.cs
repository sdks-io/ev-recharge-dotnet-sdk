// <copyright file="GetChargeSessionRetrieveResponse200Json.cs" company="APIMatic">
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
    /// GetChargeSessionRetrieveResponse200Json.
    /// </summary>
    public class GetChargeSessionRetrieveResponse200Json
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChargeSessionRetrieveResponse200Json"/> class.
        /// </summary>
        public GetChargeSessionRetrieveResponse200Json()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChargeSessionRetrieveResponse200Json"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        public GetChargeSessionRetrieveResponse200Json(
            Guid requestId,
            Models.GetChargeSessionRetrieveResponse200JsonStatusEnum status,
            List<Models.DataRetrieve> data = null)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request.
        /// </summary>
        [JsonProperty("RequestId")]
        public Guid RequestId { get; set; }

        /// <summary>
        /// Indicates overall status of the request
        /// </summary>
        [JsonProperty("Status")]
        public Models.GetChargeSessionRetrieveResponse200JsonStatusEnum Status { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DataRetrieve> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetChargeSessionRetrieveResponse200Json : ({string.Join(", ", toStringOutput)})";
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
            return obj is GetChargeSessionRetrieveResponse200Json other &&                this.RequestId.Equals(other.RequestId) &&
                this.Status.Equals(other.Status) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {this.RequestId}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}