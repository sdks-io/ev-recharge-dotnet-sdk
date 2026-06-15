
# Location Marker

## Class Name

`LocationMarker`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`SingleLocationMarker`](../../../doc/models/single-location-marker.md) | LocationMarker.FromSingleLocationMarker(SingleLocationMarker singleLocationMarker) |
| [`MultiLocationMarker`](../../../doc/models/multi-location-marker.md) | LocationMarker.FromMultiLocationMarker(MultiLocationMarker multiLocationMarker) |

## SingleLocationMarker

### Initialization Code

#### Example

```csharp
LocationMarker value = LocationMarker.FromSingleLocationMarker(
    new SingleLocationMarker
    {
        MarkerType = "SingleLocation",
        UniqueKey = "2057411_1",
        Status = SingleLocationMarkerStatusEnum.Available,
        EvseCount = 12,
        MaxPower = 42,
        GeoHash = "sx",
        LocationUid = 2057411,
        OperatorId = "AT-HTB",
    }
);
```

## MultiLocationMarker

### Initialization Code

#### Example

```csharp
LocationMarker value = LocationMarker.FromMultiLocationMarker(
    new MultiLocationMarker
    {
        MarkerType = "MultiLocation",
        UniqueKey = "2060319_6",
        LocationCount = 6,
        EvseCount = 10,
        MaxPower = 42,
        GeoHash = "sx",
    }
);
```

