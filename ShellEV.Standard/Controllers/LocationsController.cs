// <copyright file="LocationsController.cs" company="APIMatic">
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
    using ShellEV.Standard.Models.Containers;
    using ShellEV.Standard.Utilities;
    using System.Net.Http;

    /// <summary>
    /// LocationsController.
    /// </summary>
    public class LocationsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationsController"/> class.
        /// </summary>
        internal LocationsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This API provides the list of all Shell Recharge locations. The list includes all Shell Recharge network and all locations available through our roaming partners.The end point provides flexible search criteria in order to get the list of Shell Recharge Network. The end point provides the details such as the exact location/address of the site along with the up-to-date status information of all the charging units in the site. .
        /// Supported Search Options.
        /// * Based on status of the Charging units. Eg : Available or Occupied.
        /// * Based on available connector types.
        /// * Based on minimum Power output (in kW) available.
        /// * Based on a specific charging unit ID (EVSE ID).
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="evseStatus">Optional parameter: Filter by Locations that have the given status.</param>
        /// <param name="connectorTypes">Optional parameter: Filter by Locations that have Connectors with the set of Connector Types.</param>
        /// <param name="connectorMinPower">Optional parameter: Filter by Locations that have a Connector with at least this power output (in kW).</param>
        /// <param name="authorizationMethods">Optional parameter: Filter by Locations that support the given Authorization Methods.</param>
        /// <param name="withOperatorName">Optional parameter: Return operator name in marker response object.</param>
        /// <param name="evseId">Optional parameter: optional Standard EVSE (Electric Vehicle Supply Equipment) Id identifier (ISO-IEC-15118).</param>
        /// <param name="locationExternalId">Optional parameter: Filter by Locations with the given externalId. (Unique Location externalID provided by Shell Recharge).</param>
        /// <param name="evseExternalId">Optional parameter: Filter by Locations that have an Evse with the given External Id. (Unique individual EVSE externalID provided by Shell Recharge).</param>
        /// <param name="pageNumber">Optional parameter: Restrict the response list by providing a specific set of page Number. Set perPage parameter also when pageNumber is used..</param>
        /// <param name="perPage">Optional parameter: Restrict the number of sites in reposne per page..</param>
        /// <param name="updatedSince">Optional parameter: ZonedDateTime as string.</param>
        /// <returns>Returns the List of Models.LocationResponeObject response from the API call.</returns>
        public List<Models.LocationResponeObject> GetLocationsList(
                string requestId,
                Models.GetLocationsListEvseStatusEnum? evseStatus = null,
                Models.GetLocationsListConnectorTypesEnum? connectorTypes = null,
                double? connectorMinPower = null,
                Models.GetLocationsListAuthorizationMethodsEnum? authorizationMethods = null,
                bool? withOperatorName = null,
                string evseId = null,
                string locationExternalId = null,
                string evseExternalId = null,
                int? pageNumber = null,
                int? perPage = null,
                string updatedSince = null)
            => CoreHelper.RunTask(GetLocationsListAsync(requestId, evseStatus, connectorTypes, connectorMinPower, authorizationMethods, withOperatorName, evseId, locationExternalId, evseExternalId, pageNumber, perPage, updatedSince));

        /// <summary>
        /// This API provides the list of all Shell Recharge locations. The list includes all Shell Recharge network and all locations available through our roaming partners.The end point provides flexible search criteria in order to get the list of Shell Recharge Network. The end point provides the details such as the exact location/address of the site along with the up-to-date status information of all the charging units in the site. .
        /// Supported Search Options.
        /// * Based on status of the Charging units. Eg : Available or Occupied.
        /// * Based on available connector types.
        /// * Based on minimum Power output (in kW) available.
        /// * Based on a specific charging unit ID (EVSE ID).
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="evseStatus">Optional parameter: Filter by Locations that have the given status.</param>
        /// <param name="connectorTypes">Optional parameter: Filter by Locations that have Connectors with the set of Connector Types.</param>
        /// <param name="connectorMinPower">Optional parameter: Filter by Locations that have a Connector with at least this power output (in kW).</param>
        /// <param name="authorizationMethods">Optional parameter: Filter by Locations that support the given Authorization Methods.</param>
        /// <param name="withOperatorName">Optional parameter: Return operator name in marker response object.</param>
        /// <param name="evseId">Optional parameter: optional Standard EVSE (Electric Vehicle Supply Equipment) Id identifier (ISO-IEC-15118).</param>
        /// <param name="locationExternalId">Optional parameter: Filter by Locations with the given externalId. (Unique Location externalID provided by Shell Recharge).</param>
        /// <param name="evseExternalId">Optional parameter: Filter by Locations that have an Evse with the given External Id. (Unique individual EVSE externalID provided by Shell Recharge).</param>
        /// <param name="pageNumber">Optional parameter: Restrict the response list by providing a specific set of page Number. Set perPage parameter also when pageNumber is used..</param>
        /// <param name="perPage">Optional parameter: Restrict the number of sites in reposne per page..</param>
        /// <param name="updatedSince">Optional parameter: ZonedDateTime as string.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.LocationResponeObject response from the API call.</returns>
        public async Task<List<Models.LocationResponeObject>> GetLocationsListAsync(
                string requestId,
                Models.GetLocationsListEvseStatusEnum? evseStatus = null,
                Models.GetLocationsListConnectorTypesEnum? connectorTypes = null,
                double? connectorMinPower = null,
                Models.GetLocationsListAuthorizationMethodsEnum? authorizationMethods = null,
                bool? withOperatorName = null,
                string evseId = null,
                string locationExternalId = null,
                string evseExternalId = null,
                int? pageNumber = null,
                int? perPage = null,
                string updatedSince = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.LocationResponeObject>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/locations/v1/ev")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Query(_query => _query.Setup("evseStatus", (evseStatus.HasValue) ? ApiHelper.JsonSerialize(evseStatus.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("connectorTypes", (connectorTypes.HasValue) ? ApiHelper.JsonSerialize(connectorTypes.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("connectorMinPower", connectorMinPower))
                      .Query(_query => _query.Setup("authorizationMethods", (authorizationMethods.HasValue) ? ApiHelper.JsonSerialize(authorizationMethods.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("withOperatorName", withOperatorName))
                      .Query(_query => _query.Setup("evseId", evseId))
                      .Query(_query => _query.Setup("locationExternalId", locationExternalId))
                      .Query(_query => _query.Setup("evseExternalId", evseExternalId))
                      .Query(_query => _query.Setup("pageNumber", pageNumber))
                      .Query(_query => _query.Setup("perPage", perPage))
                      .Query(_query => _query.Setup("updatedSince", updatedSince))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new BadRequestException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid authentication credentials for the target resource.", (_reason, _context) => new UnauthorizedException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Location Not Found", (_reason, _context) => new NotFoundException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API provides the details on a single Shell Recharge location. .
        /// The query for a single location is to be made using the Unique Internal identifier used to refer to this Location by Shell Recharge. (Uid from List of locations API).
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="id">Required parameter: Unique Uid of the location from List of locations API.</param>
        /// <returns>Returns the Models.LocationResponeObject response from the API call.</returns>
        public Models.LocationResponeObject GetLocationById(
                string requestId,
                string id)
            => CoreHelper.RunTask(GetLocationByIdAsync(requestId, id));

        /// <summary>
        /// This API provides the details on a single Shell Recharge location. .
        /// The query for a single location is to be made using the Unique Internal identifier used to refer to this Location by Shell Recharge. (Uid from List of locations API).
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="id">Required parameter: Unique Uid of the location from List of locations API.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LocationResponeObject response from the API call.</returns>
        public async Task<Models.LocationResponeObject> GetLocationByIdAsync(
                string requestId,
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LocationResponeObject>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/locations/v1/ev/{id}")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new BadRequestException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid authentication credentials for the target resource.", (_reason, _context) => new UnauthorizedException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Location Not Found", (_reason, _context) => new NotFoundException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API provides the list of all near by Shell Recharge locations based on the latitude and longitude provided in the request. .
        /// The list includes all Shell Recharge network and all sites available through our roaming partners.
        /// The end point provides the details such as the exact location/address of the site along with the up-to-date status information of all the charging units in the site. .
        /// Supported Search Options.
        /// * Based on latitude and longitude of the location. (Mandatory).
        /// * Based on status of the Charging units. Eg : Available or Occupied.
        /// * Based on available connector types.
        /// * Based on minimum Power output (in kW) available.
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="latitude">Required parameter: Latitude to get Shell Recharge Locations nearby.</param>
        /// <param name="longitude">Required parameter: Longitude to get Shell Recharge Locations nearby.</param>
        /// <param name="limit">Optional parameter: Maximum number of Locations to retrieve.</param>
        /// <param name="locationExternalId">Optional parameter: Filter by Locations with the given externalId Identifier as given by the Shell Recharge Operator, unique for that Operator.</param>
        /// <param name="evseId">Optional parameter: Filter by Locations that have an Evse with the given Evse Id.</param>
        /// <param name="evseExternalId">Optional parameter: Filter by Locations that have an Evse with the given External Id Identifier of the Evse as given by the Operator, unique for that Operator.</param>
        /// <param name="operatorName">Optional parameter: Filter by Locations that have the given operator.</param>
        /// <param name="evseStatus">Optional parameter: Filter by Locations that have the given status.</param>
        /// <param name="connectorTypes">Optional parameter: Filter by Locations that have Connectors with these Connector Types.</param>
        /// <param name="connectorMinPower">Optional parameter: Filter by Locations that have a Connector with at least this power output (in kW).</param>
        /// <param name="authorizationMethods">Optional parameter: Filter by Locations that support the given Authorization Methods.</param>
        /// <param name="withOperatorName">Optional parameter: Return operator name in marker object (only for marker type SingleChargePoint).</param>
        /// <param name="withMaxPower">Optional parameter: Return maximum power in kW across all locations grouped in this marker (disregarding availability).</param>
        /// <returns>Returns the Models.LocationResponeObject response from the API call.</returns>
        public Models.LocationResponeObject GetNearbyLocations(
                string requestId,
                double latitude,
                double longitude,
                double? limit = 25,
                string locationExternalId = null,
                string evseId = null,
                string evseExternalId = null,
                string operatorName = null,
                Models.GetNearbyLocationsEvseStatusEnum? evseStatus = null,
                Models.GetNearbyLocationsConnectorTypesEnum? connectorTypes = null,
                double? connectorMinPower = null,
                Models.GetNearbyLocationsAuthorizationMethodsEnum? authorizationMethods = null,
                bool? withOperatorName = null,
                bool? withMaxPower = null)
            => CoreHelper.RunTask(GetNearbyLocationsAsync(requestId, latitude, longitude, limit, locationExternalId, evseId, evseExternalId, operatorName, evseStatus, connectorTypes, connectorMinPower, authorizationMethods, withOperatorName, withMaxPower));

        /// <summary>
        /// This API provides the list of all near by Shell Recharge locations based on the latitude and longitude provided in the request. .
        /// The list includes all Shell Recharge network and all sites available through our roaming partners.
        /// The end point provides the details such as the exact location/address of the site along with the up-to-date status information of all the charging units in the site. .
        /// Supported Search Options.
        /// * Based on latitude and longitude of the location. (Mandatory).
        /// * Based on status of the Charging units. Eg : Available or Occupied.
        /// * Based on available connector types.
        /// * Based on minimum Power output (in kW) available.
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="latitude">Required parameter: Latitude to get Shell Recharge Locations nearby.</param>
        /// <param name="longitude">Required parameter: Longitude to get Shell Recharge Locations nearby.</param>
        /// <param name="limit">Optional parameter: Maximum number of Locations to retrieve.</param>
        /// <param name="locationExternalId">Optional parameter: Filter by Locations with the given externalId Identifier as given by the Shell Recharge Operator, unique for that Operator.</param>
        /// <param name="evseId">Optional parameter: Filter by Locations that have an Evse with the given Evse Id.</param>
        /// <param name="evseExternalId">Optional parameter: Filter by Locations that have an Evse with the given External Id Identifier of the Evse as given by the Operator, unique for that Operator.</param>
        /// <param name="operatorName">Optional parameter: Filter by Locations that have the given operator.</param>
        /// <param name="evseStatus">Optional parameter: Filter by Locations that have the given status.</param>
        /// <param name="connectorTypes">Optional parameter: Filter by Locations that have Connectors with these Connector Types.</param>
        /// <param name="connectorMinPower">Optional parameter: Filter by Locations that have a Connector with at least this power output (in kW).</param>
        /// <param name="authorizationMethods">Optional parameter: Filter by Locations that support the given Authorization Methods.</param>
        /// <param name="withOperatorName">Optional parameter: Return operator name in marker object (only for marker type SingleChargePoint).</param>
        /// <param name="withMaxPower">Optional parameter: Return maximum power in kW across all locations grouped in this marker (disregarding availability).</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LocationResponeObject response from the API call.</returns>
        public async Task<Models.LocationResponeObject> GetNearbyLocationsAsync(
                string requestId,
                double latitude,
                double longitude,
                double? limit = 25,
                string locationExternalId = null,
                string evseId = null,
                string evseExternalId = null,
                string operatorName = null,
                Models.GetNearbyLocationsEvseStatusEnum? evseStatus = null,
                Models.GetNearbyLocationsConnectorTypesEnum? connectorTypes = null,
                double? connectorMinPower = null,
                Models.GetNearbyLocationsAuthorizationMethodsEnum? authorizationMethods = null,
                bool? withOperatorName = null,
                bool? withMaxPower = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LocationResponeObject>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/locations/v1/ev/nearby")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Query(_query => _query.Setup("latitude", latitude))
                      .Query(_query => _query.Setup("longitude", longitude))
                      .Query(_query => _query.Setup("limit", (limit != null) ? limit : 25))
                      .Query(_query => _query.Setup("locationExternalId", locationExternalId))
                      .Query(_query => _query.Setup("evseId", evseId))
                      .Query(_query => _query.Setup("evseExternalId", evseExternalId))
                      .Query(_query => _query.Setup("operatorName", operatorName))
                      .Query(_query => _query.Setup("evseStatus", (evseStatus.HasValue) ? ApiHelper.JsonSerialize(evseStatus.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("connectorTypes", (connectorTypes.HasValue) ? ApiHelper.JsonSerialize(connectorTypes.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("connectorMinPower", connectorMinPower))
                      .Query(_query => _query.Setup("authorizationMethods", (authorizationMethods.HasValue) ? ApiHelper.JsonSerialize(authorizationMethods.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("withOperatorName", withOperatorName))
                      .Query(_query => _query.Setup("withMaxPower", withMaxPower))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new BadRequestException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid authentication credentials for the target resource.", (_reason, _context) => new UnauthorizedException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Location Not Found", (_reason, _context) => new NotFoundException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API, when given a set of bounds on the geographical front (East,West, North, South) will return a set of Markers that fall within the requested bounds. The API will automatically group locations at the same position on the map into one Marker. .
        /// The API also provide further search options to filter the result set. .
        ///   * Based on status of the Charging units. Eg : Available or Occupied.
        ///   * Based on available connector types.
        ///   * Based on minimum Power output (in kW) available.
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="west">Required parameter: Longitude of the western bound to get the Shell Recharge Locations.</param>
        /// <param name="south">Required parameter: Latitude of the southern bound to get the Shell Recharge Locations.</param>
        /// <param name="east">Required parameter: Longitude of the eastern bound to get the Shell Recharge Locations.</param>
        /// <param name="north">Required parameter: Latitude of the northern bound to get the Shell Recharge Locations.</param>
        /// <param name="zoom">Required parameter: Zoom level to show ex: (1: World, 5: Landmass/continent, 10: City, 15: Streets, 20: Buildings).</param>
        /// <param name="evseStatus">Optional parameter: Filter by Locations that have the given status.</param>
        /// <param name="connectorTypes">Optional parameter: Filter by Locations that have Connectors with the set of Connector Types.</param>
        /// <param name="connectorMinPower">Optional parameter: Filter by Locations that have a Connector with at least this power output (in kW).</param>
        /// <param name="authorizationMethods">Optional parameter: Filter by Locations that support the given Authorization Methods.</param>
        /// <param name="withOperatorName">Optional parameter: Return operator name in marker object (only for marker type SingleChargePoint).</param>
        /// <param name="withMaxPower">Optional parameter: Return maximum power in kW across all locations grouped in this marker (disregarding availability).</param>
        /// <param name="locationExternalId">Optional parameter: Filter by Locations with the given externalId. (Unique Location externalID provided by Shell Recharge).</param>
        /// <param name="evseId">Optional parameter: Filter by Locations that have an Evse with the given Evse Id.</param>
        /// <param name="evseExternalId">Optional parameter: Filter by Locations that have an Evse with the given External Id Identifier of the Evse as given by the Operator, unique for that Operator.</param>
        /// <param name="operatorName">Optional parameter: Filter by Locations that have the given operator.</param>
        /// <returns>Returns the List of MarkersResponse response from the API call.</returns>
        public List<MarkersResponse> GetMarkersList(
                string requestId,
                double west,
                double south,
                double east,
                double north,
                string zoom,
                Models.GetMarkersListEvseStatusEnum? evseStatus = null,
                Models.GetMarkersListConnectorTypesEnum? connectorTypes = null,
                double? connectorMinPower = null,
                Models.GetMarkersListAuthorizationMethodsEnum? authorizationMethods = null,
                bool? withOperatorName = null,
                bool? withMaxPower = null,
                string locationExternalId = null,
                string evseId = null,
                string evseExternalId = null,
                string operatorName = null)
            => CoreHelper.RunTask(GetMarkersListAsync(requestId, west, south, east, north, zoom, evseStatus, connectorTypes, connectorMinPower, authorizationMethods, withOperatorName, withMaxPower, locationExternalId, evseId, evseExternalId, operatorName));

        /// <summary>
        /// This API, when given a set of bounds on the geographical front (East,West, North, South) will return a set of Markers that fall within the requested bounds. The API will automatically group locations at the same position on the map into one Marker. .
        /// The API also provide further search options to filter the result set. .
        ///   * Based on status of the Charging units. Eg : Available or Occupied.
        ///   * Based on available connector types.
        ///   * Based on minimum Power output (in kW) available.
        /// </summary>
        /// <param name="requestId">Required parameter: A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request..</param>
        /// <param name="west">Required parameter: Longitude of the western bound to get the Shell Recharge Locations.</param>
        /// <param name="south">Required parameter: Latitude of the southern bound to get the Shell Recharge Locations.</param>
        /// <param name="east">Required parameter: Longitude of the eastern bound to get the Shell Recharge Locations.</param>
        /// <param name="north">Required parameter: Latitude of the northern bound to get the Shell Recharge Locations.</param>
        /// <param name="zoom">Required parameter: Zoom level to show ex: (1: World, 5: Landmass/continent, 10: City, 15: Streets, 20: Buildings).</param>
        /// <param name="evseStatus">Optional parameter: Filter by Locations that have the given status.</param>
        /// <param name="connectorTypes">Optional parameter: Filter by Locations that have Connectors with the set of Connector Types.</param>
        /// <param name="connectorMinPower">Optional parameter: Filter by Locations that have a Connector with at least this power output (in kW).</param>
        /// <param name="authorizationMethods">Optional parameter: Filter by Locations that support the given Authorization Methods.</param>
        /// <param name="withOperatorName">Optional parameter: Return operator name in marker object (only for marker type SingleChargePoint).</param>
        /// <param name="withMaxPower">Optional parameter: Return maximum power in kW across all locations grouped in this marker (disregarding availability).</param>
        /// <param name="locationExternalId">Optional parameter: Filter by Locations with the given externalId. (Unique Location externalID provided by Shell Recharge).</param>
        /// <param name="evseId">Optional parameter: Filter by Locations that have an Evse with the given Evse Id.</param>
        /// <param name="evseExternalId">Optional parameter: Filter by Locations that have an Evse with the given External Id Identifier of the Evse as given by the Operator, unique for that Operator.</param>
        /// <param name="operatorName">Optional parameter: Filter by Locations that have the given operator.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of MarkersResponse response from the API call.</returns>
        public async Task<List<MarkersResponse>> GetMarkersListAsync(
                string requestId,
                double west,
                double south,
                double east,
                double north,
                string zoom,
                Models.GetMarkersListEvseStatusEnum? evseStatus = null,
                Models.GetMarkersListConnectorTypesEnum? connectorTypes = null,
                double? connectorMinPower = null,
                Models.GetMarkersListAuthorizationMethodsEnum? authorizationMethods = null,
                bool? withOperatorName = null,
                bool? withMaxPower = null,
                string locationExternalId = null,
                string evseId = null,
                string evseExternalId = null,
                string operatorName = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<MarkersResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/locations/v1/ev/markers")
                  .WithAuth("BearerAuth")
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Query(_query => _query.Setup("west", west))
                      .Query(_query => _query.Setup("south", south))
                      .Query(_query => _query.Setup("east", east))
                      .Query(_query => _query.Setup("north", north))
                      .Query(_query => _query.Setup("zoom", zoom))
                      .Query(_query => _query.Setup("evseStatus", (evseStatus.HasValue) ? ApiHelper.JsonSerialize(evseStatus.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("connectorTypes", (connectorTypes.HasValue) ? ApiHelper.JsonSerialize(connectorTypes.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("connectorMinPower", connectorMinPower))
                      .Query(_query => _query.Setup("authorizationMethods", (authorizationMethods.HasValue) ? ApiHelper.JsonSerialize(authorizationMethods.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("withOperatorName", withOperatorName))
                      .Query(_query => _query.Setup("withMaxPower", withMaxPower))
                      .Query(_query => _query.Setup("locationExternalId", locationExternalId))
                      .Query(_query => _query.Setup("evseId", evseId))
                      .Query(_query => _query.Setup("evseExternalId", evseExternalId))
                      .Query(_query => _query.Setup("operatorName", operatorName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).", (_reason, _context) => new BadRequestException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid authentication credentials for the target resource.", (_reason, _context) => new UnauthorizedException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Location Not Found", (_reason, _context) => new NotFoundException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}