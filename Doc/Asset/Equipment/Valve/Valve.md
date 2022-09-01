[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Valve](#)
# Valve

**Display name:** Valve<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Valve;1

---

## Child interfaces
* [Gas_Valve](Gas_Valve.md)
* [Natural_Gas_Seismic_Shutoff_Valve](Natural_Gas_Seismic_Shutoff_Valve.md)
* [HVAC_Valve](HVAC_Valve/HVAC_Valve.md)
* [Water_Valve](Water_Valve/Water_Valve.md)

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
