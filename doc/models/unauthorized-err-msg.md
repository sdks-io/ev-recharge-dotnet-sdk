
# Unauthorized Err Msg

## Structure

`UnauthorizedErrMsg`

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

UnauthorizedErrMsg unauthorizedErrMsg = new UnauthorizedErrMsg
{
    Code = "E0003",
    Message = "Unauthorized",
    Description = "Invalid Access Token",
    Details = new List<string>
    {
        "details9",
    },
};
```

