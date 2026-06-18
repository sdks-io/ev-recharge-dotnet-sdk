
# Electrical Properties V2

Electrical Properties of the Connector

## Structure

`ElectricalPropertiesV2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PowerType` | [`ElectricalPropertiesPowerTypeEnum?`](../../doc/models/electrical-properties-power-type-enum.md) | Optional | Power Type used in this connector. |
| `Voltage` | `double?` | Optional | Voltage in Volts for this connector |
| `Amperage` | `double?` | Optional | Electric Current in Amperes for this connector |
| `MaxElectricPower` | `double?` | Optional | Power in Kilowatts for this connector |

## Example

```csharp
using ShellEV.Standard.Models;

ElectricalPropertiesV2 electricalPropertiesV2 = new ElectricalPropertiesV2
{
    PowerType = ElectricalPropertiesPowerTypeEnum.AC1Phase,
    Voltage = 230,
    Amperage = 16,
    MaxElectricPower = 3.7,
};
```

