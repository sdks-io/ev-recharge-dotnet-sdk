
# Tariff V2

Tariff metadata aligned with TariffV2 GraphQL schema

## Structure

`TariffV2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TariffId` | `string` | Required | Unique identifier for the tariff |
| `TariffType` | [`TariffTypeEnum`](../../doc/models/tariff-type-enum.md) | Required | Tariff type classification |
| `PowerRange` | [`PowerRange`](../../doc/models/power-range.md) | Required | - |
| `InternalId` | `string` | Required | Internal identifier used by the platform |
| `OperatorId` | `string` | Required | Unique identifier of the operator |
| `ProviderId` | `string` | Required | Unique identifier of the provider |
| `Currency` | `string` | Required | ISO 4217 Currency Code |
| `TariffAltText` | [`List<TariffAltText>`](../../doc/models/tariff-alt-text.md) | Required | - |
| `MinPrice` | `double` | Required | - |
| `MaxPrice` | `double` | Required | - |
| `Elements` | [`List<TariffElement>`](../../doc/models/tariff-element.md) | Required | - |
| `StartDateTime` | `DateTime` | Required | - |
| `EndDateTime` | `DateTime` | Required | - |
| `LastUpdated` | `DateTime` | Required | - |
| `CreatedBy` | `string` | Required | Identifier of the actor who created the tariff |

## Example

```csharp
using ShellEV.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

TariffV2 tariffV2 = new TariffV2
{
    TariffId = "123e4567-e89b-12d3-a456-426614174000",
    TariffType = TariffTypeEnum.REIMBURSEMENT,
    PowerRange = new PowerRange
    {
        Min = 0,
        Max = 100,
    },
    InternalId = "123e4567-e89b-12d3-a456-426614174000",
    OperatorId = "AT-HTB",
    ProviderId = "Shell_RP_2",
    Currency = "EUR",
    TariffAltText = new List<TariffAltText>
    {
        new TariffAltText
        {
            Language = "en",
            Text = "€0.30 per kWh",
        },
    },
    MinPrice = 0.3,
    MaxPrice = 999,
    Elements = new List<TariffElement>
    {
        new TariffElement
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
        },
    },
    StartDateTime = DateTime.ParseExact("2021-10-06T10:44:24Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndDateTime = DateTime.ParseExact("2021-10-06T10:44:24Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    LastUpdated = DateTime.ParseExact("2021-10-06T10:44:24Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    CreatedBy = "STAGE_API",
};
```

