
# Single Location Marker Response

## Structure

`SingleLocationMarkerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `Guid?` | Optional | requestId is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. |
| `Status` | `string` | Optional | status of the API call |
| `Data` | [`List<LocationMarker>`](../../doc/models/containers/location-marker.md) | Optional | - |

## Example

```csharp
using ShellEV.Standard.Models;
using ShellEV.Standard.Models.Containers;
using System.Collections.Generic;

SingleLocationMarkerResponse singleLocationMarkerResponse = new SingleLocationMarkerResponse
{
    RequestId = new Guid("9d2dee33-7803-485a-a2b1-2c7538e597ee"),
    Status = "SUCCESS",
    Data = new List<LocationMarker>
    {
        LocationMarker.FromSingleLocationMarker(
            new SingleLocationMarker
            {
                MarkerType = "SingleLocation",
                UniqueKey = "uniqueKey2",
                Status = SingleLocationMarkerStatusEnum.Available,
                Coordinates = new Coordinates1
                {
                    Latitude = 39.14,
                    Longitude = 36.94,
                },
                EvseCount = 26.34,
                MaxPower = 241.78,
            }
        ),
        LocationMarker.FromSingleLocationMarker(
            new SingleLocationMarker
            {
                MarkerType = "SingleLocation",
                UniqueKey = "uniqueKey2",
                Status = SingleLocationMarkerStatusEnum.Available,
                Coordinates = new Coordinates1
                {
                    Latitude = 39.14,
                    Longitude = 36.94,
                },
                EvseCount = 26.34,
                MaxPower = 241.78,
            }
        ),
        LocationMarker.FromSingleLocationMarker(
            new SingleLocationMarker
            {
                MarkerType = "SingleLocation",
                UniqueKey = "uniqueKey2",
                Status = SingleLocationMarkerStatusEnum.Available,
                Coordinates = new Coordinates1
                {
                    Latitude = 39.14,
                    Longitude = 36.94,
                },
                EvseCount = 26.34,
                MaxPower = 241.78,
            }
        ),
    },
};
```

