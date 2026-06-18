
# Opening Hours Object

## Structure

`OpeningHoursObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WeekDay` | [`OpeningHoursObjectWeekDayEnum?`](../../doc/models/opening-hours-object-week-day-enum.md) | Optional | 3 letter day of the week |
| `StartTime` | `string` | Optional | Hour in 24h local time when the location opens. |
| `EndTime` | `string` | Optional | Hour in 24h local time when the location closes. |

## Example

```csharp
using ShellEV.Standard.Models;

OpeningHoursObject openingHoursObject = new OpeningHoursObject
{
    WeekDay = OpeningHoursObjectWeekDayEnum.Mon,
    StartTime = "08:00",
    EndTime = "23:00",
};
```

