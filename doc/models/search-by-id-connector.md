
# Search by Id Connector

An EVSE can have one or many Connectors. Each Connector will normally have a different socket / cable and only one can be used to charge at a time.

## Structure

`SearchByIdConnector`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | Internal identifier used to refer to this Connector |
| `ExternalId` | `string` | Optional | Identifier of the Evse as given by the Operator, unique for the containing EVSE' |
| `ConnectorType` | [`ConnectorVOConnectorTypeEnum?`](../../doc/models/connector-vo-connector-type-enum.md) | Optional | Type of the connector in the EVSE unit. |
| `ElectricalProperties` | [`ElectricalPropertiesV2`](../../doc/models/electrical-properties-v2.md) | Optional | Electrical Properties of the Connector |
| `Tariffs` | [`List<TariffV2>`](../../doc/models/tariff-v2.md) | Optional | Tariffs applicable to this Connector |

## Example (as JSON)

```json
{
  "uid": "2",
  "externalId": "01000861_1_21",
  "connectorType": "Type2",
  "electricalProperties": {
    "powerType": "AC1Phase",
    "voltage": 110.62,
    "amperage": 46.4,
    "maxElectricPower": 232.04
  },
  "tariffs": [
    {
      "tariffId": "tariffId4",
      "tariffType": "DRIVER",
      "powerRange": {
        "min": 102,
        "max": 20
      },
      "internalId": "internalId2",
      "operatorId": "operatorId8",
      "providerId": "providerId2",
      "currency": "currency8",
      "tariffAltText": [
        {
          "language": "language8",
          "text": "text6"
        }
      ],
      "minPrice": 189.42,
      "maxPrice": 247.64,
      "elements": [
        {
          "priceComponents": [
            {
              "type": "TIME",
              "stepSize": 124,
              "price": 196.82,
              "vat": 137.74
            },
            {
              "type": "TIME",
              "stepSize": 124,
              "price": 196.82,
              "vat": 137.74
            },
            {
              "type": "TIME",
              "stepSize": 124,
              "price": 196.82,
              "vat": 137.74
            }
          ],
          "restrictions": {
            "startTime": "startTime0",
            "endTime": "endTime2",
            "startDate": "2016-03-13",
            "endDate": "2016-03-13",
            "minKwh": 247.22
          }
        }
      ],
      "startDateTime": "2016-03-13T12:52:32.123Z",
      "endDateTime": "2016-03-13T12:52:32.123Z",
      "lastUpdated": "2016-03-13T12:52:32.123Z",
      "createdBy": "createdBy4"
    },
    {
      "tariffId": "tariffId4",
      "tariffType": "DRIVER",
      "powerRange": {
        "min": 102,
        "max": 20
      },
      "internalId": "internalId2",
      "operatorId": "operatorId8",
      "providerId": "providerId2",
      "currency": "currency8",
      "tariffAltText": [
        {
          "language": "language8",
          "text": "text6"
        }
      ],
      "minPrice": 189.42,
      "maxPrice": 247.64,
      "elements": [
        {
          "priceComponents": [
            {
              "type": "TIME",
              "stepSize": 124,
              "price": 196.82,
              "vat": 137.74
            },
            {
              "type": "TIME",
              "stepSize": 124,
              "price": 196.82,
              "vat": 137.74
            },
            {
              "type": "TIME",
              "stepSize": 124,
              "price": 196.82,
              "vat": 137.74
            }
          ],
          "restrictions": {
            "startTime": "startTime0",
            "endTime": "endTime2",
            "startDate": "2016-03-13",
            "endDate": "2016-03-13",
            "minKwh": 247.22
          }
        }
      ],
      "startDateTime": "2016-03-13T12:52:32.123Z",
      "endDateTime": "2016-03-13T12:52:32.123Z",
      "lastUpdated": "2016-03-13T12:52:32.123Z",
      "createdBy": "createdBy4"
    }
  ]
}
```

