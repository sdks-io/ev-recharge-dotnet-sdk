
# Price Component

## Structure

`PriceComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`TypeEnum`](../../doc/models/type-enum.md) | Required | Type of the price component |
| `StepSize` | `int` | Required | Step size in seconds for TIME-based components, in kWh for ENERGY-based components, or 1 for FLAT components |
| `Price` | `double` | Required | Price per step in the specified currency for this price component |
| `Vat` | `double` | Required | VAT percentage applicable to this price component |

## Example

```csharp
using ShellEV.Standard.Models;

PriceComponent priceComponent = new PriceComponent
{
    Type = TypeEnum.FLAT,
    StepSize = 1,
    Price = 0.3,
    Vat = 21,
};
```

