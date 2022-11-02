[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Cycle_Alarm](#)
# Cycle_Alarm

An alarm that indicates off-normal conditions associated with HVAC cycles


**Display name:** Cycle Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Cycle_Alarm;1

---

## Child interfaces
* [Short_Cycle_Alarm](Short_Cycle_Alarm.md)

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
