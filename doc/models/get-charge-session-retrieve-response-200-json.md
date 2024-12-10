
# Get Charge Session Retrieve Response 200 Json

## Structure

`GetChargeSessionRetrieveResponse200Json`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `Guid` | Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `Status` | [`GetChargeSessionRetrieveResponse200JsonStatusEnum`](../../doc/models/get-charge-session-retrieve-response-200-json-status-enum.md) | Required | **Constraints**: *Minimum Length*: `6`, *Maximum Length*: `15` |
| `Data` | [`List<DataRetrieve>`](../../doc/models/data-retrieve.md) | Optional | - |

## Example (as JSON)

```json
{
  "requestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "status": "SUCCESS",
  "data": [
    {
      "id": "00001c2a-0000-0000-0000-000000000000",
      "userId": "userId0",
      "emaId": "emaId8",
      "evseId": "evseId2",
      "lastUpdated": "lastUpdated0"
    },
    {
      "id": "00001c2a-0000-0000-0000-000000000000",
      "userId": "userId0",
      "emaId": "emaId8",
      "evseId": "evseId2",
      "lastUpdated": "lastUpdated0"
    },
    {
      "id": "00001c2a-0000-0000-0000-000000000000",
      "userId": "userId0",
      "emaId": "emaId8",
      "evseId": "evseId2",
      "lastUpdated": "lastUpdated0"
    }
  ]
}
```

