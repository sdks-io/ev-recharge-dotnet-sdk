// <copyright file="DataRetrieve.cs" company="APIMatic">
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
    /// DataRetrieve.
    /// </summary>
    public class DataRetrieve
    {
        private DateTime? stoppedAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "stoppedAt", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRetrieve"/> class.
        /// </summary>
        public DataRetrieve()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRetrieve"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="emaId">emaId.</param>
        /// <param name="evseId">evseId.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="startedAt">startedAt.</param>
        /// <param name="stoppedAt">stoppedAt.</param>
        /// <param name="sessionState">sessionState.</param>
        public DataRetrieve(
            Guid? id = null,
            string userId = null,
            string emaId = null,
            string evseId = null,
            string lastUpdated = null,
            DateTime? startedAt = null,
            DateTime? stoppedAt = null,
            Models.ChargeRetrieveState sessionState = null)
        {
            this.Id = id;
            this.UserId = userId;
            this.EmaId = emaId;
            this.EvseId = evseId;
            this.LastUpdated = lastUpdated;
            this.StartedAt = startedAt;

            if (stoppedAt != null)
            {
                this.StoppedAt = stoppedAt;
            }
            this.SessionState = sessionState;
        }

        /// <summary>
        /// Id of the session
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Id of the user that started the session
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// Id of the evse that the user is charging
        /// </summary>
        [JsonProperty("emaId", NullValueHandling = NullValueHandling.Ignore)]
        public string EmaId { get; set; }

        /// <summary>
        /// Ema-id of the charge token that is used
        /// </summary>
        [JsonProperty("evseId", NullValueHandling = NullValueHandling.Ignore)]
        public string EvseId { get; set; }

        /// <summary>
        /// Last updated date
        /// </summary>
        [JsonProperty("lastUpdated", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// When the session is started
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the session is stopped
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("stoppedAt")]
        public DateTime? StoppedAt
        {
            get
            {
                return this.stoppedAt;
            }

            set
            {
                this.shouldSerialize["stoppedAt"] = true;
                this.stoppedAt = value;
            }
        }

        /// <summary>
        /// Gets or sets SessionState.
        /// </summary>
        [JsonProperty("sessionState", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChargeRetrieveState SessionState { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DataRetrieve : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStoppedAt()
        {
            this.shouldSerialize["stoppedAt"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStoppedAt()
        {
            return this.shouldSerialize["stoppedAt"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DataRetrieve other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.UserId == null && other.UserId == null ||
                 this.UserId?.Equals(other.UserId) == true) &&
                (this.EmaId == null && other.EmaId == null ||
                 this.EmaId?.Equals(other.EmaId) == true) &&
                (this.EvseId == null && other.EvseId == null ||
                 this.EvseId?.Equals(other.EvseId) == true) &&
                (this.LastUpdated == null && other.LastUpdated == null ||
                 this.LastUpdated?.Equals(other.LastUpdated) == true) &&
                (this.StartedAt == null && other.StartedAt == null ||
                 this.StartedAt?.Equals(other.StartedAt) == true) &&
                (this.StoppedAt == null && other.StoppedAt == null ||
                 this.StoppedAt?.Equals(other.StoppedAt) == true) &&
                (this.SessionState == null && other.SessionState == null ||
                 this.SessionState?.Equals(other.SessionState) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"UserId = {this.UserId ?? "null"}");
            toStringOutput.Add($"EmaId = {this.EmaId ?? "null"}");
            toStringOutput.Add($"EvseId = {this.EvseId ?? "null"}");
            toStringOutput.Add($"LastUpdated = {this.LastUpdated ?? "null"}");
            toStringOutput.Add($"StartedAt = {(this.StartedAt == null ? "null" : this.StartedAt.ToString())}");
            toStringOutput.Add($"StoppedAt = {(this.StoppedAt == null ? "null" : this.StoppedAt.ToString())}");
            toStringOutput.Add($"SessionState = {(this.SessionState == null ? "null" : this.SessionState.ToString())}");
        }
    }
}