
# Get Charge Session Retrieve Response 200 Json

## Structure

`GetChargeSessionRetrieveResponse200Json`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `Guid` | Required, Read-only | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `Status` | [`GetChargeSessionRetrieveResponse200JsonStatusEnum`](../../doc/models/get-charge-session-retrieve-response-200-json-status-enum.md) | Required, Read-only | **Constraints**: *Minimum Length*: `6`, *Maximum Length*: `15` |
| `Data` | [`List<DataRetrieve>`](../../doc/models/data-retrieve.md) | Optional | - |

## Example

```csharp
using ShellEV.Standard.Models;
using System.Collections.Generic;

GetChargeSessionRetrieveResponse200Json getChargeSessionRetrieveResponse200Json = new GetChargeSessionRetrieveResponse200Json
{
    RequestId = new Guid("9d2dee33-7803-485a-a2b1-2c7538e597ee"),
    Status = GetChargeSessionRetrieveResponse200JsonStatusEnum.SUCCESS,
    Data = new List<DataRetrieve>
    {
        new DataRetrieve
        {
            Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
            UserId = "userId0",
            EmaId = "emaId8",
            EvseId = "evseId2",
            LastUpdated = "lastUpdated0",
        },
        new DataRetrieve
        {
            Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
            UserId = "userId0",
            EmaId = "emaId8",
            EvseId = "evseId2",
            LastUpdated = "lastUpdated0",
        },
        new DataRetrieve
        {
            Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
            UserId = "userId0",
            EmaId = "emaId8",
            EvseId = "evseId2",
            LastUpdated = "lastUpdated0",
        },
    },
};
```

