
# Ratelimit Err Msg

## Structure

`RatelimitErrMsg`

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
  "code": "E0009",
  "message": "Too Many Requests",
  "description": "Exceeded maximum allowed number of request limit",
  "details": [
    "details9",
    "details0"
  ]
}
```

