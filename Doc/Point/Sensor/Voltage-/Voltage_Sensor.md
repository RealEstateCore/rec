[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Voltage_Sensor](#)
# Voltage_Sensor

Measures the voltage of an electrical device or object


**Display name:** Voltage Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Voltage_Sensor;1

---

## Child interfaces
* [Battery_Voltage_Sensor](Battery-.md)
* [DC_Bus_Voltage_Sensor](DC_Bus-.md)
* [Output_Voltage_Sensor](Output-.md)

---

## Components

|Name|Display name|Description|Schema|
|-|-|-|-|
|lastKnownValue|**en**: last known value||[VoltageObservation](../../../Event/Point-/ObservationEvent/VoltageObservation.md)|

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
