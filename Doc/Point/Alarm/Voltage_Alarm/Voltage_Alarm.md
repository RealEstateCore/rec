[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Voltage_Alarm](#)
# Voltage_Alarm

An alarm that indicates the voltage is not in a normal state.


**Display name:** Voltage Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Voltage_Alarm;1

---

## Child interfaces
* [Low_Voltage_Alarm](Low_Voltage_Alarm.md)

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
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
