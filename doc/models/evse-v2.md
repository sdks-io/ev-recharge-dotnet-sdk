
# Evse V2

Each Location will contain one or more EVSEs (Electric Vehicle Supply Equipment). Each EVSE is capable of charging one car at a time.

## Structure

`EvseV2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | Internal identifier used to refer to single individual  EVSE unit. |
| `ExternalId` | `string` | Optional | Identifier of the Evse as given by the Operator, unique for that Operator |
| `EvseId` | `string` | Optional | Standard EVSEId identifier (ISO-IEC-15118) |
| `Status` | [`EvseVOStatusEnum?`](../../doc/models/evse-vo-status-enum.md) | Optional | The current status of the EVSE units availability |
| `Updated` | `string` | Optional | ISO8601-compliant UTC datetime of the last update of the EVSE |
| `PhysicalReference` | `string` | Optional | An optional number/string printed on the outside of the EVSE for visual identification |
| `Connectors` | [`List<ConnectorV2>`](../../doc/models/connector-v2.md) | Optional | List of all connectors available on this EVSE unit. |
| `AuthorizationMethods` | [`List<SingleLocationMarkerAuthorizationMethodsItemsEnum>`](../../doc/models/single-location-marker-authorization-methods-items-enum.md) | Optional | Methods that can be used to Authorize sessions on this EVSE |

## Example (as JSON)

```json
{
  "uid": "NL*MKS*E0000001*0_1",
  "externalId": "01001188_1",
  "evseId": "NL*TNM*E01000401*0",
  "status": "Available",
  "updated": "10/06/2021 10:44:24",
  "physicalReference": "Green",
  "authorizationMethods": [
    "NewMotionApp"
  ]
}
```

