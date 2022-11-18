[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Temperature_Sensor](../Temperature_Sensor.md) > [Water_Temperature_Sensor](#)
# Water_Temperature_Sensor

Measures the temperature of water


**Display name:** Water Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Temperature_Sensor;1

---

## Child interfaces
* [Chilled_Water_Temperature_Sensor](Chilled-/Chilled_Water_Temperature_Sensor.md)
* [Collection_Basin_Water_Temperature_Sensor](Collection_Basin-.md)
* [Condenser_Water_Temperature_Sensor](Condenser-/Condenser_Water_Temperature_Sensor.md)
* [Domestic_Hot_Water_Temperature_Sensor](Domestic_Hot-/Domestic_Hot_Water_Temperature_Sensor.md)
* [Entering_Hot_Water_Temperature_Sensor](Entering_Hot-/Entering_Hot_Water_Temperature_Sensor.md)
* [Entering_Water_Temperature_Sensor](Entering-.md)
* [Leaving_Hot_Water_Temperature_Sensor](Leaving_Hot-/Leaving_Hot_Water_Temperature_Sensor.md)
* [Leaving_Water_Temperature_Sensor](Leaving-/Leaving_Water_Temperature_Sensor.md)
* [Water_Differential_Temperature_Sensor](Water_Differential_Temperature_Sensor/Water_Differential_Temperature_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name
* **[Temperature_Sensor](../Temperature_Sensor.md):** lastKnownValue

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
