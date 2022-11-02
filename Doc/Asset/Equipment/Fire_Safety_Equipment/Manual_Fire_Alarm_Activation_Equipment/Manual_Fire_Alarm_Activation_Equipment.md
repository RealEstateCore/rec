[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [Fire_Safety_Equipment](../Fire_Safety_Equipment.md) > [Manual_Fire_Alarm_Activation_Equipment](#)
# Manual_Fire_Alarm_Activation_Equipment

A device for manually activating fire alarm


**Display name:** Manual Fire Alarm Activation Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Manual_Fire_Alarm_Activation_Equipment;1

---

## Child interfaces
* [Fire_Alarm_Pull_Station](Fire_Alarm_Pull_Station.md)
* [Fire_Alarm_Manual_Call_Point](Fire_Alarm_Manual_Call_Point.md)

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
