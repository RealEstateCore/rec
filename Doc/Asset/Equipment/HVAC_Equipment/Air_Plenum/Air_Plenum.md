[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [Air_Plenum](#)
# Air_Plenum

A component of the HVAC the receives air from the air handling unit or room to distribute or exhaust to or from the building


**Display name:** Air Plenum<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Plenum;1

---

## Child interfaces
* [Discharge_Air_Plenum](Discharge_Air_Plenum.md)
* [Return_Air_Plenum](Return_Air_Plenum.md)
* [Supply_Air_Plenum](Supply_Air_Plenum/Supply_Air_Plenum.md)

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
