// <copyright file="ChargingController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using ShellEV.Standard;
using ShellEV.Standard.Exceptions;
using ShellEV.Standard.Http.Client;
using ShellEV.Standard.Utilities;
using System.Net.Http;

namespace ShellEV.Standard.Controllers
{
    /// <summary>
    /// ChargingController.
    /// </summary>
    public class ChargingController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargingController"/> class.
        /// </summary>
        internal ChargingController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint start the charging session for the user.
        /// </summary>
        /// <param name="requestId"><![CDATA[Required parameter: RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br>.]]></param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.InlineResponse202 response from the API call.</returns>
        public Models.InlineResponse202 Start(
                Guid requestId,
                Models.ChargesessionStartBody body = null)
            => CoreHelper.RunTask(StartAsync(requestId, body));

        /// <summary>
        /// This endpoint start the charging session for the user.
        /// </summary>
        /// <param name="requestId"><![CDATA[Required parameter: RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br>.]]></param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InlineResponse202 response from the API call.</returns>
        public async Task<Models.InlineResponse202> StartAsync(
                Guid requestId,
                Models.ChargesessionStartBody body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InlineResponse202>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/charge-session/start")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new BadRequestException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid authentication credentials for the target resource.", (_reason, _context) => new UnauthorizedException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Location Not Found", (_reason, _context) => new NotFoundException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("The Request reached maximum allocated rate limit", (_reason, _context) => new TooManyRequestsException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server error", (_reason, _context) => new InternalServerErrorException(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Service unavailable", (_reason, _context) => new ServiceunavailableException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Accepts a request to stop an active session when a valid session id is provided.
        /// </summary>
        /// <param name="requestId"><![CDATA[Required parameter: RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br>.]]></param>
        /// <param name="sessionId">Required parameter: Session Id.</param>
        /// <returns>Returns the Models.InlineResponse2021 response from the API call.</returns>
        public Models.InlineResponse2021 Stop(
                Guid requestId,
                string sessionId)
            => CoreHelper.RunTask(StopAsync(requestId, sessionId));

        /// <summary>
        /// Accepts a request to stop an active session when a valid session id is provided.
        /// </summary>
        /// <param name="requestId"><![CDATA[Required parameter: RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br>.]]></param>
        /// <param name="sessionId">Required parameter: Session Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InlineResponse2021 response from the API call.</returns>
        public async Task<Models.InlineResponse2021> StopAsync(
                Guid requestId,
                string sessionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InlineResponse2021>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/charge-session/stop")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Query(_query => _query.Setup("sessionId", sessionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new BadRequestException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid authentication credentials for the target resource.", (_reason, _context) => new UnauthorizedException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Location Not Found", (_reason, _context) => new NotFoundException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("The Request reached maximum allocated rate limit", (_reason, _context) => new TooManyRequestsException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server error", (_reason, _context) => new InternalServerErrorException(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Service unavailable", (_reason, _context) => new ServiceunavailableException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint returns the details of the session if the session is found.
        /// </summary>
        /// <param name="requestId"><![CDATA[Required parameter: RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br>.]]></param>
        /// <param name="sessionId">Required parameter: Session Id.</param>
        /// <returns>Returns the Models.GetChargeSessionRetrieveResponse200Json response from the API call.</returns>
        public Models.GetChargeSessionRetrieveResponse200Json GetChargeSessionRetrieve(
                Guid requestId,
                string sessionId)
            => CoreHelper.RunTask(GetChargeSessionRetrieveAsync(requestId, sessionId));

        /// <summary>
        /// This endpoint returns the details of the session if the session is found.
        /// </summary>
        /// <param name="requestId"><![CDATA[Required parameter: RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br>.]]></param>
        /// <param name="sessionId">Required parameter: Session Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeSessionRetrieveResponse200Json response from the API call.</returns>
        public async Task<Models.GetChargeSessionRetrieveResponse200Json> GetChargeSessionRetrieveAsync(
                Guid requestId,
                string sessionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeSessionRetrieveResponse200Json>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/charge-session/retrieve")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Query(_query => _query.Setup("sessionId", sessionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new BadRequestException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid authentication credentials for the target resource.", (_reason, _context) => new UnauthorizedException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Location Not Found", (_reason, _context) => new NotFoundException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("The Request reached maximum allocated rate limit", (_reason, _context) => new TooManyRequestsException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server error", (_reason, _context) => new InternalServerErrorException(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Service unavailable", (_reason, _context) => new ServiceunavailableException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetrches the active sessions for user.
        /// </summary>
        /// <param name="requestId"><![CDATA[Required parameter: RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br>.]]></param>
        /// <param name="emaId">Required parameter: Emobility Account Identifier(Ema-ID).</param>
        /// <returns>Returns the Models.ActiveResponse200Json response from the API call.</returns>
        public Models.ActiveResponse200Json Active(
                Guid requestId,
                string emaId)
            => CoreHelper.RunTask(ActiveAsync(requestId, emaId));

        /// <summary>
        /// Fetrches the active sessions for user.
        /// </summary>
        /// <param name="requestId"><![CDATA[Required parameter: RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br>.]]></param>
        /// <param name="emaId">Required parameter: Emobility Account Identifier(Ema-ID).</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ActiveResponse200Json response from the API call.</returns>
        public async Task<Models.ActiveResponse200Json> ActiveAsync(
                Guid requestId,
                string emaId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ActiveResponse200Json>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/charge-session/active")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Query(_query => _query.Setup("emaId", emaId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}