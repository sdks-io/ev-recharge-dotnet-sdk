
# Response Error 401 All of 1

## Structure

`ResponseError401AllOf1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`List<ResponseError401AllOf1ErrorsItems>`](../../doc/models/response-error-401-all-of-1-errors-items.md) | Required | Details of error(s) encountered |

## Example (as JSON)

```json
{
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

