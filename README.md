
# Getting Started with Shell EV

## Introduction

This API Product provides the list of all Shell Recharge locations. The list includes all Shell Recharge network and all locations available through our roaming partners.

Supported Functions

* Get the list of all the locations and its details.
* Get the details of a particular location.
* Get the list of locations nearby using the latitude and longitude.
* Get the list of locations for a given set of bounds with different zoom levels.

The Charging endpoints provides control to start, stop and get status of the charging session.

Supported Functions

* Start a charging session\n
* Stop a charging session \n
* Retrieve the status of a charging session \n
* Retrieve the list of all active sessions for a card

Go to the Shell Developer Portal: [https://developer.shell.com](https://developer.shell.com)

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package sdksio.EvRechargeSDK --version 2.1.0
```

You can also view the package at:
https://www.nuget.org/packages/sdksio.EvRechargeSDK/2.1.0

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/README.md#environments) | The API environment. <br> **Default: `Environment.Production`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| ClientCredentialsAuth | [`ClientCredentialsAuth`](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

### Code-Based Initialization

```csharp
using ShellEV.Standard;
using ShellEV.Standard.Authentication;

namespace ConsoleApp;

ShellEVClient client = new ShellEVClient.Builder()
    .ClientCredentialsAuth(
        new ClientCredentialsAuthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .Environment(ShellEV.Standard.Environment.Production)
    .Build();
```

### Configuration-Based Initialization

```csharp
using ShellEV.Standard;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = ShellEVClient
    .FromConfiguration(configuration.GetSection("ShellEV"));
```

See the [Configuration-Based Initialization](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/configuration-based-initialization.md) section for details.

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | **Default** Production Server |
| Environment2 | Test Server |

## Authorization

This API uses the following authentication schemes.

* [`BearerAuth (OAuth 2 Client Credentials Grant)`](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/auth/oauth-2-client-credentials-grant.md)

## List of APIs

* [Locations](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/controllers/locations.md)
* [Charging](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/controllers/charging.md)

## SDK Infrastructure

### Configuration

* [Configuration-Based Initialization](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/configuration-based-initialization.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/http-client-configuration-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/http-callback.md)
* [HttpContext](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/http-context.md)
* [HttpRequest](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/api-exception.md)
* [ApiHelper](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/api-helper.md)
* [CustomDateTimeConverter](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](https://www.github.com/sdks-io/ev-recharge-dotnet-sdk/tree/2.1.0/doc/unix-date-time-converter.md)

