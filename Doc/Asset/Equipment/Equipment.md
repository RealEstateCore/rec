[Index](../../index.md) > [Asset](../Asset.md) > [Equipment](#)
# Equipment

devices that serve all or part of the building and may include electric power, lighting, transportation, or service water heating, including, but not limited to, furnaces, boilers, air conditioners, heat pumps, chillers, water heaters, lamps, luminaires, ballasts, elevators, escalators, or other devices or installations.


**Display name:** Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Equipment;1

---

## Child interfaces
* [Gas_Distribution](Gas_Distribution.md)
* [Water_Distribution](Water_Distribution.md)
* [Weather_Station](Weather_Station.md)
* [Relay](Relay.md)
* [Elevator](Elevator.md)
* [Steam_Distribution](Steam_Distribution.md)
* [Lighting_Equipment](Lighting_Equipment/Lighting_Equipment.md)
* [Meter](Meter/Meter.md)
* [Safety_Equipment](Safety_Equipment/Safety_Equipment.md)
* [Valve](Valve/Valve.md)
* [PV_Panel](PV_Panel/PV_Panel.md)
* [Electrical_Equipment](Electrical_Equipment/Electrical_Equipment.md)
* [Camera](Camera/Camera.md)
* [Shading_Equipment](Shading_Equipment/Shading_Equipment.md)
* [Water_Heater](Water_Heater/Water_Heater.md)
* [Solar_Thermal_Collector](Solar_Thermal_Collector/Solar_Thermal_Collector.md)
* [Fire_Safety_Equipment](Fire_Safety_Equipment/Fire_Safety_Equipment.md)
* [HVAC_Equipment](HVAC_Equipment/HVAC_Equipment.md)
* [Motor](Motor/Motor.md)
* [Security_Equipment](Security_Equipment/Security_Equipment.md)

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
### General
* [Point](../../Point/Point.md).isPointOf
* [Space](../../Space/Space.md).isLocationOf
* [Agent](../../Agent/Agent.md).owns
* [EquipmentCollection](../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../Collection/Portfolio.md).includes
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](#).feeds
* [Equipment](#).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Meter](Meter/Meter.md).meters
### Direct
* [EquipmentCollection](../../Collection/EquipmentCollection.md).includes
* [Loop](../../Collection/Loop/Loop.md).includes
* [System](../../Collection/System/System.md).includes
### Inherited
* [Asset](../Asset.md).hasPart
* [Asset](../Asset.md).isPartOf
