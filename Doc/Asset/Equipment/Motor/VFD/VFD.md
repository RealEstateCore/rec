[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [Motor](../Motor.md) > [VFD](#)
# VFD

Electronic device that varies its output frequency to vary the rotating speed of a motor, given a fixed input frequency. Used with fans or pumps to vary the flow in the system as a function of a maintained pressure.


**Display name:** VFD<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:VFD;1

---

## Child interfaces
* [Fan_VFD](Fan_VFD.md)
* [Heat_Wheel_VFD](Heat_Wheel_VFD.md)
* [Pump_VFD](Pump_VFD.md)

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
