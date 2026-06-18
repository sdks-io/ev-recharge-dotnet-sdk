
# Tariff

## Structure

`Tariff`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartFee` | `double?` | Optional | Tariff to start a charging session |
| `PerMinute` | `double?` | Optional | Tariff per minute of charging time |
| `PerKWh` | `double?` | Optional | Tariff per kWh of energy consumed |
| `Currency` | `string` | Optional | ISO 4217 Currency Code of the local currency. |
| `Updated` | `string` | Optional | ISO8601-compliant UTC datetime of the last update of the Tariff |
| `UpdatedBy` | [`TariffVOUpdatedByEnum?`](../../doc/models/tariff-vo-updated-by-enum.md) | Optional | Source of the last update of the tariff details |
| `Structure` | `string` | Optional | Tariff structure that this tariff belongs to, typically Default unless specific tariff is defined for provider |

## Example

```csharp
using ShellEV.Standard.Models;

Tariff tariff = new Tariff
{
    StartFee = 0,
    PerMinute = 0.12,
    PerKWh = 0.89,
    Currency = "EUR",
    Updated = "2021-07-06T10:44:24Z",
    UpdatedBy = TariffVOUpdatedByEnum.TariffService,
    Structure = "default",
};
```

