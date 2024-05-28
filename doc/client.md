
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Env` | `Models.EnvEnum` | This variable specifies the type of environment. Environments:<br><br>* `api` - Production<br>* `api-test` - UAT<br>*Default*: `EnvEnum.Enum_apitestshellcom` |
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
    .Env(EnvEnum.EnumApitestshellcom)
    .Build();
```

## Shell EVClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| ChargingController | Gets ChargingController controller. |
| LocationsController | Gets LocationsController controller. |
| OAuthAuthorizationController | Gets OAuthAuthorizationController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| Env | This variable specifies the type of environment. Environments:   * `api` - Production   * `api-test` - UAT | `Models.EnvEnum` |
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
| `Env(Models.EnvEnum env)` | This variable specifies the type of environment. Environments:   * `api` - Production   * `api-test` - UAT | `Builder` |
| `ClientCredentialsAuth(Action<ClientCredentialsAuthModel.Builder> action)` | Sets credentials for ClientCredentialsAuth. | `Builder` |

