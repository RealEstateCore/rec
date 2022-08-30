[Index](../../../../Index.md) > [Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Water_Alarm](../Water_Alarm.md) > [Water_Level_Alarm](#)
# Water_Level_Alarm

**Display name:** Water Level Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Level_Alarm;1

---

## Child interfaces
* [Collection_Basin_Water_Level_Alarm](Collection_Basin_Water_Level_Alarm.md)
* [Max_Water_Level_Alarm](Max_Water_Level_Alarm.md)
* [Min_Water_Level_Alarm](Min_Water_Level_Alarm.md)

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
