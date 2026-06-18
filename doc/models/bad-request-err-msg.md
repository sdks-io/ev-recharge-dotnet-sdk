
# Bad Request Err Msg

## Structure

`BadRequestErrMsg`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | Error code |
| `Message` | `string` | Optional | Error desctiption in English |
| `Description` | `string` | Optional | Technical details of the error message, the example which is given in the sample payload is one of the scenarios. actual response will vary based on the validation error |
| `Details` | `List<string>` | Optional | - |

## Example

```csharp
using ShellEV.Standard.Models;
using System.Collections.Generic;

BadRequestErrMsg badRequestErrMsg = new BadRequestErrMsg
{
    Code = "E0001",
    Message = "Bad Request",
    Description = "Authorization header is missing",
    Details = new List<string>
    {
        "details3",
    },
};
```

