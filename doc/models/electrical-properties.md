
# Electrical Properties

Electrical Properties of the Connector

## Structure

`ElectricalProperties`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PowerType` | [`ElectricalPropertiesPowerTypeEnum?`](../../doc/models/electrical-properties-power-type-enum.md) | Optional | - |
| `Voltage` | `double?` | Optional | Voltage in Volts for this connector |
| `Amperage` | `double?` | Optional | Electric Current in Amperes for this connector |
| `MaxElectricPower` | `double?` | Optional | Power in Kilowatts for this connector |

## Example (as JSON)

```json
{
  "voltage": 230.0,
  "amperage": 16.0,
  "maxElectricPower": 3.7,
  "powerType": "DC"
}
```

