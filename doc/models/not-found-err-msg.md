
# Not Found Err Msg

## Structure

`NotFoundErrMsg`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | Error code |
| `Message` | `string` | Optional | Error desctiption in English |
| `Description` | `string` | Optional | Technical details of the error message, the example which is given in the sample payload is one of the scenarios. actual response will vary based on the technical nature |
| `Details` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "code": "E0038",
  "message": "Not Found",
  "description": "Requested API resource not found",
  "details": [
    "details9",
    "details0"
  ]
}
```

