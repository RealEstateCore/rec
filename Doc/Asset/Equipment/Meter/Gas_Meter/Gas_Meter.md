[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [Meter](../Meter.md) > [Gas_Meter](#)
# Gas_Meter

**Display name:** Gas Meter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Gas_Meter;1

---

## Child interfaces
* [Building_Gas_Meter](Building_Gas_Meter.md)

---

## Relationships

### Inherited Relationships
* **[Meter](../Meter.md):** hasSubMeter, isSubMeterOf, meters
* **[Equipment](../../Equipment.md):** feeds, isFedBy
* **[Asset](../../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Meter](../Meter.md):** isVirtualMeter
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
* [Meter](../Meter.md).hasSubMeter
* [Meter](../Meter.md).isSubMeterOf
