# Locations

APIs for Shell Recharge Locations

```csharp
LocationsController locationsController = client.LocationsController;
```

## Class Name

`LocationsController`

## Methods

* [Get EV Locations](../../doc/controllers/locations.md#get-ev-locations)
* [Ev Locations by ID](../../doc/controllers/locations.md#ev-locations-by-id)
* [Nearby Locations](../../doc/controllers/locations.md#nearby-locations)
* [Locations Markers](../../doc/controllers/locations.md#locations-markers)


# Get EV Locations

This API provides the list of all Shell Recharge locations. The list includes all Shell Recharge network and all locations available through our roaming partners. The end point provides flexible search criteria in order to get the list of Shell Recharge Network. The end point provides the details such as the exact location/address of the site along with the up-to-date status information of all the charging units in the site.

Supported Search Options

* Based on status of the Charging units. Eg : Available or Occupied
* Based on available connector types.
* Based on minimum Power output (in kW) available
* Based on a specific charging unit ID (EVSE ID)

```csharp
GetEVLocationsAsync(
    Guid requestId,
    Models.GetEVLocationsEvseStatusEnum? evseStatus = null,
    Models.GetEVLocationsConnectorTypesEnum? connectorTypes = null,
    double? connectorMinPower = null,
    Models.GetEVLocationsAuthorizationMethodsEnum? authorizationMethods = null,
    bool? withOperatorName = null,
    string evseId = null,
    string locationExternalId = null,
    string evseExternalId = null,
    int? pageNumber = null,
    int? perPage = null,
    string updatedSince = null,
    List<string> country = null,
    List<string> excludeCountry = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `Guid` | Header, Required | RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br> |
| `evseStatus` | [`GetEVLocationsEvseStatusEnum?`](../../doc/models/get-ev-locations-evse-status-enum.md) | Query, Optional | Filter by Locations that have the given status |
| `connectorTypes` | [`GetEVLocationsConnectorTypesEnum?`](../../doc/models/get-ev-locations-connector-types-enum.md) | Query, Optional | Filter by Locations that have Connectors with the set of Connector Types |
| `connectorMinPower` | `double?` | Query, Optional | Filter by Locations that have a Connector with at least this power output (in kW) |
| `authorizationMethods` | [`GetEVLocationsAuthorizationMethodsEnum?`](../../doc/models/get-ev-locations-authorization-methods-enum.md) | Query, Optional | Filter by Locations that support the given Authorization Methods |
| `withOperatorName` | `bool?` | Query, Optional | Return operator name in marker response object |
| `evseId` | `string` | Query, Optional | optional Standard EVSE (Electric Vehicle Supply Equipment) Id identifier (ISO-IEC-15118) |
| `locationExternalId` | `string` | Query, Optional | Filter by Locations with the given externalId. (Unique Location externalID provided by Shell Recharge) |
| `evseExternalId` | `string` | Query, Optional | Filter by Locations that have an Evse with the given External Id. (Unique individual EVSE externalID provided by Shell Recharge) |
| `pageNumber` | `int?` | Query, Optional | Restrict the response list by providing a specific set of page Number. Set perPage parameter also when page Number is used.<br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | Restrict the number of sites in response per page.<br>**Constraints**: `<= 500` |
| `updatedSince` | `string` | Query, Optional | ZonedDateTime as string |
| `country` | `List<string>` | Query, Optional | Filter by Locations that are at least in one of the given countries (specified using ISO 3166-1 alpha-3 codes) |
| `excludeCountry` | `List<string>` | Query, Optional | Filter by Locations that are not in one of the given countries (specified using ISO 3166-1 alpha-3 codes) |

## Response Type

[`Task<Models.Response>`](../../doc/models/response.md)

## Example Usage

```csharp
Guid requestId = new Guid("123e4567-e89b-12d3-a456-426614174000");
string evseId = "NL*TNM*E01000401*0";
List<string> country = new List<string>
{
    "NED",
};

List<string> excludeCountry = new List<string>
{
    "NED",
};

try
{
    Response result = await locationsController.GetEVLocationsAsync(
        requestId,
        null,
        null,
        null,
        null,
        null,
        evseId,
        null,
        null,
        null,
        null,
        null,
        country,
        excludeCountry
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
| 429 | The Request reached maximum allocated rate limit | [`TooManyRequestsException`](../../doc/models/too-many-requests-exception.md) |
| 500 | Internal Server error | [`InternalServerErrorException`](../../doc/models/internal-server-error-exception.md) |
| 503 | Service unavailable | [`ServiceunavailableException`](../../doc/models/serviceunavailable-exception.md) |


# Ev Locations by ID

This API provides the details on a single Shell Recharge location.
The query for a single location is to be made using the Unique Internal identifier used to refer to this Location by Shell Recharge. (Uid from List of locations API)

```csharp
EvLocationsByIDAsync(
    Guid requestId,
    string id,
    string providerId = null,
    string since = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `Guid` | Header, Required | RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br> |
| `id` | `string` | Template, Required | Unique Uid of the location from List of locations API |
| `providerId` | `string` | Query, Optional | The provider id that you wish to see locations and tariffs for |
| `since` | `string` | Query, Optional | to get the locations modified after a date |

## Response Type

[`Task<Models.Response>`](../../doc/models/response.md)

## Example Usage

```csharp
Guid requestId = new Guid("123e4567-e89b-12d3-a456-426614174000");
string id = "id0";
try
{
    Response result = await locationsController.EvLocationsByIDAsync(
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
| 429 | The Request reached maximum allocated rate limit | [`TooManyRequestsException`](../../doc/models/too-many-requests-exception.md) |
| 500 | Internal Server error | [`InternalServerErrorException`](../../doc/models/internal-server-error-exception.md) |
| 503 | Service unavailable | [`ServiceunavailableException`](../../doc/models/serviceunavailable-exception.md) |


# Nearby Locations

This API provides the list of all nearby Shell Recharge locations based on the latitude and longitude provided in the request.
The list includes all Shell Recharge network and all sites available through our roaming partners.
The end point provides the details such as the exact location/address of the site along with the up-to-date status information of all the charging units in the site.

Supported Search Options

* Based on latitude and longitude of the location. (Mandatory)
* Based on status of the Charging units. Eg : Available or Occupied
* Based on available connector types.
* Based on minimum Power output (in kW) available

```csharp
NearbyLocationsAsync(
    Guid requestId,
    double latitude,
    double longitude,
    double? limit = 25,
    string locationExternalId = null,
    string evseId = null,
    string evseExternalId = null,
    string operatorName = null,
    Models.GetEVLocationsEvseStatusEnum? evseStatus = null,
    Models.NearbyLocationsConnectorTypesEnum? connectorTypes = null,
    double? connectorMinPower = null,
    Models.GetEVLocationsAuthorizationMethodsEnum? authorizationMethods = null,
    bool? withOperatorName = null,
    bool? withMaxPower = null,
    List<string> country = null,
    List<string> excludeCountry = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `Guid` | Header, Required | RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br> |
| `latitude` | `double` | Query, Required | Latitude to get Shell Recharge Locations nearby<br>**Constraints**: `>= -90`, `<= 90` |
| `longitude` | `double` | Query, Required | Longitude to get Shell Recharge Locations nearby<br>**Constraints**: `>= -180`, `<= 180` |
| `limit` | `double?` | Query, Optional | Maximum number of Locations to retrieve<br>**Default**: `25`<br>**Constraints**: `<= 100` |
| `locationExternalId` | `string` | Query, Optional | Filter by Locations with the given externalId Identifier as given by the Shell Recharge Operator, unique for that Operator |
| `evseId` | `string` | Query, Optional | Filter by Locations that have an Evse with the given Evse Id |
| `evseExternalId` | `string` | Query, Optional | Filter by Locations that have an Evse with the given External Id Identifier of the Evse as given by the Operator, unique for that Operator |
| `operatorName` | `string` | Query, Optional | Filter by Locations that have the given operator |
| `evseStatus` | [`GetEVLocationsEvseStatusEnum?`](../../doc/models/get-ev-locations-evse-status-enum.md) | Query, Optional | Filter by Locations that have the given status |
| `connectorTypes` | [`NearbyLocationsConnectorTypesEnum?`](../../doc/models/nearby-locations-connector-types-enum.md) | Query, Optional | Filter by Locations that have Connectors with these Connector Types |
| `connectorMinPower` | `double?` | Query, Optional | Filter by Locations that have a Connector with at least this power output (in kW) |
| `authorizationMethods` | [`GetEVLocationsAuthorizationMethodsEnum?`](../../doc/models/get-ev-locations-authorization-methods-enum.md) | Query, Optional | Filter by Locations that support the given Authorization Methods |
| `withOperatorName` | `bool?` | Query, Optional | Return operator name in marker object (only for marker type Single ChargePoint) |
| `withMaxPower` | `bool?` | Query, Optional | Return maximum power in kW across all locations grouped in this marker (disregarding availability) |
| `country` | `List<string>` | Query, Optional | Filter by Locations that are at least in one of the given countries (specified using ISO 3166-1 alpha-3 codes) |
| `excludeCountry` | `List<string>` | Query, Optional | Filter by Locations that are not in one of the given countries (specified using ISO 3166-1 alpha-3 codes) |

## Response Type

[`Task<Models.Response>`](../../doc/models/response.md)

## Example Usage

```csharp
Guid requestId = new Guid("123e4567-e89b-12d3-a456-426614174000");
double latitude = 65.76;
double longitude = 188.04;
double? limit = 25;
List<string> country = new List<string>
{
    "NED",
};

List<string> excludeCountry = new List<string>
{
    "NED",
};

try
{
    Response result = await locationsController.NearbyLocationsAsync(
        requestId,
        latitude,
        longitude,
        limit,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        country,
        excludeCountry
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
| 429 | The Request reached maximum allocated rate limit | [`TooManyRequestsException`](../../doc/models/too-many-requests-exception.md) |
| 500 | Internal Server error | [`InternalServerErrorException`](../../doc/models/internal-server-error-exception.md) |
| 503 | Service unavailable | [`ServiceunavailableException`](../../doc/models/serviceunavailable-exception.md) |


# Locations Markers

This API, when given a set of bounds on the geographical front (East,West, North, South) will return a set of Markers that fall within the requested bounds. The API will automatically group locations at the same position on the map into one Marker.

The API also provide further search options to filter the result set.

* Based on status of the Charging units. Eg : Available or Occupied
* Based on available connector types.
* Based on minimum Power output (in kW) available

```csharp
LocationsMarkersAsync(
    Guid requestId,
    double west,
    double south,
    double east,
    double north,
    string zoom,
    Models.GetEVLocationsEvseStatusEnum? evseStatus = null,
    Models.GetEVLocationsConnectorTypesEnum? connectorTypes = null,
    double? connectorMinPower = null,
    Models.GetEVLocationsAuthorizationMethodsEnum? authorizationMethods = null,
    bool? withOperatorName = null,
    bool? withMaxPower = null,
    string locationExternalId = null,
    string evseId = null,
    string evseExternalId = null,
    string operatorName = null,
    List<string> country = null,
    List<string> excludeCountry = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `Guid` | Header, Required | RequestId must be unique identifier value that can be used by the consumer to correlate each request /response .<br>Format.<br> Its canonical textual representation, the 16 octets of a UUID are represented as 32 hexadecimal (base-16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 hexadecimal characters and 4 hyphens) <br> |
| `west` | `double` | Query, Required | Longitude of the western bound to get the Shell Recharge Locations<br>**Constraints**: `>= -180`, `<= 180` |
| `south` | `double` | Query, Required | Latitude of the southern bound to get the Shell Recharge Locations<br>**Constraints**: `>= -90`, `<= 90` |
| `east` | `double` | Query, Required | Longitude of the eastern bound to get the Shell Recharge Locations<br>**Constraints**: `>= -180`, `<= 180` |
| `north` | `double` | Query, Required | Latitude of the northern bound to get the Shell Recharge Locations<br>**Constraints**: `>= -90`, `<= 90` |
| `zoom` | `string` | Query, Required | Zoom level to show ex: (1: World, 5: Landmass/continent, 10: City, 15: Streets, 20: Buildings) |
| `evseStatus` | [`GetEVLocationsEvseStatusEnum?`](../../doc/models/get-ev-locations-evse-status-enum.md) | Query, Optional | Filter by Locations that have the given status |
| `connectorTypes` | [`GetEVLocationsConnectorTypesEnum?`](../../doc/models/get-ev-locations-connector-types-enum.md) | Query, Optional | Filter by Locations that have Connectors with the set of Connector Types |
| `connectorMinPower` | `double?` | Query, Optional | Filter by Locations that have a Connector with at least this power output (in kW) |
| `authorizationMethods` | [`GetEVLocationsAuthorizationMethodsEnum?`](../../doc/models/get-ev-locations-authorization-methods-enum.md) | Query, Optional | Filter by Locations that support the given Authorization Methods |
| `withOperatorName` | `bool?` | Query, Optional | Return operator name in marker object (only for marker type SingleChargePoint) |
| `withMaxPower` | `bool?` | Query, Optional | Return maximum power in kW across all locations grouped in this marker (disregarding availability) |
| `locationExternalId` | `string` | Query, Optional | Filter by Locations with the given externalId. (Unique Location externalID provided by Shell Recharge) |
| `evseId` | `string` | Query, Optional | Filter by Locations that have an Evse with the given Evse Id |
| `evseExternalId` | `string` | Query, Optional | Filter by Locations that have an Evse with the given External Id Identifier of the Evse as given by the Operator, unique for that Operator |
| `operatorName` | `string` | Query, Optional | Filter by Locations that have the given operator |
| `country` | `List<string>` | Query, Optional | Filter by Locations that are at least in one of the given countries (specified using ISO 3166-1 alpha-3 codes) |
| `excludeCountry` | `List<string>` | Query, Optional | Filter by Locations that are not in one of the given countries (specified using ISO 3166-1 alpha-3 codes) |

## Response Type

[`Task<Models.SingleLocationMarkerResponse>`](../../doc/models/single-location-marker-response.md)

## Example Usage

```csharp
Guid requestId = new Guid("123e4567-e89b-12d3-a456-426614174000");
double west = 152.84;
double south = 13.76;
double east = 16.36;
double north = 73.98;
string zoom = "zoom0";
List<string> country = new List<string>
{
    "NED",
};

List<string> excludeCountry = new List<string>
{
    "NED",
};

try
{
    SingleLocationMarkerResponse result = await locationsController.LocationsMarkersAsync(
        requestId,
        west,
        south,
        east,
        north,
        zoom,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        country,
        excludeCountry
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
| 429 | The Request reached maximum allocated rate limit | [`TooManyRequestsException`](../../doc/models/too-many-requests-exception.md) |
| 500 | Internal server error | [`InternalServerErrorException`](../../doc/models/internal-server-error-exception.md) |
| 503 | Service unavailable | [`ServiceunavailableException`](../../doc/models/serviceunavailable-exception.md) |

