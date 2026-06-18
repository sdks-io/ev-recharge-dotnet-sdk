
# Ratelimit Err Msg

## Structure

`RatelimitErrMsg`

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

RatelimitErrMsg ratelimitErrMsg = new RatelimitErrMsg
{
    Code = "E0009",
    Message = "Too Many Requests",
    Description = "Exceeded maximum allowed number of request limit",
    Details = new List<string>
    {
        "details3",
        "details4",
        "details5",
    },
};
```

