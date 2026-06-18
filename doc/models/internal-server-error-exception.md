
# Internal Server Error Exception

## Structure

`InternalServerErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | requestId is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. |
| `Status` | `string` | Optional | Status of the request |
| `Errors` | [`List<InternalErrorObject>`](../../doc/models/internal-error-object.md) | Optional | Exception details of the error |
| `Details` | `List<string>` | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is InternalServerErrorException)
    {
        // TODO: Handle InternalServerErrorException
        Console.WriteLine(e.Message);
    }
}
```

