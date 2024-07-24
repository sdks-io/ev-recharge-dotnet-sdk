// <copyright file="SingleLocationMarkerResponse.cs" company="APIMatic">
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
    using ShellEV.Standard.Models.Containers;
    using ShellEV.Standard.Utilities;

    /// <summary>
    /// SingleLocationMarkerResponse.
    /// </summary>
    public class SingleLocationMarkerResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLocationMarkerResponse"/> class.
        /// </summary>
        public SingleLocationMarkerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleLocationMarkerResponse"/> class.
        /// </summary>
        /// <param name="requestId">requestId.</param>
        /// <param name="status">status.</param>
        /// <param name="data">data.</param>
        public SingleLocationMarkerResponse(
            Guid? requestId = null,
            string status = null,
            List<LocationMarker> data = null)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// requestId is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain.
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? RequestId { get; set; }

        /// <summary>
        /// status of the API call
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<LocationMarker> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SingleLocationMarkerResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is SingleLocationMarkerResponse other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}