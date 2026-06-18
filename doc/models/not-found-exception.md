
# Not Found Exception

Requested resource path not available it will provides the error in OpenAPI spec mentioned format, if there is any change in base URL then respective platform error message will be populated.

## Structure

`NotFoundException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | requestId is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. |
| `Status` | `string` | Optional | Status of the request |
| `Errors` | [`List<NotFoundErrMsg>`](../../doc/models/not-found-err-msg.md) | Optional | Exception details of the error |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is NotFoundException)
    {
        // TODO: Handle NotFoundException
        Console.WriteLine(e.Message);
    }
}
```

