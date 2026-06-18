
# Single Location Marker

A Marker is a place on the map that represent a single Location

## Structure

`SingleLocationMarker`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MarkerType` | `string` | Required | Identifies the marker type. If it’s a `SingleLocationMarker`, then the value is `SingleLocation` |
| `UniqueKey` | `string` | Optional | Uniquely identifies the marker object |
| `Status` | [`SingleLocationMarkerStatusEnum?`](../../doc/models/single-location-marker-status-enum.md) | Optional | Minimum of all status values in the Marker, e.g. if at least one Evse in the Marker is available, the value will be available |
| `Coordinates` | [`Coordinates1`](../../doc/models/coordinates-1.md) | Optional | - |
| `EvseCount` | `double?` | Optional | Total number of Evse units in Locations that this Marker represents |
| `MaxPower` | `double?` | Optional | Maximum power in kW across all locations grouped in this marker (disregarding availability) |
| `GeoHash` | `string` | Optional | GeoHash of marker coordinates |
| `LocationUid` | `double?` | Optional | Unique ID of the Location this Marker represents |
| `AuthorizationMethods` | [`List<SingleLocationMarkerAuthorizationMethodsItemsEnum>`](../../doc/models/single-location-marker-authorization-methods-items-enum.md) | Optional | Methods that can be used to Authorize sessions on this EVSE |
| `OperatorId` | `string` | Optional | Unique Id of the operator |

## Example

```csharp
using ShellEV.Standard.Models;

SingleLocationMarker singleLocationMarker = new SingleLocationMarker
{
    MarkerType = "SingleLocation",
    UniqueKey = "2057411_1",
    Status = SingleLocationMarkerStatusEnum.Available,
    Coordinates = new Coordinates1
    {
        Latitude = 39.14,
        Longitude = 36.94,
    },
    EvseCount = 12,
    MaxPower = 42,
    GeoHash = "sx",
    LocationUid = 2057411,
    OperatorId = "AT-HTB",
};
```

