
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

## Example

```csharp
using ShellEV.Standard.Models;

Restrictions restrictions = new Restrictions
{
    StartTime = "08:00",
    EndTime = "18:00",
    StartDate = DateTime.Parse("2021-10-06"),
    EndDate = DateTime.Parse("2021-10-31"),
    MinKwh = 0.1,
    MaxKwh = 100,
    MinCurrent = 0,
    MaxCurrent = 500,
    MinPower = 0,
    MaxPower = 100,
    MinDuration = 0,
    MaxDuration = 86400,
};
```

