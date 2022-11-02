[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Leak_Alarm](#)
# Leak_Alarm

An alarm that indicates leaks occured in systems containing fluids


**Display name:** Leak Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leak_Alarm;1

---

## Child interfaces
* [Condensate_Leak_Alarm](Condensate_Leak_Alarm.md)

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
