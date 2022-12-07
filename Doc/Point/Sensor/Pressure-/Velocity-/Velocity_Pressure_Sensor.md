[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Pressure_Sensor](../Pressure_Sensor.md) > [Velocity_Pressure_Sensor](#)
# Velocity_Pressure_Sensor

Measures the difference between total pressure and static pressure


**Display name:** Velocity Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Velocity_Pressure_Sensor;1

---

## Child interfaces
* [Discharge_Air_Velocity_Pressure_Sensor](Discharge_Air-.md)
* [Exhaust_Air_Velocity_Pressure_Sensor](Exhaust_Air-.md)
* [Supply_Air_Velocity_Pressure_Sensor](Supply_Air-.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name
* **[Pressure_Sensor](../Pressure_Sensor.md):** lastKnownValue

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
* [ObservationEvent](../../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
