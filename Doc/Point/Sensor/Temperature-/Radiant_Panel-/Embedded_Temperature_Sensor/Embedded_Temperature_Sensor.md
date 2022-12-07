[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Radiant_Panel_Temperature_Sensor](../Radiant_Panel_Temperature_Sensor.md) > [Embedded_Temperature_Sensor](#)
# Embedded_Temperature_Sensor

Measures the internal temperature of the radiant layer of the radiant heating and cooling HVAC system.


**Display name:** Embedded Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Embedded_Temperature_Sensor;1

---

## Child interfaces
* [Core_Temperature_Sensor](Core_Temperature_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name
* **[Temperature_Sensor](../../Temperature_Sensor.md):** lastKnownValue

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
