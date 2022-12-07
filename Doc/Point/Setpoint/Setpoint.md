[Index](../../index.md) > [Point](../Point.md) > [Setpoint](#)
# Setpoint

A Setpoint is an input value at which the desired property is set


**Display name:** Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Setpoint;1

---

## Child interfaces
* [CO2_Setpoint](CO2-/CO2_Setpoint.md)
* [Current_Ratio_Setpoint](Current_Ratio-.md)
* [Damper_Position_Setpoint](Damper_Position-.md)
* [Deadband_Setpoint](Deadband-/Deadband_Setpoint.md)
* [Demand_Setpoint](Demand-/Demand_Setpoint.md)
* [Dewpoint_Setpoint](Dewpoint-.md)
* [Differential_Setpoint](Differential-/Differential_Setpoint.md)
* [Enthalpy_Setpoint](Enthalpy-.md)
* [Flow_Setpoint](Flow-/Flow_Setpoint.md)
* [Frequency_Setpoint](Frequency-.md)
* [Humidity_Setpoint](Humidity-/Humidity_Setpoint.md)
* [Illuminance_Setpoint](Illuminance-.md)
* [Load_Setpoint](Load-/Load_Setpoint.md)
* [Luminance_Setpoint](Luminance-.md)
* [Pressure_Setpoint](Pressure-/Pressure_Setpoint.md)
* [Reset_Setpoint](Reset-/Reset_Setpoint.md)
* [Speed_Setpoint](Speed-/Speed_Setpoint.md)
* [Temperature_Setpoint](Temperature-/Temperature_Setpoint.md)
* [Time_Setpoint](Time-/Time_Setpoint.md)
* [Voltage_Ratio_Setpoint](Voltage_Ratio-.md)

---

## Relationships

### Inherited Relationships
* **[Point](../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|lastKnownValue|**en**: last known value||Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
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
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [EquipmentCollection](../../Collection/Equipment-.md).feeds
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
