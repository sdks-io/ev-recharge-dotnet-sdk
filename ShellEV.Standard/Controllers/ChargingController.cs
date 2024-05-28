// <copyright file="ChargingController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellEV.Standard.Controllers
{
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
        /// This API initiates to start a session on a EVSE (Electric Vehicle Supply Equipement). When the EV Charge Card number and the unique EVSE ID on the location is provided, the session is initiated. .
        /// Please note that this is an asynchronous request, the request will be passed on to the operator/platform to be processed further. .
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.InlineResponse202 response from the API call.</returns>
        public Models.InlineResponse202 StartChargeSession(
                Guid requestId,
                Models.ChargesessionStartBody body = null)
            => CoreHelper.RunTask(StartChargeSessionAsync(requestId, body));

        /// <summary>
        /// This API initiates to start a session on a EVSE (Electric Vehicle Supply Equipement). When the EV Charge Card number and the unique EVSE ID on the location is provided, the session is initiated. .
        /// Please note that this is an asynchronous request, the request will be passed on to the operator/platform to be processed further. .
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InlineResponse202 response from the API call.</returns>
        public async Task<Models.InlineResponse202> StartChargeSessionAsync(
                Guid requestId,
                Models.ChargesessionStartBody body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InlineResponse202>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/ev/v1/charge-session/start")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request\n", (_reason, _context) => new M400ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new HTTP401ErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Invalid charge token with given EmaId was not found.\n\nBackend HTTP 410 should be transformed to 404.", (_reason, _context) => new M404ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("405", CreateErrorCase("Method Not Allowed", (_reason, _context) => new M405ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new M429ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new M500ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Returned when a connectivity failure is encountered like DB connection failed, endpoint failed etc or when max number of retries are completed", (_reason, _context) => new M503ErrorResponseError1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API stops a session by providing the session ID which was retrieved when starting the session. HTTP 202 response will be returned if the request is accepted. Once the session is stopped the response will contain the DateTime on which it is stopped.      operationId: Stop.
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="uuid">Required parameter: Unique session ID which was generated to activate a charging session..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.InlineResponse2021 response from the API call.</returns>
        public Models.InlineResponse2021 StopChargeSession(
                Guid requestId,
                Guid uuid,
                Models.StopChargeSessionRequestBodyJson body = null)
            => CoreHelper.RunTask(StopChargeSessionAsync(requestId, uuid, body));

        /// <summary>
        /// This API stops a session by providing the session ID which was retrieved when starting the session. HTTP 202 response will be returned if the request is accepted. Once the session is stopped the response will contain the DateTime on which it is stopped.      operationId: Stop.
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="uuid">Required parameter: Unique session ID which was generated to activate a charging session..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InlineResponse2021 response from the API call.</returns>
        public async Task<Models.InlineResponse2021> StopChargeSessionAsync(
                Guid requestId,
                Guid uuid,
                Models.StopChargeSessionRequestBodyJson body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InlineResponse2021>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/ev/v1/charge-session/stop/{uuid}")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Template(_template => _template.Setup("uuid", uuid))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request\n", (_reason, _context) => new M400ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new M401ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Session not found or Session has already been stopped. Map 410 Error message into 404.", (_reason, _context) => new M404ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("405", CreateErrorCase("Method Not Allowed", (_reason, _context) => new M405ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new M429ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new M500ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Returned when a connectivity failure is encountered like DB connection failed, endpoint failed etc or when max number of retries are completed\n", (_reason, _context) => new M503ErrorResponseError1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API retrieves the status and details of the session which was started by the user. The session ID generated earlier needs to be passed in this API in order to retrieve the status.
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="sessionId">Required parameter: Session Id is to be fetched.</param>
        /// <param name="uuid">Required parameter: Unique session ID which was generated to activate a charging session..</param>
        /// <returns>Returns the Models.GetChargeSessionRetrieveResponse200Json response from the API call.</returns>
        public Models.GetChargeSessionRetrieveResponse200Json GetChargeSessionRetrieve(
                Guid requestId,
                string sessionId,
                Guid uuid)
            => CoreHelper.RunTask(GetChargeSessionRetrieveAsync(requestId, sessionId, uuid));

        /// <summary>
        /// This API retrieves the status and details of the session which was started by the user. The session ID generated earlier needs to be passed in this API in order to retrieve the status.
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="sessionId">Required parameter: Session Id is to be fetched.</param>
        /// <param name="uuid">Required parameter: Unique session ID which was generated to activate a charging session..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetChargeSessionRetrieveResponse200Json response from the API call.</returns>
        public async Task<Models.GetChargeSessionRetrieveResponse200Json> GetChargeSessionRetrieveAsync(
                Guid requestId,
                string sessionId,
                Guid uuid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetChargeSessionRetrieveResponse200Json>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/ev/v1/charge-session/retrieve/{uuid}")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Query(_query => _query.Setup("SessionId", sessionId))
                      .Template(_template => _template.Setup("uuid", uuid))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new M401ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new M404ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("405", CreateErrorCase("Method Not Allowed", (_reason, _context) => new M405ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new M429ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new M500ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Service Unavailable", (_reason, _context) => new M503ErrorResponseError1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API retrieves the list of active sessions for a given set of EMAIds.
        /// </summary>
        /// <param name="emaId">Required parameter: Emobility Account Identifier(Ema-ID).</param>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <returns>Returns the Models.ActiveResponse200Json response from the API call.</returns>
        public Models.ActiveResponse200Json Active(
                string emaId,
                Guid requestId)
            => CoreHelper.RunTask(ActiveAsync(emaId, requestId));

        /// <summary>
        /// This API retrieves the list of active sessions for a given set of EMAIds.
        /// </summary>
        /// <param name="emaId">Required parameter: Emobility Account Identifier(Ema-ID).</param>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ActiveResponse200Json response from the API call.</returns>
        public async Task<Models.ActiveResponse200Json> ActiveAsync(
                string emaId,
                Guid requestId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ActiveResponse200Json>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/ev/v1/charge-session/active")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("EmaId", emaId))
                      .Header(_header => _header.Setup("RequestId", requestId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request\n", (_reason, _context) => new M400ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new M401ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Session not found or Session has already been stopped. Map 410 Error message into 404.", (_reason, _context) => new M404ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("405", CreateErrorCase("Method Not Allowed", (_reason, _context) => new M405ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new M429ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new M500ErrorResponseError1Exception(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Returned when a connectivity failure is encountered like DB connection failed, endpoint failed etc or when max number of retries are completed\n", (_reason, _context) => new M503ErrorResponseError1Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}