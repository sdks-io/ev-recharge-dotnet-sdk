
# Multi Location Marker

A Marker is a place on the map that represent multiple Locations at the same spot

## Structure

`MultiLocationMarker`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MarkerType` | `string` | Required | Identifies the marker type. If it's a `MultiLocationMarker`, then the value is `MultiLocation` |
| `UniqueKey` | `string` | Optional | Uniquely identifies the marker object |
| `Coordinates` | [`Coordinates1`](../../doc/models/coordinates-1.md) | Optional | - |
| `LocationCount` | `double?` | Optional | Number of Locations that this Marker represents in the given set of bounds |
| `EvseCount` | `double?` | Optional | Total number of Evses in Locations that this Marker represents |
| `MaxPower` | `double?` | Optional | Maximum power in kW across all locations grouped in this marker (disregarding availability) |
| `GeoHash` | `string` | Optional | GeoHash of marker coordinates |

## Example

```csharp
using ShellEV.Standard.Models;

MultiLocationMarker multiLocationMarker = new MultiLocationMarker
{
    MarkerType = "MultiLocation",
    UniqueKey = "2060319_6",
    Coordinates = new Coordinates1
    {
        Latitude = 39.14,
        Longitude = 36.94,
    },
    LocationCount = 6,
    EvseCount = 10,
    MaxPower = 42,
    GeoHash = "sx",
};
```

