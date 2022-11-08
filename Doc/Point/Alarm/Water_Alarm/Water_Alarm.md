[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Water_Alarm](#)
# Water_Alarm

Alarm that indicates an undesirable event with a pipe, container, or equipment carrying water e.g. water leak


**Display name:** Water Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Alarm;1

---

## Child interfaces
* [Water_Loss_Alarm](Water_Loss_Alarm.md)
* [No_Water_Alarm](No_Water_Alarm.md)
* [Deionized_Water_Alarm](Deionized_Water_Alarm.md)
* [Water_Level_Alarm](Water_Level_Alarm/Water_Level_Alarm.md)
* [Water_Temperature_Alarm](Water_Temperature_Alarm/Water_Temperature_Alarm.md)

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
### General
* [Point](../../Point.md).isPointOf
* [Space](../../../Space/Space.md).isLocationOf
* [Agent](../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../Collection/Portfolio.md).includes
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
