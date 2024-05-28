
# Tariff VO

Tariff details for charging on this Connector

## Structure

`TariffVO`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartFee` | `double?` | Optional | Tariff to start a charging session |
| `PerMinute` | `double?` | Optional | Tariff per minute of charging time |
| `PerKWh` | `double?` | Optional | Tariff per kWh of energy consumed |
| `Currency` | `string` | Optional | ISO 4217 Curreny Code of the local currency. |
| `Updated` | `string` | Optional | ISO8601-compliant UTC datetime of the last update of the Tariff |
| `UpdatedBy` | [`TariffVOUpdatedByEnum?`](../../doc/models/tariff-vo-updated-by-enum.md) | Optional | Source of the last update of the tariff details |
| `Structure` | `string` | Optional | Tariff structure that this tariff belongs to, typically Default unless specific tariff is defined for provider |

## Example (as JSON)

```json
{
  "startFee": 0.0,
  "perMinute": 0.12,
  "perKWh": 0.89,
  "currency": "EUR",
  "updated": "07/06/2021 10:44:24",
  "updatedBy": "TariffService",
  "structure": "default"
}
```

