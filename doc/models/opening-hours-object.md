
# Opening Hours Object

## Structure

`OpeningHoursObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WeekDay` | [`OpeningHoursObjectWeekDayEnum?`](../../doc/models/opening-hours-object-week-day-enum.md) | Optional | - |
| `StartTime` | `string` | Optional | Hour in 24h local time when the location opens. |
| `EndTime` | `string` | Optional | Hour in 24h local time when the location closes. |

## Example (as JSON)

```json
{
  "startTime": "08:00",
  "endTime": "23:00",
  "weekDay": "Thu"
}
```

