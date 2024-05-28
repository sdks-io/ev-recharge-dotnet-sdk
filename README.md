
# Getting Started with Shell EV

## Introduction

This API Product provides the option to manage charging at all public Shell Recharge locations. The end points provides control to start, stop and get status of the charging session.

Supported Function

* Start a charging session
* Stop a charging session
* Retrieve the status of a charging session
* Retrieve the list of all active sessions for a card   termsOfService: 'https://developer.shell.com/terms-of-use'

Go to the Shell Developer Portal: [https://developer.shell.com](https://developer.shell.com)

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package sdksio.EvRechargeSDK --version 1.0.0
```

You can also view the package at:
https://www.nuget.org/packages/sdksio.EvRechargeSDK/1.0.0

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Env` | `Models.EnvEnum` | This variable specifies the type of environment. Environments:<br><br>* `api` - Production<br>* `api-test` - UAT<br>*Default*: `EnvEnum.Enum_apitestshellcom` |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `ClientCredentialsAuth` | [`ClientCredentialsAuth`](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/$a/https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

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

## Authorization

This API uses the following authentication schemes.

* [`BearerAuth (OAuth 2 Client Credentials Grant)`](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/$a/https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/oauth-2-client-credentials-grant.md)

## List of APIs

* [O Auth Authorization](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/controllers/o-auth-authorization.md)
* [Charging](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/controllers/charging.md)
* [Locations](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/controllers/locations.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/http-string-response.md)
* [HttpContext](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/1.0.0/doc/api-exception.md)

