[Index](../../../../Index.md) > [Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Air_Alarm](../Air_Alarm.md) > [Air_Flow_Alarm](#)
# Air_Flow_Alarm

**Display name:** Air Flow Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Flow_Alarm;1

---

## Child interfaces
* [Air_Flow_Loss_Alarm](Air_Flow_Loss_Alarm.md)
* [High_Air_Flow_Alarm](High_Air_Flow_Alarm.md)
* [Low_Air_Flow_Alarm](Low_Air_Flow_Alarm/Low_Air_Flow_Alarm.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

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
