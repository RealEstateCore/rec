[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Water_Heater](#)
# Water_Heater

**Display name:** Water Heater<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Heater;1

---

## Child interfaces
* [Collection_Basin_Water_Heater](Collection_Basin_Water_Heater.md)
* [Boiler](Boiler/Boiler.md)

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
