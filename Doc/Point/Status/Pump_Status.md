[Index](../../index.md) > [Point](../Point.md) > [Status](Status.md) > [Pump_Status](#)
# Pump_Status

Status of a pump


**Display name:** Pump Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Pump_Status;1

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
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../Event/PointEvent/ExceptionEvent.md).sourcePoint
