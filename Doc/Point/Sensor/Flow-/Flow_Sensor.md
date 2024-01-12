[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Flow_Sensor](#)
# Flow_Sensor

Measures the rate of flow of some substance


**Display name:** Flow Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Flow_Sensor;1

---

## Child interfaces
* [Air_Flow_Sensor](Air-/Air_Flow_Sensor.md)
* [Natural_Gas_Flow_Sensor](Natural_Gas-.md)
* [Water_Flow_Sensor](Water-/Water_Flow_Sensor.md)

---

## Components

|Name|Display name|Description|Schema|
|-|-|-|-|
|lastKnownValue|**en**: last known value||[VolumeFlowRateObservation](../../../Event/Point-/ObservationEvent/VolumeFlowRateObservation.md)|

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
