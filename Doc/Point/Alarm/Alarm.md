[Index](../../index.md) > [Point](../Point.md) > [Alarm](#)
# Alarm

Alarm points are signals (either audible or visual) that alert an operator to an off-normal condition which requires some form of corrective action


**Display name:** Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Alarm;1

---

## Child interfaces
* [Air_Alarm](Air-/Air_Alarm.md)
* [Change_Filter_Alarm](Change_Filter-.md)
* [CO2_Alarm](CO2-/CO2_Alarm.md)
* [Communication_Loss_Alarm](Communication_Loss-.md)
* [Cycle_Alarm](Cycle-/Cycle_Alarm.md)
* [Emergency_Alarm](Emergency-/Emergency_Alarm.md)
* [Failure_Alarm](Failure-/Failure_Alarm.md)
* [Humidity_Alarm](Humidity-/Humidity_Alarm.md)
* [Leak_Alarm](Leak-/Leak_Alarm.md)
* [Liquid_Detection_Alarm](Liquid_Detection-.md)
* [Low_Battery_Alarm](Low_Battery-.md)
* [Luminance_Alarm](Luminance-.md)
* [Maintenance_Required_Alarm](Maintenance_Required-.md)
* [Overload_Alarm](Overload-.md)
* [Power_Alarm](Power-/Power_Alarm.md)
* [Pressure_Alarm](Pressure-/Pressure_Alarm.md)
* [Smoke_Alarm](Smoke-/Smoke_Alarm.md)
* [Temperature_Alarm](Temperature-/Temperature_Alarm.md)
* [Valve_Position_Alarm](Valve_Position-.md)
* [Voltage_Alarm](Voltage-/Voltage_Alarm.md)
* [Water_Alarm](Water-/Water_Alarm.md)

---

## Components

|Name|Display name|Description|Schema|
|-|-|-|-|
|lastKnownValue|**en**: last known value||[ExceptionEvent](../../Event/Point-/ExceptionEvent.md)|

---

## Relationships

### Inherited Relationships
* **[Point](../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name

---

## Target Of
### General
* [Point](../Point.md).isPointOf
* [Agent](../../Agent/Agent.md).owns
* [Space](../../Space/Space.md).isLocationOf
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [System](../../Collection/System/System.md).includes
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../Asset/Asset.md).hasPoint
* [ExceptionEvent](../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
