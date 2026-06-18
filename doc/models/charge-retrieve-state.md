
# Charge Retrieve State

## Structure

`ChargeRetrieveState`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Optional | Describes the session state<br><br>started, stopped, start-requested, stop-requested, failed-to-start, failed-to-stop |
| `Error` | [`ChargeError`](../../doc/models/charge-error.md) | Optional | - |

## Example

```csharp
using ShellEV.Standard.Models;

ChargeRetrieveState chargeRetrieveState = new ChargeRetrieveState
{
    Status = "status0",
    Error = new ChargeError
    {
        Code = "code2",
        Message = "message4",
    },
};
```

