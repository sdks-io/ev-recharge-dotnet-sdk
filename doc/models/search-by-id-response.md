
# Search by Id Response

## Structure

`SearchByIdResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `Guid?` | Optional | requestId is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. |
| `Status` | `string` | Optional | status of the API call |
| `Data` | [`List<SearchByIdLocationRespone>`](../../doc/models/search-by-id-location-respone.md) | Optional | API Response |

## Example

```csharp
using ShellEV.Standard.Models;
using System.Collections.Generic;

SearchByIdResponse searchByIdResponse = new SearchByIdResponse
{
    RequestId = new Guid("9d2dee33-7803-485a-a2b1-2c7538e597ee"),
    Status = "SUCCESS",
    Data = new List<SearchByIdLocationRespone>
    {
        new SearchByIdLocationRespone
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
        new SearchByIdLocationRespone
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

