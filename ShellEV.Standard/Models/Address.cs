// <copyright file="Address.cs" company="APIMatic">
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
    /// Address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="streetAndNumber">streetAndNumber.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        public Address(
            string streetAndNumber = null,
            string postalCode = null,
            string city = null,
            string country = null)
        {
            this.StreetAndNumber = streetAndNumber;
            this.PostalCode = postalCode;
            this.City = city;
            this.Country = country;
        }

        /// <summary>
        /// Street Name and Number of the Shell Recharge Location
        /// </summary>
        [JsonProperty("streetAndNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetAndNumber { get; set; }

        /// <summary>
        /// Postal Code of the Shell Recharge Location
        /// </summary>
        [JsonProperty("postalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        /// <summary>
        /// City name of the Shell Recharge Location
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// ISO 3166 Alpha-2 Country Code of the Shell Recharge Location
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Address : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Address other &&
                (this.StreetAndNumber == null && other.StreetAndNumber == null ||
                 this.StreetAndNumber?.Equals(other.StreetAndNumber) == true) &&
                (this.PostalCode == null && other.PostalCode == null ||
                 this.PostalCode?.Equals(other.PostalCode) == true) &&
                (this.City == null && other.City == null ||
                 this.City?.Equals(other.City) == true) &&
                (this.Country == null && other.Country == null ||
                 this.Country?.Equals(other.Country) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StreetAndNumber = {this.StreetAndNumber ?? "null"}");
            toStringOutput.Add($"PostalCode = {this.PostalCode ?? "null"}");
            toStringOutput.Add($"City = {this.City ?? "null"}");
            toStringOutput.Add($"Country = {this.Country ?? "null"}");
        }
    }
}