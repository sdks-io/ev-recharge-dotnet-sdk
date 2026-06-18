
# Too Many Requests Exception

## Structure

`TooManyRequestsException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | RequestID is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. |
| `Status` | `string` | Optional | Status of the request |
| `Errors` | [`List<RatelimitErrMsg>`](../../doc/models/ratelimit-err-msg.md) | Optional | Exception details of the error |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is TooManyRequestsException)
    {
        // TODO: Handle TooManyRequestsException
        Console.WriteLine(e.Message);
    }
}
```

