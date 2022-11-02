[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [HVAC_Equipment](#)
# HVAC_Equipment

See Heating_Ventilation_Air_Conditioning_System


**Display name:** HVAC Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:HVAC_Equipment;1

---

## Child interfaces
* [Air_Handler_Unit](Air_Handler_Unit.md)
* [Humidifier](Humidifier.md)
* [Cold_Deck](Cold_Deck.md)
* [Cooling_Tower](Cooling_Tower.md)
* [Thermostat](Thermostat.md)
* [Cooling_Valve](Cooling_Valve.md)
* [Fume_Hood](Fume_Hood.md)
* [Computer_Room_Air_Conditioning](Computer_Room_Air_Conditioning.md)
* [HX](HX.md)
* [Hot_Deck](Hot_Deck.md)
* [Air_Handling_Unit](Air_Handling_Unit.md)
* [Computer_Room_Air_Handler](Computer_Room_Air_Handler.md)
* [Compressor](Compressor.md)
* [Steam_Valve](Steam_Valve.md)
* [Condenser](Condenser.md)
* [Dry_Cooler](Dry_Cooler.md)
* [CRAH](CRAH.md)
* [Economizer](Economizer.md)
* [Space_Heater](Space_Heater.md)
* [Heat_Exchanger](Heat_Exchanger/Heat_Exchanger.md)
* [Chiller](Chiller/Chiller.md)
* [Damper](Damper/Damper.md)
* [CRAC](CRAC/CRAC.md)
* [Terminal_Unit](Terminal_Unit/Terminal_Unit.md)
* [Air_Plenum](Air_Plenum/Air_Plenum.md)
* [Bypass_Valve](Bypass_Valve/Bypass_Valve.md)
* [Boiler](../Water_Heater/Boiler/Boiler.md)
* [Fan](Fan/Fan.md)
* [Pump](Pump/Pump.md)
* [AHU](AHU/AHU.md)
* [Filter](Filter/Filter.md)
* [Isolation_Valve](Isolation_Valve/Isolation_Valve.md)
* [HVAC_Valve](../Valve/HVAC_Valve/HVAC_Valve.md)
* [Heating_Valve](Heating_Valve/Heating_Valve.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Equipment](../Equipment.md):** operationalStageCount
* **[Asset](../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### Inherited
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../Collection/Loop/Loop.md).includes
* [System](../../../Collection/System/System.md).includes
