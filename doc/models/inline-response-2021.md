
# Inline Response 2021

## Structure

`InlineResponse2021`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `Guid` | Required, Read-only | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `Status` | [`GetChargeSessionRetrieveResponse200JsonStatusEnum`](../../doc/models/get-charge-session-retrieve-response-200-json-status-enum.md) | Required, Read-only | **Constraints**: *Minimum Length*: `6`, *Maximum Length*: `7` |

## Example

```csharp
using ShellEV.Standard.Models;

InlineResponse2021 inlineResponse2021 = new InlineResponse2021
{
    RequestId = new Guid("9d2dee33-7803-485a-a2b1-2c7538e597ee"),
    Status = GetChargeSessionRetrieveResponse200JsonStatusEnum.SUCCESS,
};
```

