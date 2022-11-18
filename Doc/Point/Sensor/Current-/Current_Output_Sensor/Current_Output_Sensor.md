[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Current_Sensor](../Current_Sensor.md) > [Current_Output_Sensor](#)
# Current_Output_Sensor

Senses the amperes of electrical current produced as output by a device


**Display name:** Current Output Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Current_Output_Sensor;1

---

## Child interfaces
* [Photovoltaic_Current_Output_Sensor](Photovoltaic-.md)
* [PV_Current_Output_Sensor](PV-.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Current_Sensor](../Current_Sensor.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name

---

## Target Of
### General
* [Point](../../../Point.md).isPointOf
* [Agent](../../../../Agent/Agent.md).owns
* [Space](../../../../Space/Space.md).isLocationOf
* [Equipment](../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../../Collection/Equipment-.md).feeds
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/Point-/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
