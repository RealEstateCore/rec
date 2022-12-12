[Index](../../index.md) > [Space](../Space.md) > [Architecture](#)
# Architecture

A designed/landscaped (or potentially designed/landscaped) part of the physical world that has a 3D spatial extent. E.g., a building site, a building, levels within the building, rooms, etc.


**Display name:** Architecture<br />
**DTMI:** dtmi:org:w3id:rec:Architecture;1

---

## Child interfaces
* [Building](Building/Building.md)
* [Level](Level/Level.md)
* [OutdoorSpace](OutdoorSpace.md)
* [Room](Room/Room.md)
* [Site](Site.md)
* [SubBuilding](SubBuilding.md)
* [Zone](Zone/Zone.md)

---

## Components

|Name|Display name|Description|Schema|
|-|-|-|-|
|area|**en**: area||[ArchitectureArea](../../Information/ArchitectureArea.md)|
|capacity|**en**: capacity||[ArchitectureCapacity](../../Information/ArchitectureCapacity.md)|

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|address|**en**: address|**en**: Physical address of the architecture (site, building, sub-building, entrance room, etc.) in question.|0-Infinity|[PostalAddress](../../Information/PostalAddress.md)||True|
|adjacentElement|**en**: adjacent element||0-Infinity|[BuildingElement](../../BuildingElement/BuildingElement.md)||True|
|architectedBy|**en**: architected by||0-Infinity|[Agent](../../Agent/Agent.md)||True|
|constructedBy|||0-Infinity|[Agent](../../Agent/Agent.md)||True|
|containsElement|**en**: contains element|**en**: Links an Architecture to BuildingElement that is contained in the Space.|0-Infinity|[BuildingElement](../../BuildingElement/BuildingElement.md)||True|
|documentation|**en**: documentation||0-Infinity|[Document](../../Information/Document/Document.md)||True|
|hasPoint|**en**: has point||0-Infinity|[Point](../../Point/Point.md)||True|
|intersectingElement|**en**: intersecting element||0-Infinity|[BuildingElement](../../BuildingElement/BuildingElement.md)||True|
|isFedBy|**en**: is fed by||0-Infinity||substance (enum (ACElec, Air, BlowdownWater, ChilledWater, ColdDomesticWater, Condensate, CondenserWater, DCElec, Diesel, DriveElec, Ethernet, ExhaustAir, Freight, FuelOil, Gasoline, GreaseExhaustAir, HotDomesticWater, HotWater, IrrigationWater, Light, MakeupWater, NaturalGas, NonPotableDomesticWater, OutsideAir, People, Propane, RecircHotDomesticWater, Refrig, ReturnAir, SprinklerWater, Steam, StormDrainage, SupplyAir, TransferAir, WasteVentDrainage, Water))|True|
|operatedBy|**en**: operated by||0-Infinity|[Agent](../../Agent/Agent.md)||True|
|ownedBy|**en**: owned by||0-Infinity|[Agent](../../Agent/Agent.md)||True|
### Inherited Relationships
* **[Space](../Space.md):** geometry, georeference, hasPart, isLocationOf, isPartOf

---

## Properties

### Inherited Properties
* **[Space](../Space.md):** customProperties, customTags, identifiers, name

---

## Target Of
### General
* [Point](../../Point/Point.md).isPointOf
* [Agent](../../Agent/Agent.md).owns
* [Space](../Space.md).isLocationOf
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](#).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [EquipmentCollection](../../Collection/Equipment-.md).feeds
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [BuildingElement](../../BuildingElement/BuildingElement.md).locatedIn
* [Campus](../../Collection/Campus.md).includes
* [Premises](../../Collection/Premises.md).includes
* [RealEstate](../../Collection/RealEstate.md).includes
### Inherited
* [Asset](../../Asset/Asset.md).locatedIn
* [Space](../Space.md).hasPart
* [Space](../Space.md).isPartOf
