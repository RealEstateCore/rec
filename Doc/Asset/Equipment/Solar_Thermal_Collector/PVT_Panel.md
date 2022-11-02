[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Solar_Thermal_Collector](Solar_Thermal_Collector.md) > [PVT_Panel](#)
# PVT_Panel

A type of solar panels that convert solar radiation into usable thermal and electrical energy


**Display name:** PVT Panel<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:PVT_Panel;1

---

## Relationships

### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Equipment](../Equipment.md):** operationalStageCount
* **[Asset](../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
* **[PV_Panel](../PV_Panel/PV_Panel.md):** measuredModuleConversionEfficiency, ratedModuleConversionEfficiency

---

## Target Of
### Inherited
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [PV_Array](../../../Collection/PV_Array.md).includes
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../Collection/Loop/Loop.md).includes
* [System](../../../Collection/System/System.md).includes
