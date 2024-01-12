[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Fire_Safety_Equipment](#)
# Fire_Safety_Equipment

**Display name:** Fire Safety Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Fire_Safety_Equipment;1

---

## Child interfaces
* [Fire_Alarm_Control_Panel](Fire_Alarm_Control_Panel.md)
* [Fire_Alarm](Fire_Alarm.md)
* [Fire_Control_Panel](Fire_Control_Panel.md)
* [Heat_Detector](Heat_Detector.md)
* [Manual_Fire_Alarm_Activation_Equipment](Manual_Fire_Alarm_Activation_Equipment/Manual_Fire_Alarm_Activation_Equipment.md)
* [Smoke_Detector](Smoke_Detector.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, geometry, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Equipment](../Equipment.md):** operationalStageCount
* **[Asset](../../Asset.md):** assetTag, commissioningDate, customProperties, customTags, identifiers, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../Equipment.md).feeds
* [Equipment](../Equipment.md).isFedBy
* [System](../../../Collection/System/System.md).includes
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Meter/Meter.md).meters
### Inherited
* [Loop](../../../Collection/Loop/Loop.md).includes
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [EquipmentCollection](../../../Collection/Equipment-.md).includes
