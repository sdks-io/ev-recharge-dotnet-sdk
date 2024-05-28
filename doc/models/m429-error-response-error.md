
# M429 Error Response Error

## Structure

`M429ErrorResponseError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Required | Error code that logically best represents the error encountered<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `5` |
| `Title` | `string` | Required | Description of the error type<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `100` |
| `Detail` | `string` | Required | Details of the error that can help under the cause of the error<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `250` |
| `AdditionalInfo` | `Dictionary<string, string>` | Optional | - |

## Example (as JSON)

```json
{
  "Code": "E0008",
  "Title": "Too Many Requests",
  "Detail": "Number of requests received per minute is more than the allowed/configured policy",
  "AdditionalInfo": {
    "key0": "AdditionalInfo2"
  }
}
```

