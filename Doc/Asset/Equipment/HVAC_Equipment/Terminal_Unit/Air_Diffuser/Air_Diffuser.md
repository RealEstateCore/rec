[Index](../../../../../Index.md) > [Asset](../../../../Asset.md) > [Equipment](../../../Equipment.md) > [HVAC_Equipment](../../HVAC_Equipment.md) > [Terminal_Unit](../Terminal_Unit.md) > [Air_Diffuser](#)
# Air_Diffuser

**Display name:** Air Diffuser<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Diffuser;1

---

## Child interfaces
* [Displacement_Flow_Air_Diffuser](Displacement_Flow_Air_Diffuser.md)
* [Jet_Nozzle_Air_Diffuser](Jet_Nozzle_Air_Diffuser.md)
* [Laminar_Flow_Air_Diffuser](Laminar_Flow_Air_Diffuser.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../../../Equipment.md):** feeds, isFedBy
* **[Asset](../../../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

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
