
# Power Range

## Structure

`PowerRange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Min` | `int` | Required | Minimum supported power in kW |
| `Max` | `int` | Required | Maximum supported power in kW |

## Example

```csharp
using ShellEV.Standard.Models;

PowerRange powerRange = new PowerRange
{
    Min = 0,
    Max = 100,
};
```

