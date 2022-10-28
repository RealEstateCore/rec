[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [AHU](#)
# AHU

Assembly consisting of sections containing a fan or fans and other necessary equipment to perform one or more of the following functions: circulating, filtration, heating, cooling, heat recovery, humidifying, dehumidifying, and mixing of air. Is usually connected to an air-distribution system.


**Display name:** AHU<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:AHU;1

---

## Child interfaces
* [DDAHU](DDAHU.md)
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
* **[Asset](../../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### Inherited
* [Asset](../../../Asset.md).hasPart
* [Asset](../../../Asset.md).isPartOf
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../../Collection/Loop/Loop.md).includes
* [System](../../../../Collection/System/System.md).includes
