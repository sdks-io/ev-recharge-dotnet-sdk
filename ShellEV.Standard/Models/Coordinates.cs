// <copyright file="Coordinates.cs" company="APIMatic">
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
    /// Coordinates.
    /// </summary>
    public class Coordinates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinates"/> class.
        /// </summary>
        public Coordinates()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinates"/> class.
        /// </summary>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        public Coordinates(
            double? latitude = null,
            double? longitude = null)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Latitude of the Coordinate
        /// </summary>
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Longitude of the Coordinate
        /// </summary>
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? Longitude { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Coordinates : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Coordinates other &&
                (this.Latitude == null && other.Latitude == null ||
                 this.Latitude?.Equals(other.Latitude) == true) &&
                (this.Longitude == null && other.Longitude == null ||
                 this.Longitude?.Equals(other.Longitude) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Latitude = {(this.Latitude == null ? "null" : this.Latitude.ToString())}");
            toStringOutput.Add($"this.Longitude = {(this.Longitude == null ? "null" : this.Longitude.ToString())}");
        }
    }
}