[Index](../../Index.md) > [Asset](../Asset.md) > [Equipment](#)
# Equipment

**Display name:** Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Equipment;1

---

## Child interfaces
* [Elevator](Elevator.md)
* [Gas_Distribution](Gas_Distribution.md)
* [Relay](Relay.md)
* [Steam_Distribution](Steam_Distribution.md)
* [Water_Distribution](Water_Distribution.md)
* [Weather_Station](Weather_Station.md)
* [Camera](Camera/Camera.md)
* [Electrical_Equipment](Electrical_Equipment/Electrical_Equipment.md)
* [Fire_Safety_Equipment](Fire_Safety_Equipment/Fire_Safety_Equipment.md)
* [HVAC_Equipment](HVAC_Equipment/HVAC_Equipment.md)
* [Lighting_Equipment](Lighting_Equipment/Lighting_Equipment.md)
* [Meter](Meter/Meter.md)
* [Motor](Motor/Motor.md)
* [PV_Panel](PV_Panel/PV_Panel.md)
* [Safety_Equipment](Safety_Equipment/Safety_Equipment.md)
* [Security_Equipment](Security_Equipment/Security_Equipment.md)
* [Shading_Equipment](Shading_Equipment/Shading_Equipment.md)
* [Solar_Thermal_Collector](Solar_Thermal_Collector/Solar_Thermal_Collector.md)
* [Valve](Valve/Valve.md)
* [Water_Heater](Water_Heater/Water_Heater.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|feeds|**en**: feeds||0-Infinity||substance (enum (ACElec, Air, BlowdownWater, ChilledWater, ColdDomesticWater, Condensate, CondenserWater, DCElec, Diesel, DriveElec, Ethernet, ExhaustAir, Freight, FuelOil, Gasoline, GreaseExhaustAir, HotDomesticWater, HotWater, IrrigationWater, Light, MakeupWater, NaturalGas, NonPotableDomesticWater, OutsideAir, People, Propane, RecircHotDomesticWater, Refrig, ReturnAir, SprinklerWater, Steam, StormDrainage, SupplyAir, TransferAir, WasteVentDrainage, Water))|True|
|isFedBy|**en**: is fed by||0-Infinity||substance (enum (ACElec, Air, BlowdownWater, ChilledWater, ColdDomesticWater, Condensate, CondenserWater, DCElec, Diesel, DriveElec, Ethernet, ExhaustAir, Freight, FuelOil, Gasoline, GreaseExhaustAir, HotDomesticWater, HotWater, IrrigationWater, Light, MakeupWater, NaturalGas, NonPotableDomesticWater, OutsideAir, People, Propane, RecircHotDomesticWater, Refrig, ReturnAir, SprinklerWater, Steam, StormDrainage, SupplyAir, TransferAir, WasteVentDrainage, Water))|True|
### Inherited Relationships
* **[Asset](../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|operationalStageCount|**en**: Operational stage count||string|True|
### Inherited Properties
* **[Asset](../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### Direct
* [EquipmentCollection](../../Collection/EquipmentCollection.md).includes
* [Loop](../../Collection/Loop/Loop.md).includes
* [System](../../Collection/System/System.md).includes
### Inherited
* [Asset](../Asset.md).hasPart
* [Asset](../Asset.md).isPartOf
