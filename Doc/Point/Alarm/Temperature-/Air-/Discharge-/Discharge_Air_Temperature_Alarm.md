[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Alarm](../../../Alarm.md) > [Temperature_Alarm](../../Temperature_Alarm.md) > [Air_Temperature_Alarm](../Air_Temperature_Alarm.md) > [Discharge_Air_Temperature_Alarm](#)
# Discharge_Air_Temperature_Alarm

An alarm that indicates the off-normal conditions associated with the temperature of discharge air.


**Display name:** Discharge Air Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Alarm;1

---

## Child interfaces
* [High_Discharge_Air_Temperature_Alarm](High-.md)
* [Low_Discharge_Air_Temperature_Alarm](Low-.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Alarm](../../../Alarm.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name

---

## Target Of
### General
* [Point](../../../../Point.md).isPointOf
* [Agent](../../../../../Agent/Agent.md).owns
* [Space](../../../../../Space/Space.md).isLocationOf
* [Equipment](../../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../../../Collection/Equipment-.md).feeds
* [Lease](../../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../Event/Point-/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
