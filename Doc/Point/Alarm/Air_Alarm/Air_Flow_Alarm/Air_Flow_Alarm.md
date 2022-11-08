[Index](../../../../index.md) > [Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Air_Alarm](../Air_Alarm.md) > [Air_Flow_Alarm](#)
# Air_Flow_Alarm

An alarm related to air flow.


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
* **[Alarm](../../Alarm.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### General
* [Point](../../../Point.md).isPointOf
* [Space](../../../../Space/Space.md).isLocationOf
* [Agent](../../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
