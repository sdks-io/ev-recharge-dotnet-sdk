
# HTTP401 Error Response Exception

## Structure

`HTTP401ErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Required | A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `Status` | [`ResponseBaseStatusEnum`](../../doc/models/response-base-status-enum.md) | Required | Indicates overall status of the request |
| `Errors` | [`List<ResponseError401AllOf1ErrorsItems>`](../../doc/models/response-error-401-all-of-1-errors-items.md) | Required | Details of error(s) encountered |

## Example (as JSON)

```json
{
  "RequestId": "eb621f45-a543-4d9a-a934-2f223b263c42",
  "Status": "SUCCESS",
  "Errors": [
    {
      "Code": "E0003",
      "Title": "Unauthorized",
      "Detail": "Supplied credentials are invalid or user does not have access to the operation.",
      "AdditionalInfo": {
        "key0": "AdditionalInfo0",
        "key1": "AdditionalInfo1",
        "key2": "AdditionalInfo2"
      }
    }
  ]
}
```

