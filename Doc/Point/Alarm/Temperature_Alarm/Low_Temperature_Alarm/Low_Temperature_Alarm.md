[Index](../../../../index.md) > [Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Temperature_Alarm](../Temperature_Alarm.md) > [Low_Temperature_Alarm](#)
# Low_Temperature_Alarm

An alarm that indicates low temperature.


**Display name:** Low Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Low_Temperature_Alarm;1

---

## Child interfaces
* [Low_Return_Air_Temperature_Alarm](../Air_Temperature_Alarm/Return_Air_Temperature_Alarm/Low_Return_Air_Temperature_Alarm.md)
* [Low_Supply_Air_Temperature_Alarm](../Air_Temperature_Alarm/Supply_Air_Temperature_Alarm/Low_Supply_Air_Temperature_Alarm.md)
* [Low_Discharge_Air_Temperature_Alarm](../Air_Temperature_Alarm/Discharge_Air_Temperature_Alarm/Low_Discharge_Air_Temperature_Alarm.md)

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
