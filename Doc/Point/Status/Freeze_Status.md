[Index](../../index.md) > [Point](../Point.md) > [Status](Status.md) > [Freeze_Status](#)
# Freeze_Status

Indicates if a substance contained within a vessel has frozen


**Display name:** Freeze Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Freeze_Status;1

---

## Relationships

### Inherited Relationships
* **[Point](../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Status](Status.md):** lastKnownValue
* **[Point](../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
