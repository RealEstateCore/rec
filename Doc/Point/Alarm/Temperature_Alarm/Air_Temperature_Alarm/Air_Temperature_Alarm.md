[Index](../../../../index.md) > [Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Temperature_Alarm](../Temperature_Alarm.md) > [Air_Temperature_Alarm](#)
# Air_Temperature_Alarm

An alarm that indicates the off-normal conditions associated with the temperature of air.


**Display name:** Air Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Temperature_Alarm;1

---

## Child interfaces
* [Return_Air_Temperature_Alarm](Return_Air_Temperature_Alarm/Return_Air_Temperature_Alarm.md)
* [Supply_Air_Temperature_Alarm](Supply_Air_Temperature_Alarm/Supply_Air_Temperature_Alarm.md)
* [Discharge_Air_Temperature_Alarm](Discharge_Air_Temperature_Alarm/Discharge_Air_Temperature_Alarm.md)

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
