[Index](../../index.md) > [Point](../Point.md) > [Status](Status.md) > [Stages_Status](#)
# Stages_Status

Indicates which stage a control loop or equipment is in


**Display name:** Stages Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Stages_Status;1

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
