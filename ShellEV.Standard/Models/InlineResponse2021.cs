// <copyright file="InlineResponse2021.cs" company="APIMatic">
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
    /// InlineResponse2021.
    /// </summary>
    public class InlineResponse2021
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2021"/> class.
        /// </summary>
        public InlineResponse2021()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2021"/> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        /// <param name="status">status.</param>
        public InlineResponse2021(
            Guid requestId,
            Models.GetChargeSessionRetrieveResponse200JsonStatusEnum status)
        {
            this.RequestId = requestId;
            this.Status = status;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InlineResponse2021 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InlineResponse2021 other &&
                (this.RequestId.Equals(other.RequestId)) &&
                (this.Status.Equals(other.Status));
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RequestId = {this.RequestId}");
            toStringOutput.Add($"Status = {this.Status}");
        }
    }
}