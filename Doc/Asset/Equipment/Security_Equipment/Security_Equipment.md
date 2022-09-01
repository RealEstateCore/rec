[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Security_Equipment](#)
# Security_Equipment

**Display name:** Security Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Security_Equipment;1

---

## Child interfaces
* [Intrusion_Detection_Equipment](Intrusion_Detection_Equipment.md)
* [Access_Control_Equipment](Access_Control_Equipment/Access_Control_Equipment.md)
* [Intercom_Equipment](Intercom_Equipment/Intercom_Equipment.md)
* [Video_Surveillance_Equipment](Video_Surveillance_Equipment/Video_Surveillance_Equipment.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

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
