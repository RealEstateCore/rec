[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Electrical_Equipment](Electrical_Equipment.md) > [Transformer](#)
# Transformer

A Transformer is usually fed by a high-voltage source and then steps down the voltage to a lower-voltage feed for low-voltage application (such as lights). Transformers also can step up voltage, but this generally does not apply to in building distribution.


**Display name:** Transformer<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Transformer;1

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
