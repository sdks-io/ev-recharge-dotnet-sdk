
# Chargesession Start Body

## Structure

`ChargesessionStartBody`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EvChargeNumber` | `string` | Required | Ev charge number<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `50` |
| `EvseId` | `string` | Required | This is the Electric Vehicle EquipmentID<br>**Constraints**: *Minimum Length*: `18`, *Maximum Length*: `36` |

## Example (as JSON)

```json
{
  "evChargeNumber": "NL-TNM-C00122045-K",
  "evseId": "NL*TNM*E02003451*0"
}
```

