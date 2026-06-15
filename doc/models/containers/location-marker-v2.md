
# Location Marker V2

## Class Name

`LocationMarkerV2`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`SingleLocationMarkerV2`](../../../doc/models/single-location-marker-v2.md) | LocationMarkerV2.FromSingleLocationMarkerV2(SingleLocationMarkerV2 singleLocationMarkerV2) |
| [`MultiLocationMarkerV2`](../../../doc/models/multi-location-marker-v2.md) | LocationMarkerV2.FromMultiLocationMarkerV2(MultiLocationMarkerV2 multiLocationMarkerV2) |

## SingleLocationMarkerV2

### Initialization Code

#### Example

```csharp
LocationMarkerV2 value = LocationMarkerV2.FromSingleLocationMarkerV2(
    new SingleLocationMarkerV2
    {
        MarkerType = "SingleLocation",
        Status = SingleLocationMarkerStatusEnum.Available,
        EvseCount = 12,
        LocationCount = 6,
        LocationUid = "2057411",
        OperatorName = "TheNewMotion",
    }
);
```

## MultiLocationMarkerV2

### Initialization Code

#### Example

```csharp
LocationMarkerV2 value = LocationMarkerV2.FromMultiLocationMarkerV2(
    new MultiLocationMarkerV2
    {
        MarkerType = "MultiLocation",
        LocationCount = 6,
        EvseCount = 10,
        MaxPower = 42,
        OperatorName = "TheNewMotion",
    }
);
```

