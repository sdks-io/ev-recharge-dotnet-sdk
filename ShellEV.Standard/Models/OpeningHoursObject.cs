// <copyright file="OpeningHoursObject.cs" company="APIMatic">
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
    /// OpeningHoursObject.
    /// </summary>
    public class OpeningHoursObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningHoursObject"/> class.
        /// </summary>
        public OpeningHoursObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningHoursObject"/> class.
        /// </summary>
        /// <param name="weekDay">weekDay.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        public OpeningHoursObject(
            Models.OpeningHoursObjectWeekDayEnum? weekDay = null,
            string startTime = null,
            string endTime = null)
        {
            this.WeekDay = weekDay;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// 3 letter day of the week
        /// </summary>
        [JsonProperty("weekDay", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OpeningHoursObjectWeekDayEnum? WeekDay { get; set; }

        /// <summary>
        /// Hour in 24h local time when the location opens.
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// Hour in 24h local time when the location closes.
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OpeningHoursObject : ({string.Join(", ", toStringOutput)})";
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
            return obj is OpeningHoursObject other &&                ((this.WeekDay == null && other.WeekDay == null) || (this.WeekDay?.Equals(other.WeekDay) == true)) &&
                ((this.StartTime == null && other.StartTime == null) || (this.StartTime?.Equals(other.StartTime) == true)) &&
                ((this.EndTime == null && other.EndTime == null) || (this.EndTime?.Equals(other.EndTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WeekDay = {(this.WeekDay == null ? "null" : this.WeekDay.ToString())}");
            toStringOutput.Add($"this.StartTime = {(this.StartTime == null ? "null" : this.StartTime)}");
            toStringOutput.Add($"this.EndTime = {(this.EndTime == null ? "null" : this.EndTime)}");
        }
    }
}