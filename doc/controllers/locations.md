# Locations

APIs for Shell Recharge Locations

```csharp
LocationsController locationsController = client.LocationsController;
```

## Class Name

`LocationsController`

## Methods

* [Get Locations List](../../doc/controllers/locations.md#get-locations-list)
* [Get Location by Id](../../doc/controllers/locations.md#get-location-by-id)
* [Get Nearby Locations](../../doc/controllers/locations.md#get-nearby-locations)
* [Get Markers List](../../doc/controllers/locations.md#get-markers-list)


# Get Locations List

This API provides the list of all Shell Recharge locations. The list includes all Shell Recharge network and all locations available through our roaming partners.The end point provides flexible search criteria in order to get the list of Shell Recharge Network. The end point provides the details such as the exact location/address of the site along with the up-to-date status information of all the charging units in the site.

Supported Search Options

* Based on status of the Charging units. Eg : Available or Occupied
* Based on available connector types.
* Based on minimum Power output (in kW) available
* Based on a specific charging unit ID (EVSE ID)

```csharp
GetLocationsListAsync(
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
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request. |
| `evseStatus` | [`GetLocationsListEvseStatusEnum?`](../../doc/models/get-locations-list-evse-status-enum.md) | Query, Optional | Filter by Locations that have the given status |
| `connectorTypes` | [`GetLocationsListConnectorTypesEnum?`](../../doc/models/get-locations-list-connector-types-enum.md) | Query, Optional | Filter by Locations that have Connectors with the set of Connector Types |
| `connectorMinPower` | `double?` | Query, Optional | Filter by Locations that have a Connector with at least this power output (in kW) |
| `authorizationMethods` | [`GetLocationsListAuthorizationMethodsEnum?`](../../doc/models/get-locations-list-authorization-methods-enum.md) | Query, Optional | Filter by Locations that support the given Authorization Methods |
| `withOperatorName` | `bool?` | Query, Optional | Return operator name in marker response object |
| `evseId` | `string` | Query, Optional | optional Standard EVSE (Electric Vehicle Supply Equipment) Id identifier (ISO-IEC-15118) |
| `locationExternalId` | `string` | Query, Optional | Filter by Locations with the given externalId. (Unique Location externalID provided by Shell Recharge) |
| `evseExternalId` | `string` | Query, Optional | Filter by Locations that have an Evse with the given External Id. (Unique individual EVSE externalID provided by Shell Recharge) |
| `pageNumber` | `int?` | Query, Optional | Restrict the response list by providing a specific set of page Number. Set perPage parameter also when pageNumber is used. |
| `perPage` | `int?` | Query, Optional | Restrict the number of sites in reposne per page. |
| `updatedSince` | `string` | Query, Optional | ZonedDateTime as string |

## Response Type

[`Task<List<Models.LocationResponeObject>>`](../../doc/models/location-respone-object.md)

## Example Usage

```csharp
string requestId = "RequestId8";
string evseId = "NL*TNM*E01000401*0";
try
{
    List<LocationResponeObject> result = await locationsController.GetLocationsListAsync(
        requestId,
        null,
        null,
        null,
        null,
        null,
        evseId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`BadRequestException`](../../doc/models/bad-request-exception.md) |
| 401 | The request has not been applied because it lacks valid authentication credentials for the target resource. | [`UnauthorizedException`](../../doc/models/unauthorized-exception.md) |
| 404 | Location Not Found | [`NotFoundException`](../../doc/models/not-found-exception.md) |


# Get Location by Id

This API provides the details on a single Shell Recharge location.
The query for a single location is to be made using the Unique Internal identifier used to refer to this Location by Shell Recharge. (Uid from List of locations API)

```csharp
GetLocationByIdAsync(
    string requestId,
    string id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request. |
| `id` | `string` | Template, Required | Unique Uid of the location from List of locations API |

## Response Type

[`Task<Models.LocationResponeObject>`](../../doc/models/location-respone-object.md)

## Example Usage

```csharp
string requestId = "RequestId8";
string id = "id0";
try
{
    LocationResponeObject result = await locationsController.GetLocationByIdAsync(
        requestId,
        id
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`BadRequestException`](../../doc/models/bad-request-exception.md) |
| 401 | The request has not been applied because it lacks valid authentication credentials for the target resource. | [`UnauthorizedException`](../../doc/models/unauthorized-exception.md) |
| 404 | Location Not Found | [`NotFoundException`](../../doc/models/not-found-exception.md) |


# Get Nearby Locations

This API provides the list of all near by Shell Recharge locations based on the latitude and longitude provided in the request.
The list includes all Shell Recharge network and all sites available through our roaming partners.
The end point provides the details such as the exact location/address of the site along with the up-to-date status information of all the charging units in the site.

Supported Search Options

* Based on latitude and longitude of the location. (Mandatory)
* Based on status of the Charging units. Eg : Available or Occupied
* Based on available connector types.
* Based on minimum Power output (in kW) available

```csharp
GetNearbyLocationsAsync(
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
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request. |
| `latitude` | `double` | Query, Required | Latitude to get Shell Recharge Locations nearby |
| `longitude` | `double` | Query, Required | Longitude to get Shell Recharge Locations nearby |
| `limit` | `double?` | Query, Optional | Maximum number of Locations to retrieve |
| `locationExternalId` | `string` | Query, Optional | Filter by Locations with the given externalId Identifier as given by the Shell Recharge Operator, unique for that Operator |
| `evseId` | `string` | Query, Optional | Filter by Locations that have an Evse with the given Evse Id |
| `evseExternalId` | `string` | Query, Optional | Filter by Locations that have an Evse with the given External Id Identifier of the Evse as given by the Operator, unique for that Operator |
| `operatorName` | `string` | Query, Optional | Filter by Locations that have the given operator |
| `evseStatus` | [`GetNearbyLocationsEvseStatusEnum?`](../../doc/models/get-nearby-locations-evse-status-enum.md) | Query, Optional | Filter by Locations that have the given status |
| `connectorTypes` | [`GetNearbyLocationsConnectorTypesEnum?`](../../doc/models/get-nearby-locations-connector-types-enum.md) | Query, Optional | Filter by Locations that have Connectors with these Connector Types |
| `connectorMinPower` | `double?` | Query, Optional | Filter by Locations that have a Connector with at least this power output (in kW) |
| `authorizationMethods` | [`GetNearbyLocationsAuthorizationMethodsEnum?`](../../doc/models/get-nearby-locations-authorization-methods-enum.md) | Query, Optional | Filter by Locations that support the given Authorization Methods |
| `withOperatorName` | `bool?` | Query, Optional | Return operator name in marker object (only for marker type SingleChargePoint) |
| `withMaxPower` | `bool?` | Query, Optional | Return maximum power in kW across all locations grouped in this marker (disregarding availability) |

## Response Type

[`Task<Models.LocationResponeObject>`](../../doc/models/location-respone-object.md)

## Example Usage

```csharp
string requestId = "RequestId8";
double latitude = 65.76;
double longitude = 188.04;
double? limit = 25;
try
{
    LocationResponeObject result = await locationsController.GetNearbyLocationsAsync(
        requestId,
        latitude,
        longitude,
        limit
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`BadRequestException`](../../doc/models/bad-request-exception.md) |
| 401 | The request has not been applied because it lacks valid authentication credentials for the target resource. | [`UnauthorizedException`](../../doc/models/unauthorized-exception.md) |
| 404 | Location Not Found | [`NotFoundException`](../../doc/models/not-found-exception.md) |


# Get Markers List

This API, when given a set of bounds on the geographical front (East,West, North, South) will return a set of Markers that fall within the requested bounds. The API will automatically group locations at the same position on the map into one Marker.

The API also provide further search options to filter the result set.

* Based on status of the Charging units. Eg : Available or Occupied
* Based on available connector types.
* Based on minimum Power output (in kW) available

```csharp
GetMarkersListAsync(
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
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request. |
| `west` | `double` | Query, Required | Longitude of the western bound to get the Shell Recharge Locations |
| `south` | `double` | Query, Required | Latitude of the southern bound to get the Shell Recharge Locations |
| `east` | `double` | Query, Required | Longitude of the eastern bound to get the Shell Recharge Locations |
| `north` | `double` | Query, Required | Latitude of the northern bound to get the Shell Recharge Locations |
| `zoom` | `string` | Query, Required | Zoom level to show ex: (1: World, 5: Landmass/continent, 10: City, 15: Streets, 20: Buildings) |
| `evseStatus` | [`GetMarkersListEvseStatusEnum?`](../../doc/models/get-markers-list-evse-status-enum.md) | Query, Optional | Filter by Locations that have the given status |
| `connectorTypes` | [`GetMarkersListConnectorTypesEnum?`](../../doc/models/get-markers-list-connector-types-enum.md) | Query, Optional | Filter by Locations that have Connectors with the set of Connector Types |
| `connectorMinPower` | `double?` | Query, Optional | Filter by Locations that have a Connector with at least this power output (in kW) |
| `authorizationMethods` | [`GetMarkersListAuthorizationMethodsEnum?`](../../doc/models/get-markers-list-authorization-methods-enum.md) | Query, Optional | Filter by Locations that support the given Authorization Methods |
| `withOperatorName` | `bool?` | Query, Optional | Return operator name in marker object (only for marker type SingleChargePoint) |
| `withMaxPower` | `bool?` | Query, Optional | Return maximum power in kW across all locations grouped in this marker (disregarding availability) |
| `locationExternalId` | `string` | Query, Optional | Filter by Locations with the given externalId. (Unique Location externalID provided by Shell Recharge) |
| `evseId` | `string` | Query, Optional | Filter by Locations that have an Evse with the given Evse Id |
| `evseExternalId` | `string` | Query, Optional | Filter by Locations that have an Evse with the given External Id Identifier of the Evse as given by the Operator, unique for that Operator |
| `operatorName` | `string` | Query, Optional | Filter by Locations that have the given operator |

## Response Type

[`Task<List<MarkersResponse>>`](../../doc/models/containers/markers-response.md)

## Example Usage

```csharp
string requestId = "RequestId8";
double west = 152.84;
double south = 13.76;
double east = 16.36;
double north = 73.98;
string zoom = "zoom0";
try
{
    List<MarkersResponse> result = await locationsController.GetMarkersListAsync(
        requestId,
        west,
        south,
        east,
        north,
        zoom
    );
    result.ForEach(item => item.Match<VoidType>(
        singleLocationMarker: @case =>
        {
            Console.WriteLine(@case);
            return null;
        },
        multiLocationMarker: @case =>
        {
            Console.WriteLine(@case);
            return null;
        }));
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`BadRequestException`](../../doc/models/bad-request-exception.md) |
| 401 | The request has not been applied because it lacks valid authentication credentials for the target resource. | [`UnauthorizedException`](../../doc/models/unauthorized-exception.md) |
| 404 | Location Not Found | [`NotFoundException`](../../doc/models/not-found-exception.md) |

