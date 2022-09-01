[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [Valve](../Valve.md) > [HVAC_Valve](#)
# HVAC_Valve

**Display name:** HVAC Valve<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:HVAC_Valve;1

---

## Child interfaces
* [Chilled_Water_Valve](../Water_Valve/Chilled_Water_Valve.md)
* [Condenser_Water_Valve](../Water_Valve/Condenser_Water_Valve.md)
* [Makeup_Water_Valve](../Water_Valve/Makeup_Water_Valve.md)

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
