[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Fire_Safety_Equipment](#)
# Fire_Safety_Equipment

**Display name:** Fire Safety Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Fire_Safety_Equipment;1

---

## Child interfaces
* [Smoke_Detector](Smoke_Detector.md)
* [Fire_Alarm](Fire_Alarm.md)
* [Heat_Detector](Heat_Detector.md)
* [Fire_Control_Panel](Fire_Control_Panel.md)
* [Fire_Alarm_Control_Panel](Fire_Alarm_Control_Panel.md)
* [Manual_Fire_Alarm_Activation_Equipment](Manual_Fire_Alarm_Activation_Equipment/Manual_Fire_Alarm_Activation_Equipment.md)

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
