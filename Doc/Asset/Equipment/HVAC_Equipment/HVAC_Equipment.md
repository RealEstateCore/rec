[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [HVAC_Equipment](#)
# HVAC_Equipment

**Display name:** HVAC Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:HVAC_Equipment;1

---

## Child interfaces
* [Air_Handler_Unit](Air_Handler_Unit.md)
* [Air_Handling_Unit](Air_Handling_Unit.md)
* [Cold_Deck](Cold_Deck.md)
* [Compressor](Compressor.md)
* [Computer_Room_Air_Conditioning](Computer_Room_Air_Conditioning.md)
* [Computer_Room_Air_Handler](Computer_Room_Air_Handler.md)
* [Condenser](Condenser.md)
* [Cooling_Tower](Cooling_Tower.md)
* [Cooling_Valve](Cooling_Valve.md)
* [CRAH](CRAH.md)
* [Dry_Cooler](Dry_Cooler.md)
* [Economizer](Economizer.md)
* [Fume_Hood](Fume_Hood.md)
* [Hot_Deck](Hot_Deck.md)
* [Humidifier](Humidifier.md)
* [HX](HX.md)
* [Space_Heater](Space_Heater.md)
* [Steam_Valve](Steam_Valve.md)
* [Thermostat](Thermostat.md)
* [AHU](AHU/AHU.md)
* [Air_Plenum](Air_Plenum/Air_Plenum.md)
* [Boiler](../Water_Heater/Boiler/Boiler.md)
* [Bypass_Valve](Bypass_Valve/Bypass_Valve.md)
* [Chiller](Chiller/Chiller.md)
* [CRAC](CRAC/CRAC.md)
* [Damper](Damper/Damper.md)
* [Fan](Fan/Fan.md)
* [Filter](Filter/Filter.md)
* [Heating_Valve](Heating_Valve/Heating_Valve.md)
* [Heat_Exchanger](Heat_Exchanger/Heat_Exchanger.md)
* [HVAC_Valve](../Valve/HVAC_Valve/HVAC_Valve.md)
* [Isolation_Valve](Isolation_Valve/Isolation_Valve.md)
* [Pump](Pump/Pump.md)
* [Terminal_Unit](Terminal_Unit/Terminal_Unit.md)

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
