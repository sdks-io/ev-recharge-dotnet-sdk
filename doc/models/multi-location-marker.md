
# Multi Location Marker

A Marker is a place on the map that represent multiple Locations at the same spot

## Structure

`MultiLocationMarker`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MarkerType` | `string` | Required | Identifies the marker type. If it's a `MultiLocationMarker`, then the value is `MultiLocation` |
| `UniqueKey` | `string` | Optional | Uniquely identifies the marker object |
| `Coordinates` | [`Coordinates`](../../doc/models/coordinates.md) | Optional | Coordinates of the Shell Recharge Site Location |
| `LocationCount` | `double?` | Optional | Number of Locations that this Marker represents in the given set of bounds |
| `EvseCount` | `double?` | Optional | Total number of Evses in Locations that this Marker represents |
| `MaxPower` | `double?` | Optional | Maximum power in kW across all locations grouped in this marker (disregarding availability) |
| `GeoHash` | `string` | Optional | GeoHash of marker coordinates |

## Example (as JSON)

```json
{
  "markerType": "MultiLocation",
  "uniqueKey": "2060319_6",
  "locationCount": 6.0,
  "evseCount": 10.0,
  "maxPower": 42.0,
  "geoHash": "sx",
  "coordinates": {
    "latitude": 39.14,
    "longitude": 36.94
  }
}
```

