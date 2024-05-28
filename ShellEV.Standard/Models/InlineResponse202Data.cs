// <copyright file="InlineResponse202Data.cs" company="APIMatic">
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
    /// InlineResponse202Data.
    /// </summary>
    public class InlineResponse202Data
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse202Data"/> class.
        /// </summary>
        public InlineResponse202Data()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse202Data"/> class.
        /// </summary>
        /// <param name="sessionId">SessionId.</param>
        public InlineResponse202Data(
            string sessionId)
        {
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Session Id for tracking.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InlineResponse202Data : ({string.Join(", ", toStringOutput)})";
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
            return obj is InlineResponse202Data other &&                ((this.SessionId == null && other.SessionId == null) || (this.SessionId?.Equals(other.SessionId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SessionId = {(this.SessionId == null ? "null" : this.SessionId)}");
        }
    }
}