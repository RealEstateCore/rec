[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Pressure_Alarm](#)
# Pressure_Alarm

**Display name:** Pressure Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Pressure_Alarm;1

---

## Child interfaces
* [High_Head_Pressure_Alarm](High_Head_Pressure_Alarm.md)
* [Low_Suction_Pressure_Alarm](Low_Suction_Pressure_Alarm.md)

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
