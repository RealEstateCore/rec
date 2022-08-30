[Index](../../../../Index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [Security_Equipment](../Security_Equipment.md) > [Video_Surveillance_Equipment](#)
# Video_Surveillance_Equipment

**Display name:** Video Surveillance Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Video_Surveillance_Equipment;1

---

## Child interfaces
* [Network_Video_Recorder](Network_Video_Recorder.md)
* [NVR](NVR.md)
* [Surveillance_Camera](Surveillance_Camera.md)

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
