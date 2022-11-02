[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [Filter](#)
# Filter

Device to remove gases from a mixture of gases or to remove solid material from a fluid


**Display name:** Filter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Filter;1

---

## Child interfaces
* [Mixed_Air_Filter](Mixed_Air_Filter.md)
* [Final_Filter](Final_Filter.md)
* [Pre_Filter](Pre_Filter.md)
* [Intake_Air_Filter](Intake_Air_Filter.md)
* [Return_Air_Filter](Return_Air_Filter.md)

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
