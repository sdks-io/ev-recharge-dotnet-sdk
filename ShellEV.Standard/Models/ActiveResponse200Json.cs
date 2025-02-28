// <copyright file="ActiveResponse200Json.cs" company="APIMatic">
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
    /// ActiveResponse200Json.
    /// </summary>
    public class ActiveResponse200Json
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveResponse200Json"/> class.
        /// </summary>
        public ActiveResponse200Json()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveResponse200Json"/> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        /// <param name="status">status.</param>
        /// <param name="data">data.</param>
        public ActiveResponse200Json(
            Guid requestId,
            Models.GetChargeSessionRetrieveResponse200JsonStatusEnum status,
            List<Models.DataActive> data = null)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.
        /// </summary>
        [JsonProperty("requestId")]
        public Guid RequestId { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public Models.GetChargeSessionRetrieveResponse200JsonStatusEnum Status { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DataActive> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ActiveResponse200Json : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ActiveResponse200Json other &&
                (this.RequestId.Equals(other.RequestId)) &&
                (this.Status.Equals(other.Status)) &&
                (this.Data == null && other.Data == null ||
                 this.Data?.Equals(other.Data) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RequestId = {this.RequestId}");
            toStringOutput.Add($"Status = {this.Status}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}