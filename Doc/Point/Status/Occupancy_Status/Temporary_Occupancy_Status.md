[Index](../../../index.md) > [Point](../../Point.md) > [Status](../Status.md) > [Occupancy_Status](Occupancy_Status.md) > [Temporary_Occupancy_Status](#)
# Temporary_Occupancy_Status

For systems that differentiate between scheduled occupied/unoccupied mode, this indicates if a space is temporarily occupied when it would otherwise be unoccupied


**Display name:** Temporary Occupancy Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temporary_Occupancy_Status;1

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Status](../Status.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
