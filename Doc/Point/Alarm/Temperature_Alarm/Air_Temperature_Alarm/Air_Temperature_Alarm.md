[Index](../../../../index.md) > [Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Temperature_Alarm](../Temperature_Alarm.md) > [Air_Temperature_Alarm](#)
# Air_Temperature_Alarm

**Display name:** Air Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Temperature_Alarm;1

---

## Child interfaces
* [Discharge_Air_Temperature_Alarm](Discharge_Air_Temperature_Alarm/Discharge_Air_Temperature_Alarm.md)
* [Return_Air_Temperature_Alarm](Return_Air_Temperature_Alarm/Return_Air_Temperature_Alarm.md)
* [Supply_Air_Temperature_Alarm](Supply_Air_Temperature_Alarm/Supply_Air_Temperature_Alarm.md)

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
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
