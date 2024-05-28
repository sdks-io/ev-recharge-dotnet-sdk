
# M404 Error Response

Invalid charge token with given EmaId was not found.

Backend HTTP 410 should be transformed to 404.

## Structure

`M404ErrorResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `Status` | `string` | Required | Indicates overall status of the request<br>**Constraints**: *Minimum Length*: `6`, *Maximum Length*: `6` |
| `Errors` | [`List<M404ErrorResponseError>`](../../doc/models/m404-error-response-error.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "Status": "FAILED",
  "Errors": [
    {
      "Code": "Code4",
      "Title": "Title6",
      "Detail": "Detail6",
      "AdditionalInfo": {
        "key0": "AdditionalInfo0",
        "key1": "AdditionalInfo1",
        "key2": "AdditionalInfo2"
      }
    },
    {
      "Code": "Code4",
      "Title": "Title6",
      "Detail": "Detail6",
      "AdditionalInfo": {
        "key0": "AdditionalInfo0",
        "key1": "AdditionalInfo1",
        "key2": "AdditionalInfo2"
      }
    }
  ]
}
```

