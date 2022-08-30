[Index](../../../Index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Safety_Equipment](#)
# Safety_Equipment

**Display name:** Safety Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Safety_Equipment;1

---

## Child interfaces
* [AED](AED.md)
* [Automated_External_Defibrillator](Automated_External_Defibrillator.md)
* [First_Aid_Kit](First_Aid_Kit.md)
* [Emergency_Wash_Station](Emergency_Wash_Station/Emergency_Wash_Station.md)

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
