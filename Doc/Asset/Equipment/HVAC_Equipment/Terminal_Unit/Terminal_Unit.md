[Index](../../../../Index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [Terminal_Unit](#)
# Terminal_Unit

**Display name:** Terminal Unit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Terminal_Unit;1

---

## Child interfaces
* [CAV](CAV.md)
* [Constant_Air_Volume_Box](Constant_Air_Volume_Box.md)
* [Fan_Coil_Unit](Fan_Coil_Unit.md)
* [FCU](FCU.md)
* [Induction_Unit](Induction_Unit.md)
* [VAV](VAV.md)
* [Air_Diffuser](Air_Diffuser/Air_Diffuser.md)
* [Chilled_Beam](Chilled_Beam/Chilled_Beam.md)
* [Radiant_Panel](Radiant_Panel/Radiant_Panel.md)
* [Radiator](Radiator/Radiator.md)
* [Variable_Air_Volume_Box](Variable_Air_Volume_Box/Variable_Air_Volume_Box.md)

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
