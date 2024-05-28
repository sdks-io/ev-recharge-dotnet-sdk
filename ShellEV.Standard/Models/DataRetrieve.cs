// <copyright file="DataRetrieve.cs" company="APIMatic">
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
    /// DataRetrieve.
    /// </summary>
    public class DataRetrieve
    {
        private DateTime? stoppedAt;
        private Models.DataRetrieveSessionCodeEnum? sessionCode;
        private string sessionMessage;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "StoppedAt", false },
            { "SessionCode", false },
            { "SessionMessage", false },
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
        /// <param name="id">Id.</param>
        /// <param name="userId">UserId.</param>
        /// <param name="emaId">EmaId.</param>
        /// <param name="evseId">EvseId.</param>
        /// <param name="startedAt">StartedAt.</param>
        /// <param name="stoppedAt">StoppedAt.</param>
        /// <param name="sessionState">SessionState.</param>
        /// <param name="sessionCode">SessionCode.</param>
        /// <param name="sessionMessage">SessionMessage.</param>
        public DataRetrieve(
            Guid? id = null,
            string userId = null,
            string emaId = null,
            string evseId = null,
            DateTime? startedAt = null,
            DateTime? stoppedAt = null,
            Models.DataRetrieveSessionStateEnum? sessionState = null,
            Models.DataRetrieveSessionCodeEnum? sessionCode = null,
            string sessionMessage = null)
        {
            this.Id = id;
            this.UserId = userId;
            this.EmaId = emaId;
            this.EvseId = evseId;
            this.StartedAt = startedAt;
            if (stoppedAt != null)
            {
                this.StoppedAt = stoppedAt;
            }

            this.SessionState = sessionState;
            if (sessionCode != null)
            {
                this.SessionCode = sessionCode;
            }

            if (sessionMessage != null)
            {
                this.SessionMessage = sessionMessage;
            }

        }

        /// <summary>
        /// Id of the session
        /// </summary>
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Id of the user that started the session
        /// </summary>
        [JsonProperty("UserId", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// Id of the evse that the user is charging
        /// </summary>
        [JsonProperty("EmaId", NullValueHandling = NullValueHandling.Ignore)]
        public string EmaId { get; set; }

        /// <summary>
        /// Ema-id of the charge token that is used
        /// </summary>
        [JsonProperty("EvseId", NullValueHandling = NullValueHandling.Ignore)]
        public string EvseId { get; set; }

        /// <summary>
        /// When the session is started
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("StartedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the session is stopped
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("StoppedAt")]
        public DateTime? StoppedAt
        {
            get
            {
                return this.stoppedAt;
            }

            set
            {
                this.shouldSerialize["StoppedAt"] = true;
                this.stoppedAt = value;
            }
        }

        /// <summary>
        /// Describes the session state
        /// </summary>
        [JsonProperty("SessionState", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DataRetrieveSessionStateEnum? SessionState { get; set; }

        /// <summary>
        /// Session code e.g InternalError
        /// </summary>
        [JsonProperty("SessionCode")]
        public Models.DataRetrieveSessionCodeEnum? SessionCode
        {
            get
            {
                return this.sessionCode;
            }

            set
            {
                this.shouldSerialize["SessionCode"] = true;
                this.sessionCode = value;
            }
        }

        /// <summary>
        /// Session message
        /// </summary>
        [JsonProperty("SessionMessage")]
        public string SessionMessage
        {
            get
            {
                return this.sessionMessage;
            }

            set
            {
                this.shouldSerialize["SessionMessage"] = true;
                this.sessionMessage = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DataRetrieve : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStoppedAt()
        {
            this.shouldSerialize["StoppedAt"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSessionCode()
        {
            this.shouldSerialize["SessionCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSessionMessage()
        {
            this.shouldSerialize["SessionMessage"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStoppedAt()
        {
            return this.shouldSerialize["StoppedAt"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSessionCode()
        {
            return this.shouldSerialize["SessionCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSessionMessage()
        {
            return this.shouldSerialize["SessionMessage"];
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
            return obj is DataRetrieve other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.EmaId == null && other.EmaId == null) || (this.EmaId?.Equals(other.EmaId) == true)) &&
                ((this.EvseId == null && other.EvseId == null) || (this.EvseId?.Equals(other.EvseId) == true)) &&
                ((this.StartedAt == null && other.StartedAt == null) || (this.StartedAt?.Equals(other.StartedAt) == true)) &&
                ((this.StoppedAt == null && other.StoppedAt == null) || (this.StoppedAt?.Equals(other.StoppedAt) == true)) &&
                ((this.SessionState == null && other.SessionState == null) || (this.SessionState?.Equals(other.SessionState) == true)) &&
                ((this.SessionCode == null && other.SessionCode == null) || (this.SessionCode?.Equals(other.SessionCode) == true)) &&
                ((this.SessionMessage == null && other.SessionMessage == null) || (this.SessionMessage?.Equals(other.SessionMessage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId)}");
            toStringOutput.Add($"this.EmaId = {(this.EmaId == null ? "null" : this.EmaId)}");
            toStringOutput.Add($"this.EvseId = {(this.EvseId == null ? "null" : this.EvseId)}");
            toStringOutput.Add($"this.StartedAt = {(this.StartedAt == null ? "null" : this.StartedAt.ToString())}");
            toStringOutput.Add($"this.StoppedAt = {(this.StoppedAt == null ? "null" : this.StoppedAt.ToString())}");
            toStringOutput.Add($"this.SessionState = {(this.SessionState == null ? "null" : this.SessionState.ToString())}");
            toStringOutput.Add($"this.SessionCode = {(this.SessionCode == null ? "null" : this.SessionCode.ToString())}");
            toStringOutput.Add($"this.SessionMessage = {(this.SessionMessage == null ? "null" : this.SessionMessage)}");
        }
    }
}