[Index](../../../../../index.md) > [Asset](../../../../Asset.md) > [Equipment](../../../Equipment.md) > [HVAC_Equipment](../../HVAC_Equipment.md) > [Terminal_Unit](../Terminal_Unit.md) > [Radiant_Panel](#)
# Radiant_Panel

**Display name:** Radiant Panel<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Radiant_Panel;1

---

## Child interfaces
* [Embedded_Surface_System_Panel](Embedded_Surface_System_Panel.md)
* [ESS_Panel](ESS_Panel.md)
* [Radiant_Ceiling_Panel](Radiant_Ceiling_Panel.md)
* [RC_Panel](RC_Panel.md)
* [TABS_Panel](TABS_Panel.md)
* [Thermally_Activated_Building_System_Panel](Thermally_Activated_Building_System_Panel.md)

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
