[Index](../../index.md) > [Asset](../Asset.md) > [Equipment](Equipment.md) > [Steam_Distribution](#)
# Steam_Distribution

**Display name:** Steam Distribution<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Steam_Distribution;1

---

## Relationships

### Inherited Relationships
* **[Equipment](Equipment.md):** feeds, isFedBy
* **[Asset](../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **[Equipment](Equipment.md):** operationalStageCount
* **[Asset](../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### Inherited
* [Asset](../Asset.md).hasPart
* [Asset](../Asset.md).isPartOf
* [EquipmentCollection](../../Collection/EquipmentCollection.md).includes
* [Loop](../../Collection/Loop/Loop.md).includes
* [System](../../Collection/System/System.md).includes
