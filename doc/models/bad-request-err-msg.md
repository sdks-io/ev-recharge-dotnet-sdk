
# Bad Request Err Msg

## Structure

`BadRequestErrMsg`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | Error code |
| `Message` | `string` | Optional | Error desctiption in English |
| `Description` | `string` | Optional | Technical details of the error message, the example which is given in the sample payload is one of the scenarios. actual response will vary based on the validation error |
| `Details` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "code": "E0001",
  "message": "Bad Request",
  "description": "Authorization header is missing",
  "details": [
    "details7",
    "details8",
    "details9"
  ]
}
```

