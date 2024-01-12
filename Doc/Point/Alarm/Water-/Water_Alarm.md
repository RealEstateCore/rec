[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Water_Alarm](#)
# Water_Alarm

Alarm that indicates an undesirable event with a pipe, container, or equipment carrying water e.g. water leak


**Display name:** Water Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Alarm;1

---

## Child interfaces
* [Deionized_Water_Alarm](Deionized-.md)
* [No_Water_Alarm](No-.md)
* [Water_Level_Alarm](Water_Level_Alarm/Water_Level_Alarm.md)
* [Water_Loss_Alarm](Water_Loss_Alarm.md)
* [Water_Temperature_Alarm](Water_Temperature_Alarm/Water_Temperature_Alarm.md)

---

## Components

### Inherited Components
* **[Alarm](../Alarm.md):** lastKnownValue

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name

---

## Target Of
### General
* [Point](../../Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [System](../../../Collection/System/System.md).includes
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../Asset/Asset.md).hasPoint
* [ExceptionEvent](../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
