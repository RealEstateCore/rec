[Index](../../../Index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Failure_Alarm](#)
# Failure_Alarm

**Display name:** Failure Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Failure_Alarm;1

---

## Child interfaces
* [Sensor_Failure_Alarm](Sensor_Failure_Alarm.md)
* [Unit_Failure_Alarm](Unit_Failure_Alarm.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

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
