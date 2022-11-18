[Index](../../index.md) > [Asset](../Asset.md) > [Equipment](#)
# Equipment

devices that serve all or part of the building and may include electric power, lighting, transportation, or service water heating, including, but not limited to, furnaces, boilers, air conditioners, heat pumps, chillers, water heaters, lamps, luminaires, ballasts, elevators, escalators, or other devices or installations.


**Display name:** Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Equipment;1

---

## Child interfaces
* [Camera](Camera/Camera.md)
* [Electrical_Equipment](Electrical-/Electrical_Equipment.md)
* [Elevator](Elevator.md)
* [Fire_Safety_Equipment](Fire_Safety-/Fire_Safety_Equipment.md)
* [Gas_Distribution](Gas_Distribution.md)
* [HVAC_Equipment](HVAC-/HVAC_Equipment.md)
* [Lighting_Equipment](Lighting-/Lighting_Equipment.md)
* [Meter](Meter/Meter.md)
* [Motor](Motor/Motor.md)
* [PV_Panel](PV_Panel/PV_Panel.md)
* [Relay](Relay.md)
* [Safety_Equipment](Safety-/Safety_Equipment.md)
* [Security_Equipment](Security-/Security_Equipment.md)
* [Shading_Equipment](Shading-/Shading_Equipment.md)
* [Solar_Thermal_Collector](Solar_Thermal_Collector/Solar_Thermal_Collector.md)
* [Steam_Distribution](Steam_Distribution.md)
* [Valve](Valve/Valve.md)
* [Water_Distribution](Water_Distribution.md)
* [Water_Heater](Water_Heater/Water_Heater.md)
* [Weather_Station](Weather_Station.md)

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
* **[Asset](../Asset.md):** assetTag, commissioningDate, customProperties, customTags, geometry, identifiers, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../Point/Point.md).isPointOf
* [Agent](../../Agent/Agent.md).owns
* [Space](../../Space/Space.md).isLocationOf
* [Equipment](#).feeds
* [Equipment](#).isFedBy
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [EquipmentCollection](../../Collection/Equipment-.md).feeds
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](Meter/Meter.md).meters
### Direct
* [Loop](../../Collection/Loop/Loop.md).includes
* [System](../../Collection/System/System.md).includes
* [EquipmentCollection](../../Collection/Equipment-.md).includes
### Inherited
* [Asset](../Asset.md).hasPart
* [Asset](../Asset.md).isPartOf
