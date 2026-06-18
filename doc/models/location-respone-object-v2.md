
# Location Respone Object V2

## Structure

`LocationResponeObjectV2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | Unique Internal identifier used to refer to this Location by Shell Recharge |
| `ExternalId` | `string` | Optional | Identifier as given by the Shell Recharge Operator, unique for that Operator |
| `Coordinates` | [`Coordinates`](../../doc/models/coordinates.md) | Optional | Coordinates of the Shell Recharge Site Location |
| `OperatorName` | `string` | Optional | Operator of this Shell Recharge Location |
| `Address` | [`Address`](../../doc/models/address.md) | Optional | Address of the Shell Recharge Location |
| `Accessibility` | [`AccessibilityV2`](../../doc/models/accessibility-v2.md) | Optional | Accessibility of the Location |
| `Evses` | [`List<EvseV2>`](../../doc/models/evse-v2.md) | Optional | - |
| `OpeningHours` | [`List<OpeningHoursObject>`](../../doc/models/opening-hours-object.md) | Optional | Optional Opening Hours of the Location. Please note that it is not available for all sites. |
| `Updated` | `string` | Optional | ISO8601-compliant UTC datetime of the last update of the location |
| `LocationType` | `string` | Optional | the type of the location. Could be "UNKNOWN". |
| `OperatorId` | `string` | Optional | Unique Id of the operator |
| `OpenTwentyFourSeven` | `bool?` | Optional | Whether the location is open 24/7 |

## Example

```csharp
using ShellEV.Standard.Models;

LocationResponeObjectV2 locationResponeObjectV2 = new LocationResponeObjectV2
{
    Uid = "NL*MKS*E0000001*0",
    ExternalId = "01001188",
    Coordinates = new Coordinates
    {
        Latitude = 39.14,
        Longitude = 36.94,
    },
    OperatorName = "TheNewMotion",
    Address = new Address
    {
        StreetAndNumber = "streetAndNumber2",
        PostalCode = "postalCode8",
        City = "city6",
        Country = "country0",
    },
    Updated = "2021-10-06T10:44:24Z",
    LocationType = "Unknown",
    OperatorId = "AT-HTB",
    OpenTwentyFourSeven = true,
};
```

