// <copyright file="UnauthorizedException.cs" company="APIMatic">
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
    /// UnauthorizedException.
    /// </summary>
    public class UnauthorizedException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorizedException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public UnauthorizedException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// requestId or correlation id of the message
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
        public List<Models.UnauthorizedErrMsg> Errors { get; set; }
    }
}