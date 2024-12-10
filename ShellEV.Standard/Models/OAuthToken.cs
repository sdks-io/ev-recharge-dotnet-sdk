// <copyright file="OAuthToken.cs" company="APIMatic">
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
    /// OAuthToken.
    /// </summary>
    public class OAuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthToken"/> class.
        /// </summary>
        public OAuthToken()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthToken"/> class.
        /// </summary>
        /// <param name="accessToken">access_token.</param>
        /// <param name="tokenType">token_type.</param>
        /// <param name="expiresIn">expires_in.</param>
        /// <param name="scope">scope.</param>
        /// <param name="expiry">expiry.</param>
        /// <param name="refreshToken">refresh_token.</param>
        public OAuthToken(
            string accessToken,
            string tokenType,
            long? expiresIn = null,
            string scope = null,
            long? expiry = null,
            string refreshToken = null)
        {
            this.AccessToken = accessToken;
            this.TokenType = tokenType;
            this.ExpiresIn = expiresIn;
            this.Scope = scope;
            this.Expiry = expiry;
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// Access token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Type of access token
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Time in seconds before the access token expires
        /// </summary>
        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpiresIn { get; set; }

        /// <summary>
        /// List of scopes granted
        /// This is a space-delimited list of strings.
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// Time of token expiry as unix timestamp (UTC)
        /// </summary>
        [JsonProperty("expiry", NullValueHandling = NullValueHandling.Ignore)]
        public long? Expiry { get; set; }

        /// <summary>
        /// Refresh token
        /// Used to get a new access token when it expires.
        /// </summary>
        [JsonProperty("refresh_token", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OAuthToken : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OAuthToken other &&
                (this.AccessToken == null && other.AccessToken == null ||
                 this.AccessToken?.Equals(other.AccessToken) == true) &&
                (this.TokenType == null && other.TokenType == null ||
                 this.TokenType?.Equals(other.TokenType) == true) &&
                (this.ExpiresIn == null && other.ExpiresIn == null ||
                 this.ExpiresIn?.Equals(other.ExpiresIn) == true) &&
                (this.Scope == null && other.Scope == null ||
                 this.Scope?.Equals(other.Scope) == true) &&
                (this.Expiry == null && other.Expiry == null ||
                 this.Expiry?.Equals(other.Expiry) == true) &&
                (this.RefreshToken == null && other.RefreshToken == null ||
                 this.RefreshToken?.Equals(other.RefreshToken) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccessToken = {this.AccessToken ?? "null"}");
            toStringOutput.Add($"this.TokenType = {this.TokenType ?? "null"}");
            toStringOutput.Add($"this.ExpiresIn = {(this.ExpiresIn == null ? "null" : this.ExpiresIn.ToString())}");
            toStringOutput.Add($"this.Scope = {this.Scope ?? "null"}");
            toStringOutput.Add($"this.Expiry = {(this.Expiry == null ? "null" : this.Expiry.ToString())}");
            toStringOutput.Add($"this.RefreshToken = {this.RefreshToken ?? "null"}");
        }
    }
}