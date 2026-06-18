
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

## Example

```csharp
using ShellEV.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

SearchByIdConnector searchByIdConnector = new SearchByIdConnector
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
    Tariffs = new List<TariffV2>
    {
        new TariffV2
        {
            TariffId = "tariffId4",
            TariffType = TariffTypeEnum.DRIVER,
            PowerRange = new PowerRange
            {
                Min = 102,
                Max = 20,
            },
            InternalId = "internalId2",
            OperatorId = "operatorId8",
            ProviderId = "providerId2",
            Currency = "currency8",
            TariffAltText = new List<TariffAltText>
            {
                new TariffAltText
                {
                    Language = "language8",
                    Text = "text6",
                },
            },
            MinPrice = 189.42,
            MaxPrice = 247.64,
            Elements = new List<TariffElement>
            {
                new TariffElement
                {
                    PriceComponents = new List<PriceComponent>
                    {
                        new PriceComponent
                        {
                            Type = TypeEnum.TIME,
                            StepSize = 124,
                            Price = 196.82,
                            Vat = 137.74,
                        },
                        new PriceComponent
                        {
                            Type = TypeEnum.TIME,
                            StepSize = 124,
                            Price = 196.82,
                            Vat = 137.74,
                        },
                        new PriceComponent
                        {
                            Type = TypeEnum.TIME,
                            StepSize = 124,
                            Price = 196.82,
                            Vat = 137.74,
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
            StartDateTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            EndDateTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            LastUpdated = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            CreatedBy = "createdBy4",
        },
        new TariffV2
        {
            TariffId = "tariffId4",
            TariffType = TariffTypeEnum.DRIVER,
            PowerRange = new PowerRange
            {
                Min = 102,
                Max = 20,
            },
            InternalId = "internalId2",
            OperatorId = "operatorId8",
            ProviderId = "providerId2",
            Currency = "currency8",
            TariffAltText = new List<TariffAltText>
            {
                new TariffAltText
                {
                    Language = "language8",
                    Text = "text6",
                },
            },
            MinPrice = 189.42,
            MaxPrice = 247.64,
            Elements = new List<TariffElement>
            {
                new TariffElement
                {
                    PriceComponents = new List<PriceComponent>
                    {
                        new PriceComponent
                        {
                            Type = TypeEnum.TIME,
                            StepSize = 124,
                            Price = 196.82,
                            Vat = 137.74,
                        },
                        new PriceComponent
                        {
                            Type = TypeEnum.TIME,
                            StepSize = 124,
                            Price = 196.82,
                            Vat = 137.74,
                        },
                        new PriceComponent
                        {
                            Type = TypeEnum.TIME,
                            StepSize = 124,
                            Price = 196.82,
                            Vat = 137.74,
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
            StartDateTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            EndDateTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            LastUpdated = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            CreatedBy = "createdBy4",
        },
        new TariffV2
        {
            TariffId = "tariffId4",
            TariffType = TariffTypeEnum.DRIVER,
            PowerRange = new PowerRange
            {
                Min = 102,
                Max = 20,
            },
            InternalId = "internalId2",
            OperatorId = "operatorId8",
            ProviderId = "providerId2",
            Currency = "currency8",
            TariffAltText = new List<TariffAltText>
            {
                new TariffAltText
                {
                    Language = "language8",
                    Text = "text6",
                },
            },
            MinPrice = 189.42,
            MaxPrice = 247.64,
            Elements = new List<TariffElement>
            {
                new TariffElement
                {
                    PriceComponents = new List<PriceComponent>
                    {
                        new PriceComponent
                        {
                            Type = TypeEnum.TIME,
                            StepSize = 124,
                            Price = 196.82,
                            Vat = 137.74,
                        },
                        new PriceComponent
                        {
                            Type = TypeEnum.TIME,
                            StepSize = 124,
                            Price = 196.82,
                            Vat = 137.74,
                        },
                        new PriceComponent
                        {
                            Type = TypeEnum.TIME,
                            StepSize = 124,
                            Price = 196.82,
                            Vat = 137.74,
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
            StartDateTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            EndDateTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            LastUpdated = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            CreatedBy = "createdBy4",
        },
    },
};
```

