// <copyright file="SuccessResponse.cs" company="APIMatic">
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
    /// SuccessResponse.
    /// </summary>
    public class SuccessResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessResponse"/> class.
        /// </summary>
        public SuccessResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="status">Status.</param>
        public SuccessResponse(
            string requestId,
            Models.ResponseBaseStatusEnum status)
        {
            this.RequestId = requestId;
            this.Status = status;
        }

        /// <summary>
        /// A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates overall status of the request
        /// </summary>
        [JsonProperty("Status")]
        public Models.ResponseBaseStatusEnum Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SuccessResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is SuccessResponse other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                this.Status.Equals(other.Status);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.Status = {this.Status}");
        }
    }
}