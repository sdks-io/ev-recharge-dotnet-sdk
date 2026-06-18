
# Tariff Alt Text

## Structure

`TariffAltText`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Language` | `string` | Required | ISO language code |
| `Text` | `string` | Required | Human readable tariff description |

## Example

```csharp
using ShellEV.Standard.Models;

TariffAltText tariffAltText = new TariffAltText
{
    Language = "en",
    Text = "€0.30 per kWh",
};
```

