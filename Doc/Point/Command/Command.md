[Index](../../index.md) > [Point](../Point.md) > [Command](#)
# Command

A Command is an output point that directly determines the behavior of equipment and/or affects relevant operational points.


**Display name:** Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Command;1

---

## Child interfaces
* [Boiler_Command](Boiler-.md)
* [Bypass_Command](Bypass-.md)
* [Cooling_Command](Cooling-.md)
* [Damper_Command](Damper-/Damper_Command.md)
* [Direction_Command](Direction-.md)
* [Disable_Command](Disable-/Disable_Command.md)
* [Enable_Command](Enable-/Enable_Command.md)
* [Fan_Command](Fan-/Fan_Command.md)
* [Frequency_Command](Frequency-/Frequency_Command.md)
* [Heating_Command](Heating-.md)
* [Humidify_Command](Humidify-.md)
* [Lead_Lag_Command](Lead_Lag-.md)
* [Light_Command](Light-.md)
* [Load_Shed_Command](Load_Shed-/Load_Shed_Command.md)
* [Luminance_Command](Luminance-.md)
* [Mode_Command](Mode-/Mode_Command.md)
* [Occupancy_Command](Occupancy-.md)
* [On_Off_Command](On_Off-/On_Off_Command.md)
* [Override_Command](Override-/Override_Command.md)
* [Position_Command](Position-/Position_Command.md)
* [Preheat_Command](Preheat-.md)
* [Pump_Command](Pump-.md)
* [Relay_Command](Relay-.md)
* [Reset_Command](Reset-/Reset_Command.md)
* [Speed_Command](Speed-.md)
* [Tint_Command](Tint-.md)
* [Valve_Command](Valve-/Valve_Command.md)

---

## Components

|Name|Display name|Description|Schema|
|-|-|-|-|
|lastKnownValue|**en**: last known value||[ActuationEvent](../../Event/Point-/ActuationEvent.md)|

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
