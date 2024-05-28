// <copyright file="Accessibility.cs" company="APIMatic">
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
    /// Accessibility.
    /// </summary>
    public class Accessibility
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Accessibility"/> class.
        /// </summary>
        public Accessibility()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Accessibility"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="remark">remark.</param>
        public Accessibility(
            Models.AccessibilityStatusEnum? status = null,
            string remark = null)
        {
            this.Status = status;
            this.Remark = remark;
        }

        /// <summary>
        /// Accessibility Status
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccessibilityStatusEnum? Status { get; set; }

        /// <summary>
        /// optional Arbitrary text about restrictions of the Location
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Accessibility : ({string.Join(", ", toStringOutput)})";
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
            return obj is Accessibility other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Remark == null && other.Remark == null) || (this.Remark?.Equals(other.Remark) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Remark = {(this.Remark == null ? "null" : this.Remark)}");
        }
    }
}