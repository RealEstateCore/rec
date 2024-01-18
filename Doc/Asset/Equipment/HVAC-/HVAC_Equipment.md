[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [HVAC_Equipment](#)
# HVAC_Equipment

See Heating_Ventilation_Air_Conditioning_System


**Display name:** HVAC Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:HVAC_Equipment;1

---

## Child interfaces
* [AHU](AHU/AHU.md)
* [Air_Handler_Unit](Air_Handler_Unit.md)
* [Air_Handling_Unit](Air_Handling_Unit.md)
* [Air_Plenum](Air_Plenum/Air_Plenum.md)
* [Boiler](../Water_Heater/Boiler/Boiler.md)
* [Bypass_Valve](Bypass_Valve/Bypass_Valve.md)
* [Chiller](Chiller/Chiller.md)
* [Cold_Deck](Cold_Deck.md)
* [Compressor](Compressor.md)
* [Computer_Room_Air_Conditioning](Computer_Room_Air_Conditioning.md)
* [Computer_Room_Air_Handler](Computer_Room_Air_Handler.md)
* [Condenser](Condenser.md)
* [Cooling_Tower](Cooling_Tower.md)
* [Cooling_Valve](Cooling_Valve.md)
* [CRAC](CRAC/CRAC.md)
* [CRAH](CRAH.md)
* [Damper](Damper/Damper.md)
* [Dry_Cooler](Dry_Cooler.md)
* [Economizer](Economizer.md)
* [Fan](Fan/Fan.md)
* [Filter](Filter/Filter.md)
* [Fume_Hood](Fume_Hood.md)
* [Heat_Exchanger](Heat_Exchanger/Heat_Exchanger.md)
* [Heating_Valve](Heating_Valve/Heating_Valve.md)
* [Hot_Deck](Hot_Deck.md)
* [Humidifier](Humidifier.md)
* [HVAC_Valve](../Valve/HVAC-/HVAC_Valve.md)
* [HX](HX.md)
* [Isolation_Valve](Isolation_Valve/Isolation_Valve.md)
* [Pump](Pump/Pump.md)
* [Space_Heater](Space_Heater.md)
* [Steam_Valve](Steam_Valve.md)
* [Terminal_Unit](Terminal_Unit/Terminal_Unit.md)
* [Thermostat](Thermostat.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, geometry, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Equipment](../Equipment.md):** operationalStageCount
* **[Asset](../../Asset.md):** assetTag, commissioningDate, customProperties, customTags, identifiers, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../Equipment.md).feeds
* [Equipment](../Equipment.md).isFedBy
* [System](../../../Collection/System/System.md).includes
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Meter/Meter.md).meters
### Inherited
* [Loop](../../../Collection/Loop/Loop.md).includes
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [EquipmentCollection](../../../Collection/Equipment-.md).includes
