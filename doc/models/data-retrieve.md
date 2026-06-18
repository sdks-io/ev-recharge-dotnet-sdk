
# Data Retrieve

## Structure

`DataRetrieve`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Id of the session |
| `UserId` | `string` | Optional | Id of the user that started the session<br><br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `EmaId` | `string` | Optional | Id of the evse that the user is charging<br><br>**Constraints**: *Minimum Length*: `12`, *Maximum Length*: `36` |
| `EvseId` | `string` | Optional | Ema-id of the charge token that is used |
| `LastUpdated` | `string` | Optional | Last updated date |
| `StartedAt` | `DateTime?` | Optional | When the session is started |
| `StoppedAt` | `DateTime?` | Optional | When the session is stopped |
| `SessionState` | [`ChargeRetrieveState`](../../doc/models/charge-retrieve-state.md) | Optional | - |

## Example

```csharp
using ShellEV.Standard.Models;
using System.Globalization;

DataRetrieve dataRetrieve = new DataRetrieve
{
    Id = new Guid("78b5d7a3-bdba-43d7-9851-1c84fcddb782"),
    UserId = "281482b6-2c9a-4fd1-b3ea-1928edb40ef9",
    EmaId = "NL-TNM-C00122045-K",
    EvseId = "NL*TNM*E02003451*0",
    LastUpdated = "lastUpdated8",
    StartedAt = DateTime.ParseExact("2015-08-19T11:20:27Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    StoppedAt = DateTime.ParseExact("2015-08-19T11:20:27Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

