
# Coordinates 1

## Structure

`Coordinates1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Latitude` | `double?` | Optional | Latitude of the Coordinate<br><br>**Constraints**: `>= -90`, `<= 90` |
| `Longitude` | `double?` | Optional | Longitude of the Coordinate<br><br>**Constraints**: `>= -180`, `<= 180` |

## Example

```csharp
using ShellEV.Standard.Models;

Coordinates1 coordinates1 = new Coordinates1
{
    Latitude = 52.143814,
    Longitude = 52.143814,
};
```

