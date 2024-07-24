
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `ClientCredentialsAuth` | [`ClientCredentialsAuth`]($a/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

```csharp
ShellEV.Standard.ShellEVClient client = new ShellEV.Standard.ShellEVClient.Builder()
    .ClientCredentialsAuth(
        new ClientCredentialsAuthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .Environment(ShellEV.Standard.Environment.Production)
    .Build();
```

## Shell EVClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| LocationsController | Gets LocationsController controller. |
| ChargingController | Gets ChargingController controller. |
| OAuthAuthorizationController | Gets OAuthAuthorizationController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| ClientCredentialsAuth | Gets the credentials to use with ClientCredentialsAuth. | [`IClientCredentialsAuth`]($a/oauth-2-client-credentials-grant.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Shell EVClient using the values provided for the builder. | `Builder` |

## Shell EVClient Builder Class

Class to build instances of Shell EVClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `ClientCredentialsAuth(Action<ClientCredentialsAuthModel.Builder> action)` | Sets credentials for ClientCredentialsAuth. | `Builder` |

