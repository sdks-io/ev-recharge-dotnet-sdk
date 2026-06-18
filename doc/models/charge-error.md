
# Charge Error

## Structure

`ChargeError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | Session code e.g InternalError |
| `Message` | `string` | Optional | Session message |

## Example

```csharp
using ShellEV.Standard.Models;

ChargeError chargeError = new ChargeError
{
    Code = "code4",
    Message = "message6",
};
```

