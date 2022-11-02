[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Temperature_Alarm](#)
# Temperature_Alarm

An alarm that indicates the off-normal conditions associated with temperature.


**Display name:** Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_Alarm;1

---

## Child interfaces
* [Low_Temperature_Alarm](Low_Temperature_Alarm/Low_Temperature_Alarm.md)
* [High_Temperature_Alarm](High_Temperature_Alarm/High_Temperature_Alarm.md)
* [Water_Temperature_Alarm](../Water_Alarm/Water_Temperature_Alarm/Water_Temperature_Alarm.md)
* [Air_Temperature_Alarm](Air_Temperature_Alarm/Air_Temperature_Alarm.md)

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
