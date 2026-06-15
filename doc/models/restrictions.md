
# Restrictions

## Structure

`Restrictions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartTime` | `string` | Optional | Valid from this time of the day (HH:mm) |
| `EndTime` | `string` | Optional | Valid until this time of the day (HH:mm) |
| `StartDate` | `DateTime?` | Optional | - |
| `EndDate` | `DateTime?` | Optional | - |
| `MinKwh` | `double?` | Optional | - |
| `MaxKwh` | `double?` | Optional | - |
| `MinCurrent` | `double?` | Optional | - |
| `MaxCurrent` | `double?` | Optional | - |
| `MinPower` | `double?` | Optional | - |
| `MaxPower` | `double?` | Optional | - |
| `MinDuration` | `int?` | Optional | Minimum session duration in seconds |
| `MaxDuration` | `int?` | Optional | Maximum session duration in seconds |
| `DayOfWeek` | [`List<DayOfWeekEnum>`](../../doc/models/day-of-week-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "startTime": "08:00",
  "endTime": "18:00",
  "startDate": "2021-10-06",
  "endDate": "2021-10-31",
  "minKwh": 0.1,
  "maxKwh": 100,
  "minCurrent": 0,
  "maxCurrent": 500,
  "minPower": 0,
  "maxPower": 100,
  "minDuration": 0,
  "maxDuration": 86400
}
```

