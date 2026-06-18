
# Response V2

## Structure

`ResponseV2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `Guid?` | Optional | requestId is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. |
| `Status` | `string` | Optional | status of the API call |
| `Data` | [`List<LocationResponeObjectV2>`](../../doc/models/location-respone-object-v2.md) | Optional | API Response |

## Example

```csharp
using ShellEV.Standard.Models;
using System.Collections.Generic;

ResponseV2 responseV2 = new ResponseV2
{
    RequestId = new Guid("9d2dee33-7803-485a-a2b1-2c7538e597ee"),
    Status = "SUCCESS",
    Data = new List<LocationResponeObjectV2>
    {
        new LocationResponeObjectV2
        {
            Uid = "uid0",
            ExternalId = "externalId6",
            Coordinates = new Coordinates
            {
                Latitude = 39.14,
                Longitude = 36.94,
            },
            OperatorName = "operatorName0",
            Address = new Address
            {
                StreetAndNumber = "streetAndNumber2",
                PostalCode = "postalCode8",
                City = "city6",
                Country = "country0",
            },
        },
        new LocationResponeObjectV2
        {
            Uid = "uid0",
            ExternalId = "externalId6",
            Coordinates = new Coordinates
            {
                Latitude = 39.14,
                Longitude = 36.94,
            },
            OperatorName = "operatorName0",
            Address = new Address
            {
                StreetAndNumber = "streetAndNumber2",
                PostalCode = "postalCode8",
                City = "city6",
                Country = "country0",
            },
        },
        new LocationResponeObjectV2
        {
            Uid = "uid0",
            ExternalId = "externalId6",
            Coordinates = new Coordinates
            {
                Latitude = 39.14,
                Longitude = 36.94,
            },
            OperatorName = "operatorName0",
            Address = new Address
            {
                StreetAndNumber = "streetAndNumber2",
                PostalCode = "postalCode8",
                City = "city6",
                Country = "country0",
            },
        },
    },
};
```

