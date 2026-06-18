
# Serviceunavailable Err Msg

## Structure

`ServiceunavailableErrMsg`

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

ServiceunavailableErrMsg serviceunavailableErrMsg = new ServiceunavailableErrMsg
{
    Code = "E0014",
    Message = "Connectivity Error",
    Description = "Service Unavailable",
    Details = new List<string>
    {
        "details5",
        "details6",
        "details7",
    },
};
```

