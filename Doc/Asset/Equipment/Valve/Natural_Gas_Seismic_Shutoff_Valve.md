[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Valve](Valve.md) > [Natural_Gas_Seismic_Shutoff_Valve](#)
# Natural_Gas_Seismic_Shutoff_Valve

Valves that automatically shut off your natural gas service when an earthquake of a sufficient magnitude occurs at the location.


**Display name:** Natural Gas Seismic Shutoff Valve<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Natural_Gas_Seismic_Shutoff_Valve;1

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

---

## Target Of
### Inherited
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../Collection/Loop/Loop.md).includes
* [System](../../../Collection/System/System.md).includes
