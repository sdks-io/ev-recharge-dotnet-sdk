# Charging

Charging Endpoints

```csharp
ChargingController chargingController = client.ChargingController;
```

## Class Name

`ChargingController`

## Methods

* [Start Charge Session](../../doc/controllers/charging.md#start-charge-session)
* [Stop Charge Session](../../doc/controllers/charging.md#stop-charge-session)
* [Get Charge Session Retrieve](../../doc/controllers/charging.md#get-charge-session-retrieve)
* [Active](../../doc/controllers/charging.md#active)


# Start Charge Session

This API initiates to start a session on a EVSE (Electric Vehicle Supply Equipement). When the EV Charge Card number and the unique EVSE ID on the location is provided, the session is initiated.

Please note that this is an asynchronous request, the request will be passed on to the operator/platform to be processed further.

```csharp
StartChargeSessionAsync(
    Guid requestId,
    Models.ChargesessionStartBody body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `Guid` | Header, Required | A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request. |
| `body` | [`ChargesessionStartBody`](../../doc/models/chargesession-start-body.md) | Body, Optional | - |

## Response Type

[`Task<Models.InlineResponse202>`](../../doc/models/inline-response-202.md)

## Example Usage

```csharp
Guid requestId = new Guid("eb621f45-a543-4d9a-a934-2f223b263c42");
ChargesessionStartBody body = new ChargesessionStartBody
{
    EvChargeNumber = "NL-TNM-C00122045-K",
    EvseId = "NL*TNM*E02003451*0",
};

try
{
    InlineResponse202 result = await chargingController.StartChargeSessionAsync(
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "Status": "SUCCESS",
  "Data": [
    {
      "SessionId": "c3e332f0-1bb2-4f50-a96b-e075bbb71e68"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ErrorResponseError1Exception`](../../doc/models/m400-error-response-error-1-exception.md) |
| 401 | Unauthorized | [`HTTP401ErrorResponseException`](../../doc/models/http401-error-response-exception.md) |
| 404 | Invalid charge token with given EmaId was not found.<br><br>Backend HTTP 410 should be transformed to 404. | [`M404ErrorResponseError1Exception`](../../doc/models/m404-error-response-error-1-exception.md) |
| 405 | Method Not Allowed | [`M405ErrorResponseError1Exception`](../../doc/models/m405-error-response-error-1-exception.md) |
| 429 | Too Many Requests | [`M429ErrorResponseError1Exception`](../../doc/models/m429-error-response-error-1-exception.md) |
| 500 | Internal Server Error | [`M500ErrorResponseError1Exception`](../../doc/models/m500-error-response-error-1-exception.md) |
| 503 | Returned when a connectivity failure is encountered like DB connection failed, endpoint failed etc or when max number of retries are completed | [`M503ErrorResponseError1Exception`](../../doc/models/m503-error-response-error-1-exception.md) |


# Stop Charge Session

This API stops a session by providing the session ID which was retrieved when starting the session. HTTP 202 response will be returned if the request is accepted. Once the session is stopped the response will contain the DateTime on which it is stopped.      operationId: Stop

```csharp
StopChargeSessionAsync(
    Guid requestId,
    Guid uuid,
    Models.StopChargeSessionRequestBodyJson body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `Guid` | Header, Required | A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request. |
| `uuid` | `Guid` | Template, Required | Unique session ID which was generated to activate a charging session. |
| `body` | [`StopChargeSessionRequestBodyJson`](../../doc/models/stop-charge-session-request-body-json.md) | Body, Optional | - |

## Response Type

[`Task<Models.InlineResponse2021>`](../../doc/models/inline-response-2021.md)

## Example Usage

```csharp
Guid requestId = new Guid("eb621f45-a543-4d9a-a934-2f223b263c42");
Guid uuid = new Guid("00000f7e-0000-0000-0000-000000000000");
StopChargeSessionRequestBodyJson body = new StopChargeSessionRequestBodyJson
{
    SesssionId = "c3e332f0-1bb2-4f50-a96b-e075bbb71e68",
};

try
{
    InlineResponse2021 result = await chargingController.StopChargeSessionAsync(
        requestId,
        uuid,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "Status": "SUCCESS"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ErrorResponseError1Exception`](../../doc/models/m400-error-response-error-1-exception.md) |
| 401 | Unauthorized | [`M401ErrorResponseError1Exception`](../../doc/models/m401-error-response-error-1-exception.md) |
| 404 | Session not found or Session has already been stopped. Map 410 Error message into 404. | [`M404ErrorResponseError1Exception`](../../doc/models/m404-error-response-error-1-exception.md) |
| 405 | Method Not Allowed | [`M405ErrorResponseError1Exception`](../../doc/models/m405-error-response-error-1-exception.md) |
| 429 | Too Many Requests | [`M429ErrorResponseError1Exception`](../../doc/models/m429-error-response-error-1-exception.md) |
| 500 | Internal Server Error | [`M500ErrorResponseError1Exception`](../../doc/models/m500-error-response-error-1-exception.md) |
| 503 | Returned when a connectivity failure is encountered like DB connection failed, endpoint failed etc or when max number of retries are completed | [`M503ErrorResponseError1Exception`](../../doc/models/m503-error-response-error-1-exception.md) |


# Get Charge Session Retrieve

This API retrieves the status and details of the session which was started by the user. The session ID generated earlier needs to be passed in this API in order to retrieve the status.

```csharp
GetChargeSessionRetrieveAsync(
    Guid requestId,
    string sessionId,
    Guid uuid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `Guid` | Header, Required | A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request. |
| `sessionId` | `string` | Query, Required | Session Id is to be fetched |
| `uuid` | `Guid` | Template, Required | Unique session ID which was generated to activate a charging session. |

## Response Type

[`Task<Models.GetChargeSessionRetrieveResponse200Json>`](../../doc/models/get-charge-session-retrieve-response-200-json.md)

## Example Usage

```csharp
Guid requestId = new Guid("eb621f45-a543-4d9a-a934-2f223b263c42");
string sessionId = "c3e332f0-1bb2-4f50-a96b-e075bbb71e68";
Guid uuid = new Guid("00000f7e-0000-0000-0000-000000000000");
try
{
    GetChargeSessionRetrieveResponse200Json result = await chargingController.GetChargeSessionRetrieveAsync(
        requestId,
        sessionId,
        uuid
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "Status": "SUCCESS",
  "Data": [
    {
      "EmaId": "NL-TNM-C0216599X-A",
      "EvseId": "NL*TNM*EVIRTUALCP0002*0",
      "Id": "4eaf3619-d095-486f-8590-cac75fb21c1b",
      "StartedAt": "2022-10-21T09:56:59.725Z",
      "Sessionstate": "stopped",
      "StoppedAt": "2022-10-21T09:57:25.468Z",
      "SessionCode": null,
      "SessionMessage": null,
      "UserId": "96f69b3b-8ad4-487a-baaa-f1d3db741e88"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ErrorResponseError1Exception`](../../doc/models/m400-error-response-error-1-exception.md) |
| 401 | Unauthorized | [`M401ErrorResponseError1Exception`](../../doc/models/m401-error-response-error-1-exception.md) |
| 404 | Not Found | [`M404ErrorResponseError1Exception`](../../doc/models/m404-error-response-error-1-exception.md) |
| 405 | Method Not Allowed | [`M405ErrorResponseError1Exception`](../../doc/models/m405-error-response-error-1-exception.md) |
| 429 | Too Many Requests | [`M429ErrorResponseError1Exception`](../../doc/models/m429-error-response-error-1-exception.md) |
| 500 | Internal Server Error | [`M500ErrorResponseError1Exception`](../../doc/models/m500-error-response-error-1-exception.md) |
| 503 | Service Unavailable | [`M503ErrorResponseError1Exception`](../../doc/models/m503-error-response-error-1-exception.md) |


# Active

This API retrieves the list of active sessions for a given set of EMAIds

```csharp
ActiveAsync(
    string emaId,
    Guid requestId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `emaId` | `string` | Query, Required | Emobility Account Identifier(Ema-ID) |
| `requestId` | `Guid` | Header, Required | A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request. |

## Response Type

[`Task<Models.ActiveResponse200Json>`](../../doc/models/active-response-200-json.md)

## Example Usage

```csharp
string emaId = "NL-TNM-C0216599X-A";
Guid requestId = new Guid("eb621f45-a543-4d9a-a934-2f223b263c42");
try
{
    ActiveResponse200Json result = await chargingController.ActiveAsync(
        emaId,
        requestId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "Status": "SUCCESS",
  "Data": [
    {
      "EmaId": "NL-TNM-C0216599X-A",
      "EvseId": "NL*TNM*EVIRTUALCP0002*0",
      "Id": "260f17a9-52d4-4b40-ae74-83832b538975",
      "StartedAt": "2022-10-21T09:11:23.455Z",
      "SessionState": "started",
      "SessionCode": null,
      "SessionMessage": null,
      "UserId": "96f69b3b-8ad4-487a-baaa-f1d3db741e88"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ErrorResponseError1Exception`](../../doc/models/m400-error-response-error-1-exception.md) |
| 401 | Unauthorized | [`M401ErrorResponseError1Exception`](../../doc/models/m401-error-response-error-1-exception.md) |
| 404 | Session not found or Session has already been stopped. Map 410 Error message into 404. | [`M404ErrorResponseError1Exception`](../../doc/models/m404-error-response-error-1-exception.md) |
| 405 | Method Not Allowed | [`M405ErrorResponseError1Exception`](../../doc/models/m405-error-response-error-1-exception.md) |
| 429 | Too Many Requests | [`M429ErrorResponseError1Exception`](../../doc/models/m429-error-response-error-1-exception.md) |
| 500 | Internal Server Error | [`M500ErrorResponseError1Exception`](../../doc/models/m500-error-response-error-1-exception.md) |
| 503 | Returned when a connectivity failure is encountered like DB connection failed, endpoint failed etc or when max number of retries are completed | [`M503ErrorResponseError1Exception`](../../doc/models/m503-error-response-error-1-exception.md) |

