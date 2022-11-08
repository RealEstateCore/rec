[Index](../../../../index.md) > [Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Temperature_Alarm](../Temperature_Alarm.md) > [High_Temperature_Alarm](#)
# High_Temperature_Alarm

An alarm that indicates high temperature.


**Display name:** High Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:High_Temperature_Alarm;1

---

## Child interfaces
* [High_Return_Air_Temperature_Alarm](../Air_Temperature_Alarm/Return_Air_Temperature_Alarm/High_Return_Air_Temperature_Alarm.md)
* [High_Supply_Air_Temperature_Alarm](../Air_Temperature_Alarm/Supply_Air_Temperature_Alarm/High_Supply_Air_Temperature_Alarm.md)
* [High_Discharge_Air_Temperature_Alarm](../Air_Temperature_Alarm/Discharge_Air_Temperature_Alarm/High_Discharge_Air_Temperature_Alarm.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Alarm](../../Alarm.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
