[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Alarm](../../../Alarm.md) > [Temperature_Alarm](../../Temperature_Alarm.md) > [Air_Temperature_Alarm](../Air_Temperature_Alarm.md) > [Return_Air_Temperature_Alarm](#)
# Return_Air_Temperature_Alarm

**Display name:** Return Air Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Return_Air_Temperature_Alarm;1

---

## Child interfaces
* [High_Return_Air_Temperature_Alarm](High_Return_Air_Temperature_Alarm.md)
* [Low_Return_Air_Temperature_Alarm](Low_Return_Air_Temperature_Alarm.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
