// <copyright file="M401ErrorResponseError1Exception.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellEV.Standard.Exceptions
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
    using ShellEV.Standard.Http.Client;
    using ShellEV.Standard.Models;
    using ShellEV.Standard.Utilities;

    /// <summary>
    /// M401ErrorResponseError1Exception.
    /// </summary>
    public class M401ErrorResponseError1Exception : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M401ErrorResponseError1Exception"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public M401ErrorResponseError1Exception(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates overall status of the request
        /// </summary>
        [JsonProperty("Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("Errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.M401ErrorResponseError> Errors { get; set; }
    }
}