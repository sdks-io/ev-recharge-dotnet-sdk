// <copyright file="NotFoundErrMsg.cs" company="APIMatic">
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
    /// NotFoundErrMsg.
    /// </summary>
    public class NotFoundErrMsg
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundErrMsg"/> class.
        /// </summary>
        public NotFoundErrMsg()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundErrMsg"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="message">message.</param>
        /// <param name="description">description.</param>
        /// <param name="details">details.</param>
        public NotFoundErrMsg(
            string code = null,
            string message = null,
            string description = null,
            List<string> details = null)
        {
            this.Code = code;
            this.Message = message;
            this.Description = description;
            this.Details = details;
        }

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Error desctiption in English
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Technical details of the error message, the example which is given in the sample payload is one of the scenarios. actual response will vary based on the technical nature
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Details { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NotFoundErrMsg : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NotFoundErrMsg other &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.Message == null && other.Message == null ||
                 this.Message?.Equals(other.Message) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Details == null && other.Details == null ||
                 this.Details?.Equals(other.Details) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Details = {(this.Details == null ? "null" : $"[{string.Join(", ", this.Details)} ]")}");
        }
    }
}