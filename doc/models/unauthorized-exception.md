
# Unauthorized Exception

## Structure

`UnauthorizedException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | requestId or correlation id of the message |
| `Status` | `string` | Optional | Status of the request |
| `Errors` | [`List<UnauthorizedErrMsg>`](../../doc/models/unauthorized-err-msg.md) | Optional | Exception details of the error |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is UnauthorizedException)
    {
        // TODO: Handle UnauthorizedException
        Console.WriteLine(e.Message);
    }
}
```

