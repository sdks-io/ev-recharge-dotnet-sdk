
# Tariff Element

## Structure

`TariffElement`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PriceComponents` | [`List<PriceComponent>`](../../doc/models/price-component.md) | Required | - |
| `Restrictions` | [`Restrictions`](../../doc/models/restrictions.md) | Optional | - |

## Example

```csharp
using ShellEV.Standard.Models;
using System.Collections.Generic;

TariffElement tariffElement = new TariffElement
{
    PriceComponents = new List<PriceComponent>
    {
        new PriceComponent
        {
            Type = TypeEnum.FLAT,
            StepSize = 1,
            Price = 0.3,
            Vat = 21,
        },
    },
    Restrictions = new Restrictions
    {
        StartTime = "startTime0",
        EndTime = "endTime2",
        StartDate = DateTime.Parse("2016-03-13"),
        EndDate = DateTime.Parse("2016-03-13"),
        MinKwh = 247.22,
    },
};
```

