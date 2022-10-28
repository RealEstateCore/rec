[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Humidity_Alarm](#)
# Humidity_Alarm

An alarm that indicates the off-normal conditions associated with the concentration of water vapor in the air.


**Display name:** Humidity Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Humidity_Alarm;1

---

## Child interfaces
* [High_Humidity_Alarm](High_Humidity_Alarm.md)
* [Low_Humidity_Alarm](Low_Humidity_Alarm.md)

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
