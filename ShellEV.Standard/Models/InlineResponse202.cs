// <copyright file="InlineResponse202.cs" company="APIMatic">
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
    /// InlineResponse202.
    /// </summary>
    public class InlineResponse202
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse202"/> class.
        /// </summary>
        public InlineResponse202()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse202"/> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        /// <param name="status">status.</param>
        /// <param name="data">data.</param>
        public InlineResponse202(
            Guid requestId,
            Models.InlineResponse202StatusEnum status,
            List<Models.InlineResponse202Data> data)
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
        /// Indicates overall status of the request
        /// </summary>
        [JsonProperty("status")]
        public Models.InlineResponse202StatusEnum Status { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public List<Models.InlineResponse202Data> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InlineResponse202 : ({string.Join(", ", toStringOutput)})";
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
            return obj is InlineResponse202 other &&                this.RequestId.Equals(other.RequestId) &&
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