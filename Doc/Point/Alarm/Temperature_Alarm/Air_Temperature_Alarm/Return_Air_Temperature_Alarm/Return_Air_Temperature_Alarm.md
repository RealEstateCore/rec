[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Alarm](../../../Alarm.md) > [Temperature_Alarm](../../Temperature_Alarm.md) > [Air_Temperature_Alarm](../Air_Temperature_Alarm.md) > [Return_Air_Temperature_Alarm](#)
# Return_Air_Temperature_Alarm

An alarm that indicates the off-normal conditions associated with the temperature of return air.


**Display name:** Return Air Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Return_Air_Temperature_Alarm;1

---

## Child interfaces
* [Low_Return_Air_Temperature_Alarm](Low_Return_Air_Temperature_Alarm.md)
* [High_Return_Air_Temperature_Alarm](High_Return_Air_Temperature_Alarm.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Alarm](../../../Alarm.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
