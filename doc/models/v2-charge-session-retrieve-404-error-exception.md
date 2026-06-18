
# V2 Charge Session Retrieve 404 Error Exception

## Structure

`V2ChargeSessionRetrieve404ErrorException`

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
    if (e is V2ChargeSessionRetrieve404ErrorException)
    {
        // TODO: Handle V2ChargeSessionRetrieve404ErrorException
        Console.WriteLine(e.Message);
    }
}
```

