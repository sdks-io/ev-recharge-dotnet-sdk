
# Inline Response 202

## Structure

`InlineResponse202`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `Guid` | Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `Status` | [`GetChargeSessionRetrieveResponse200JsonStatusEnum`](../../doc/models/get-charge-session-retrieve-response-200-json-status-enum.md) | Required | - |
| `Data` | [`List<InlineResponse202Data>`](../../doc/models/inline-response-202-data.md) | Required | - |

## Example (as JSON)

```json
{
  "requestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "status": "SUCCESS",
  "data": [
    {
      "sessionId": "c3e332f0-1bb2-4f50-a96b-e075bbb71e68"
    }
  ]
}
```

