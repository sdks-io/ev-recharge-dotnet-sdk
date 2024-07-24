// <copyright file="ChargeRetrieveState.cs" company="APIMatic">
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
    /// ChargeRetrieveState.
    /// </summary>
    public class ChargeRetrieveState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRetrieveState"/> class.
        /// </summary>
        public ChargeRetrieveState()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRetrieveState"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="error">error.</param>
        public ChargeRetrieveState(
            string status = null,
            Models.ChargeError error = null)
        {
            this.Status = status;
            this.Error = error;
        }

        /// <summary>
        /// Describes the session state
        /// started, stopped, start-requested, stop-requested, failed-to-start, failed-to-stop
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeError Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ChargeRetrieveState : ({string.Join(", ", toStringOutput)})";
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
            return obj is ChargeRetrieveState other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}