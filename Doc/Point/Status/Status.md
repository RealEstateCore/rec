[Index](../../index.md) > [Point](../Point.md) > [Status](#)
# Status

A Status is input point that reports the current operating mode, state, position, or condition of an item. Statuses are observations and should be considered 'read-only'


**Display name:** Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Status;1

---

## Child interfaces
* [Availability_Status](Availability-.md)
* [Damper_Position_Status](Damper_Position-.md)
* [Direction_Status](Direction-/Direction_Status.md)
* [Disable_Status](Disable-.md)
* [Drive_Ready_Status](Drive_Ready-.md)
* [Emergency_Generator_Status](Emergency_Generator-.md)
* [Emergency_Push_Button_Status](Emergency_Push_Button-.md)
* [Enable_Status](Enable-/Enable_Status.md)
* [Even_Month_Status](Even_Month-.md)
* [Fan_Status](Fan-/Fan_Status.md)
* [Fault_Status](Fault-/Fault_Status.md)
* [Filter_Status](Filter-/Filter_Status.md)
* [Freeze_Status](Freeze-.md)
* [Hold_Status](Hold-.md)
* [Lead_Lag_Status](Lead_Lag-.md)
* [Load_Shed_Status](Load_Shed-/Load_Shed_Status.md)
* [Lockout_Status](Lockout-.md)
* [Manual_Auto_Status](Manual_Auto-.md)
* [Mode_Status](Mode-/Mode_Status.md)
* [Occupancy_Status](Occupancy-/Occupancy_Status.md)
* [Off_Status](Off-/Off_Status.md)
* [On_Status](On-/On_Status.md)
* [Open_Close_Status](Open_Close-.md)
* [Overridden_Status](Overridden-/Overridden_Status.md)
* [Pressure_Status](Pressure-/Pressure_Status.md)
* [Pump_Status](Pump-.md)
* [Speed_Status](Speed-/Speed_Status.md)
* [Stages_Status](Stages-.md)
* [Switch_Status](Switch-.md)
* [System_Shutdown_Status](System-/System_Shutdown_Status.md)
* [System_Status](System-/System_Status.md)
* [Thermostat_Status](Thermostat-.md)
* [Tint_Status](Tint-.md)
* [Valve_Status](Valve-.md)

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
* **[Point](../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

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
* [ObservationEvent](../../Event/Point-/ObservationEvent.md).sourcePoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
