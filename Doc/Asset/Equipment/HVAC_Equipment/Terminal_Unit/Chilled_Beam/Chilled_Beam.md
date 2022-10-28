[Index](../../../../../index.md) > [Asset](../../../../Asset.md) > [Equipment](../../../Equipment.md) > [HVAC_Equipment](../../HVAC_Equipment.md) > [Terminal_Unit](../Terminal_Unit.md) > [Chilled_Beam](#)
# Chilled_Beam

A device with an integrated coil that performs sensible heating of a space via circulation of room air. Chilled Beams are not designed to perform latent cooling; see Induction Units. Despite their name, Chilled Beams may perform heating or cooling of a space depending on their configuration.


**Display name:** Chilled Beam<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Chilled_Beam;1

---

## Child interfaces
* [Active_Chilled_Beam](Active_Chilled_Beam.md)
* [Passive_Chilled_Beam](Passive_Chilled_Beam.md)

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
