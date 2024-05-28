// <copyright file="HTTP401ErrorResponseException.cs" company="APIMatic">
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
    /// HTTP401ErrorResponseException.
    /// </summary>
    public class HTTP401ErrorResponseException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HTTP401ErrorResponseException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public HTTP401ErrorResponseException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates overall status of the request
        /// </summary>
        [JsonProperty("Status")]
        public Models.ResponseBaseStatusEnum Status { get; set; }

        /// <summary>
        /// Details of error(s) encountered
        /// </summary>
        [JsonProperty("Errors")]
        public List<Models.ResponseError401AllOf1ErrorsItems> Errors { get; set; }
    }
}