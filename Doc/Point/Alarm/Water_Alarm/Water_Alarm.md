[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Water_Alarm](#)
# Water_Alarm

**Display name:** Water Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Alarm;1

---

## Child interfaces
* [Deionized_Water_Alarm](Deionized_Water_Alarm.md)
* [No_Water_Alarm](No_Water_Alarm.md)
* [Water_Loss_Alarm](Water_Loss_Alarm.md)
* [Water_Temperature_Alarm](Water_Temperature_Alarm/Water_Temperature_Alarm.md)
* [Water_Level_Alarm](Water_Level_Alarm/Water_Level_Alarm.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

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
