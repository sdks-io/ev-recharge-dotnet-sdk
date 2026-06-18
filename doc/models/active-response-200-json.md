
# Active Response 200 Json

## Structure

`ActiveResponse200Json`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `Guid` | Required, Read-only | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `Status` | [`GetChargeSessionRetrieveResponse200JsonStatusEnum`](../../doc/models/get-charge-session-retrieve-response-200-json-status-enum.md) | Required, Read-only | **Constraints**: *Minimum Length*: `7`, *Maximum Length*: `7` |
| `Data` | [`List<DataActive>`](../../doc/models/data-active.md) | Optional | - |

## Example

```csharp
using ShellEV.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ActiveResponse200Json activeResponse200Json = new ActiveResponse200Json
{
    RequestId = new Guid("9d2dee33-7803-485a-a2b1-2c7538e597ee"),
    Status = GetChargeSessionRetrieveResponse200JsonStatusEnum.SUCCESS,
    Data = new List<DataActive>
    {
        new DataActive
        {
            Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
            UserId = "userId0",
            EmaId = "emaId8",
            EvseId = "evseId2",
            StartedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
        new DataActive
        {
            Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
            UserId = "userId0",
            EmaId = "emaId8",
            EvseId = "evseId2",
            StartedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
        new DataActive
        {
            Id = new Guid("00001c2a-0000-0000-0000-000000000000"),
            UserId = "userId0",
            EmaId = "emaId8",
            EvseId = "evseId2",
            StartedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
    },
};
```

