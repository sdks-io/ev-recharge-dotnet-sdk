// <copyright file="ResponseError401AllOf1.cs" company="APIMatic">
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
    /// ResponseError401AllOf1.
    /// </summary>
    public class ResponseError401AllOf1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseError401AllOf1"/> class.
        /// </summary>
        public ResponseError401AllOf1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseError401AllOf1"/> class.
        /// </summary>
        /// <param name="errors">Errors.</param>
        public ResponseError401AllOf1(
            List<Models.ResponseError401AllOf1ErrorsItems> errors)
        {
            this.Errors = errors;
        }

        /// <summary>
        /// Details of error(s) encountered
        /// </summary>
        [JsonProperty("Errors")]
        public List<Models.ResponseError401AllOf1ErrorsItems> Errors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseError401AllOf1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResponseError401AllOf1 other &&                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
        }
    }
}