
# Single Location Marker Response V2

## Structure

`SingleLocationMarkerResponseV2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `Guid?` | Optional | requestId is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. |
| `Status` | `string` | Optional | status of the API call |
| `Data` | [`List<LocationMarkerV2>`](../../doc/models/containers/location-marker-v2.md) | Optional | - |

## Example

```csharp
using ShellEV.Standard.Models;
using ShellEV.Standard.Models.Containers;
using System.Collections.Generic;

SingleLocationMarkerResponseV2 singleLocationMarkerResponseV2 = new SingleLocationMarkerResponseV2
{
    RequestId = new Guid("9d2dee33-7803-485a-a2b1-2c7538e597ee"),
    Status = "SUCCESS",
    Data = new List<LocationMarkerV2>
    {
        LocationMarkerV2.FromSingleLocationMarkerV2(
            new SingleLocationMarkerV2
            {
                MarkerType = "SingleLocation",
                Status = SingleLocationMarkerStatusEnum.Unavailable,
                Coordinates = new Coordinates
                {
                    Latitude = 39.14,
                    Longitude = 36.94,
                },
                EvseCount = 223.04,
                MaxPower = 45.08,
                LocationCount = 62.98,
            }
        ),
    },
};
```

