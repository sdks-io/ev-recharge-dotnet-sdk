
# Bad Request Exception

## Structure

`BadRequestException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | requestId is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. |
| `Status` | `string` | Optional | Status of the request |
| `Errors` | [`List<BadRequestErrMsg>`](../../doc/models/bad-request-err-msg.md) | Optional | Exception details of the error |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is BadRequestException)
    {
        // TODO: Handle BadRequestException
        Console.WriteLine(e.Message);
    }
}
```

