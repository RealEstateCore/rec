[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [Heating_Valve](#)
# Heating_Valve

A valve that controls air temperature by modulating the amount of hot water flowing through a heating coil


**Display name:** Heating Valve<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heating_Valve;1

---

## Child interfaces
* [Reheat_Valve](Reheat_Valve.md)
* [Return_Heating_Valve](Return_Heating_Valve.md)
* [Hot_Water_Valve](../../Valve/Water_Valve/Hot_Water_Valve/Hot_Water_Valve.md)

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
