
# Address

Address of the Shell Recharge Location

## Structure

`Address`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StreetAndNumber` | `string` | Optional | Street Name and Number of the Shell Recharge Location |
| `PostalCode` | `string` | Optional | Postal Code of the Shell Recharge Location |
| `City` | `string` | Optional | City name of the Shell Recharge Location |
| `Country` | `string` | Optional | ISO 3166 Alpha-2 Country Code of the Shell Recharge Location |

## Example

```csharp
using ShellEV.Standard.Models;

Address address = new Address
{
    StreetAndNumber = "Maarssenbroeksedijk 33",
    PostalCode = "3542 DM",
    City = "Utrecht",
    Country = "NLD",
};
```

