
# Inline Response 202 Data

## Structure

`InlineResponse202Data`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SessionId` | `string` | Optional | Session Id for tracking.<br><br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |

## Example

```csharp
using ShellEV.Standard.Models;

InlineResponse202Data inlineResponse202Data = new InlineResponse202Data
{
    SessionId = "c3e332f0-1bb2-4f50-a96b-e075bbb71e68",
};
```

