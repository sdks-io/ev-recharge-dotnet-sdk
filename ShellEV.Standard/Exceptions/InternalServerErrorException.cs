// <copyright file="InternalServerErrorException.cs" company="APIMatic">
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
using ShellEV.Standard.Http.Client;
using ShellEV.Standard.Models;
using ShellEV.Standard.Utilities;

namespace ShellEV.Standard.Exceptions
{
    /// <summary>
    /// InternalServerErrorException.
    /// </summary>
    public class InternalServerErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalServerErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public InternalServerErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// requestId is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain.
        /// </summary>
        [JsonProperty("requestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Status of the request
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Exception details of the error
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InternalErrorObject> Errors { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Details { get; set; }
    }
}