[Index](../../../../Index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [Heat_Exchanger](#)
# Heat_Exchanger

**Display name:** Heat Exchanger<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heat_Exchanger;1

---

## Child interfaces
* [Condenser_Heat_Exchanger](Condenser_Heat_Exchanger.md)
* [Evaporative_Heat_Exchanger](Evaporative_Heat_Exchanger.md)
* [Heat_Wheel](Heat_Wheel.md)
* [Coil](Coil/Coil.md)

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
