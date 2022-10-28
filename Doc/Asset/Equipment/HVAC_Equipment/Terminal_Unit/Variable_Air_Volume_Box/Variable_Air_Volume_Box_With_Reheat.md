[Index](../../../../../index.md) > [Asset](../../../../Asset.md) > [Equipment](../../../Equipment.md) > [HVAC_Equipment](../../HVAC_Equipment.md) > [Terminal_Unit](../Terminal_Unit.md) > [Variable_Air_Volume_Box](Variable_Air_Volume_Box.md) > [Variable_Air_Volume_Box_With_Reheat](#)
# Variable_Air_Volume_Box_With_Reheat

A VAV box with a reheat coil mounted on the discharge end of the unit that can heat the air delivered to a zone


**Display name:** Variable Air Volume Box With Reheat<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Variable_Air_Volume_Box_With_Reheat;1

---

## Relationships

### Inherited Relationships
* **[Equipment](../../../Equipment.md):** feeds, isFedBy
* **[Asset](../../../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
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
