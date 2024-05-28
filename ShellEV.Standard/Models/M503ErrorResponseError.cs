// <copyright file="M503ErrorResponseError.cs" company="APIMatic">
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
    /// M503ErrorResponseError.
    /// </summary>
    public class M503ErrorResponseError
    {
        private Dictionary<string, string> additionalInfo;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AdditionalInfo", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="M503ErrorResponseError"/> class.
        /// </summary>
        public M503ErrorResponseError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M503ErrorResponseError"/> class.
        /// </summary>
        /// <param name="code">Code.</param>
        /// <param name="title">Title.</param>
        /// <param name="detail">Detail.</param>
        /// <param name="additionalInfo">AdditionalInfo.</param>
        public M503ErrorResponseError(
            string code,
            string title,
            string detail,
            Dictionary<string, string> additionalInfo = null)
        {
            this.Code = code;
            this.Title = title;
            this.Detail = detail;
            if (additionalInfo != null)
            {
                this.AdditionalInfo = additionalInfo;
            }

        }

        /// <summary>
        /// Error code that logically best represents the error encountered
        /// </summary>
        [JsonProperty("Code")]
        public string Code { get; set; }

        /// <summary>
        /// Description of the error type
        /// </summary>
        [JsonProperty("Title")]
        public string Title { get; set; }

        /// <summary>
        /// Details of the error that can help under the cause of the error
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or sets AdditionalInfo.
        /// </summary>
        [JsonProperty("AdditionalInfo")]
        public Dictionary<string, string> AdditionalInfo
        {
            get
            {
                return this.additionalInfo;
            }

            set
            {
                this.shouldSerialize["AdditionalInfo"] = true;
                this.additionalInfo = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"M503ErrorResponseError : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAdditionalInfo()
        {
            this.shouldSerialize["AdditionalInfo"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalInfo()
        {
            return this.shouldSerialize["AdditionalInfo"];
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
            return obj is M503ErrorResponseError other &&                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Detail == null && other.Detail == null) || (this.Detail?.Equals(other.Detail) == true)) &&
                ((this.AdditionalInfo == null && other.AdditionalInfo == null) || (this.AdditionalInfo?.Equals(other.AdditionalInfo) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.Detail = {(this.Detail == null ? "null" : this.Detail)}");
            toStringOutput.Add($"AdditionalInfo = {(this.AdditionalInfo == null ? "null" : this.AdditionalInfo.ToString())}");
        }
    }
}