
# Active Response 200 Json

## Structure

`ActiveResponse200Json`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `Guid` | Required | A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request. |
| `Status` | [`ActiveResponse200JsonStatusEnum`](../../doc/models/active-response-200-json-status-enum.md) | Required | Indicates overall status of the request<br>**Constraints**: *Minimum Length*: `7`, *Maximum Length*: `7` |
| `Data` | [`List<DataActive>`](../../doc/models/data-active.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "Status": "SUCCESS",
  "Data": [
    {
      "Id": "0000227e-0000-0000-0000-000000000000",
      "UserId": "UserId8",
      "EmaId": "EmaId4",
      "EvseId": "EvseId4",
      "StartedAt": "2016-03-13T12:52:32.123Z"
    },
    {
      "Id": "0000227e-0000-0000-0000-000000000000",
      "UserId": "UserId8",
      "EmaId": "EmaId4",
      "EvseId": "EvseId4",
      "StartedAt": "2016-03-13T12:52:32.123Z"
    }
  ]
}
```

