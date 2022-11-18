[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [AHU](#)
# AHU

Assembly consisting of sections containing a fan or fans and other necessary equipment to perform one or more of the following functions: circulating, filtration, heating, cooling, heat recovery, humidifying, dehumidifying, and mixing of air. Is usually connected to an air-distribution system.


**Display name:** AHU<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:AHU;1

---

## Child interfaces
* [DDAHU](DD-.md)
* [Dedicated_Outdoor_Air_System_Unit](Dedicated_Outdoor_Air_System_Unit.md)
* [DOAS](DOAS.md)
* [Dual_Duct_Air_Handling_Unit](Dual_Duct_Air_Handling_Unit.md)
* [Makeup_Air_Unit](Makeup_Air_Unit.md)
* [MAU](MAU.md)
* [PAU](PAU.md)
* [Rooftop_Unit](Rooftop_Unit.md)
* [RTU](RTU.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../../Equipment.md):** feeds, isFedBy
* **[Asset](../../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Equipment](../../Equipment.md):** operationalStageCount
* **[Asset](../../../Asset.md):** assetTag, commissioningDate, customProperties, customTags, geometry, identifiers, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../../../Point/Point.md).isPointOf
* [Agent](../../../../Agent/Agent.md).owns
* [Space](../../../../Space/Space.md).isLocationOf
* [Equipment](../../Equipment.md).feeds
* [Equipment](../../Equipment.md).isFedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../../Collection/Equipment-.md).feeds
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Meter/Meter.md).meters
### Inherited
* [Loop](../../../../Collection/Loop/Loop.md).includes
* [System](../../../../Collection/System/System.md).includes
* [Asset](../../../Asset.md).hasPart
* [Asset](../../../Asset.md).isPartOf
* [EquipmentCollection](../../../../Collection/Equipment-.md).includes
