[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Failure_Alarm](#)
# Failure_Alarm

Alarms that indicate the failure of devices, equipment, systems and control loops


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
* **[Alarm](../Alarm.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
