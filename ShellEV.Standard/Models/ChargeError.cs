// <copyright file="ChargeError.cs" company="APIMatic">
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
    /// ChargeError.
    /// </summary>
    public class ChargeError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeError"/> class.
        /// </summary>
        public ChargeError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeError"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="message">message.</param>
        public ChargeError(
            string code = null,
            string message = null)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Session code e.g InternalError
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Session message
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ChargeError : ({string.Join(", ", toStringOutput)})";
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
            return obj is ChargeError other &&                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
        }
    }
}