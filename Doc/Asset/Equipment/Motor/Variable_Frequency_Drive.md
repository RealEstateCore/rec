[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Motor](Motor.md) > [Variable_Frequency_Drive](#)
# Variable_Frequency_Drive

Electronic device that varies its output frequency to vary the rotating speed of a motor, given a fixed input frequency. Used with fans or pumps to vary the flow in the system as a function of a maintained pressure.


**Display name:** Variable Frequency Drive<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Variable_Frequency_Drive;1

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
