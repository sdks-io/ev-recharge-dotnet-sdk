
# Connector V2

An EVSE can have one or many Connectors. Each Connector will normally have a different socket / cable and only one can be used to charge at a time.

## Structure

`ConnectorV2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | Internal identifier used to refer to this Connector |
| `ExternalId` | `string` | Optional | Identifier of the Evse as given by the Operator, unique for the containing EVSE' |
| `ConnectorType` | [`ConnectorVOConnectorTypeEnum?`](../../doc/models/connector-vo-connector-type-enum.md) | Optional | Type of the connector in the EVSE unit. |
| `ElectricalProperties` | [`ElectricalPropertiesV2`](../../doc/models/electrical-properties-v2.md) | Optional | Electrical Properties of the Connector |

## Example

```csharp
using ShellEV.Standard.Models;

ConnectorV2 connectorV2 = new ConnectorV2
{
    Uid = "2",
    ExternalId = "01000861_1_21",
    ConnectorType = ConnectorVOConnectorTypeEnum.Type2,
    ElectricalProperties = new ElectricalPropertiesV2
    {
        PowerType = ElectricalPropertiesPowerTypeEnum.AC1Phase,
        Voltage = 110.62,
        Amperage = 46.4,
        MaxElectricPower = 232.04,
    },
};
```

