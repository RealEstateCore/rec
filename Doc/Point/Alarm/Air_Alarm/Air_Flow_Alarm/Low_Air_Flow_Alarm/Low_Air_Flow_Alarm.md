[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Alarm](../../../Alarm.md) > [Air_Alarm](../../Air_Alarm.md) > [Air_Flow_Alarm](../Air_Flow_Alarm.md) > [Low_Air_Flow_Alarm](#)
# Low_Air_Flow_Alarm

An alarm that indicates that the air flow is lower than normal.


**Display name:** Low Air Flow Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Low_Air_Flow_Alarm;1

---

## Child interfaces
* [Low_Discharge_Air_Flow_Alarm](Low_Discharge_Air_Flow_Alarm.md)
* [Low_Supply_Air_Flow_Alarm](Low_Supply_Air_Flow_Alarm.md)

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
