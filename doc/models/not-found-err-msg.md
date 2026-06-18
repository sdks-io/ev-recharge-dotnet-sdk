
# Not Found Err Msg

## Structure

`NotFoundErrMsg`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | Error code |
| `Message` | `string` | Optional | Error desctiption in English |
| `Description` | `string` | Optional | Technical details of the error message, the example which is given in the sample payload is one of the scenarios. actual response will vary based on the technical nature |
| `Details` | `List<string>` | Optional | - |

## Example

```csharp
using ShellEV.Standard.Models;
using System.Collections.Generic;

NotFoundErrMsg notFoundErrMsg = new NotFoundErrMsg
{
    Code = "E0038",
    Message = "Not Found",
    Description = "Requested API resource not found",
    Details = new List<string>
    {
        "details7",
    },
};
```

