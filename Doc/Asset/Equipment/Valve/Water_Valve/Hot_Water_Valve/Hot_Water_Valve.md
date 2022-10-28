[Index](../../../../../index.md) > [Asset](../../../../Asset.md) > [Equipment](../../../Equipment.md) > [Valve](../../Valve.md) > [Water_Valve](../Water_Valve.md) > [Hot_Water_Valve](#)
# Hot_Water_Valve

A valve regulating the flow of hot water


**Display name:** Hot Water Valve<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Hot_Water_Valve;1

---

## Child interfaces
* [Domestic_Hot_Water_Valve](Domestic_Hot_Water_Valve.md)
* [Preheat_Hot_Water_Valve](Preheat_Hot_Water_Valve.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../../../Equipment.md):** feeds, isFedBy
* **[Asset](../../../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Equipment](../../../Equipment.md):** operationalStageCount
* **[Asset](../../../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### Inherited
* [Asset](../../../../Asset.md).hasPart
* [Asset](../../../../Asset.md).isPartOf
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../../../Collection/Loop/Loop.md).includes
* [System](../../../../../Collection/System/System.md).includes
