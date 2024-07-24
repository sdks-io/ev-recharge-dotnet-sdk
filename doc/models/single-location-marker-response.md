
# Single Location Marker Response

## Structure

`SingleLocationMarkerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `Guid?` | Optional | requestId is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. |
| `Status` | `string` | Optional | status of the API call |
| `Data` | [`List<LocationMarker>`](../../doc/models/containers/location-marker.md) | Optional | - |

## Example (as JSON)

```json
{
  "requestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "status": "SUCCESS",
  "data": [
    {
      "markerType": "SingleLocation",
      "uniqueKey": "uniqueKey2",
      "status": "Available",
      "coordinates": {
        "latitude": 39.14,
        "longitude": 36.94
      },
      "evseCount": 26.34,
      "maxPower": 241.78
    },
    {
      "markerType": "SingleLocation",
      "uniqueKey": "uniqueKey2",
      "status": "Available",
      "coordinates": {
        "latitude": 39.14,
        "longitude": 36.94
      },
      "evseCount": 26.34,
      "maxPower": 241.78
    },
    {
      "markerType": "SingleLocation",
      "uniqueKey": "uniqueKey2",
      "status": "Available",
      "coordinates": {
        "latitude": 39.14,
        "longitude": 36.94
      },
      "evseCount": 26.34,
      "maxPower": 241.78
    }
  ]
}
```

