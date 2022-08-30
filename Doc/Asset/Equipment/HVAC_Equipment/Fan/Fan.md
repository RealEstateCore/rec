[Index](../../../../Index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [Fan](#)
# Fan

**Display name:** Fan<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Fan;1

---

## Child interfaces
* [Booster_Fan](Booster_Fan.md)
* [Ceiling_Fan](Ceiling_Fan.md)
* [Cooling_Tower_Fan](Cooling_Tower_Fan.md)
* [Discharge_Fan](Discharge_Fan.md)
* [Exhaust_Fan](Exhaust_Fan.md)
* [Outside_Fan](Outside_Fan.md)
* [Relief_Fan](Relief_Fan.md)
* [Return_Fan](Return_Fan.md)
* [Standby_Fan](Standby_Fan.md)
* [Supply_Fan](Supply_Fan.md)
* [Transfer_Fan](Transfer_Fan.md)

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
