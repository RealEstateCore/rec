[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [Meter](../Meter.md) > [Building_Meter](#)
# Building_Meter

A meter that measures usage or consumption of some media for a whole building


**Display name:** Building Meter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Building_Meter;1

---

## Child interfaces
* [Building_Electrical_Meter](../Electrical_Meter/Building_Electrical_Meter.md)
* [Building_Gas_Meter](../Gas_Meter/Building_Gas_Meter.md)
* [Building_Water_Meter](../Water_Meter/Building_Water_Meter.md)
* [Building_Chilled_Water_Meter](../Water_Meter/Chilled_Water_Meter/Building_Chilled_Water_Meter.md)
* [Building_Hot_Water_Meter](../Water_Meter/Hot_Water_Meter/Building_Hot_Water_Meter.md)

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
