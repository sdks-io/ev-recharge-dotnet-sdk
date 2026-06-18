
# Internal Error Object

## Structure

`InternalErrorObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | Error code |
| `Message` | `string` | Optional | Error description in English |
| `Description` | `string` | Optional | Technical details of the error message, the example which is given in the sample payload is one of the scenario. actual response will vary based on the technical nature |

## Example

```csharp
using ShellEV.Standard.Models;

InternalErrorObject internalErrorObject = new InternalErrorObject
{
    Code = "E0005",
    Message = "Internal Server Error",
    Description = "Server encountered an unexpected condition that prevented it from fulfilling the request",
};
```

