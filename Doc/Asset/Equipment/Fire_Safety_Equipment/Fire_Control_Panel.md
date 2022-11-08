[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Fire_Safety_Equipment](Fire_Safety_Equipment.md) > [Fire_Control_Panel](#)
# Fire_Control_Panel

A panel-mounted device that provides status and control of a fire safety system


**Display name:** Fire Control Panel<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Fire_Control_Panel;1

---

## Relationships

### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Equipment](../Equipment.md):** operationalStageCount
* **[Asset](../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Space](../../../Space/Space.md).isLocationOf
* [Agent](../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../Collection/Portfolio.md).includes
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../Equipment.md).feeds
* [Equipment](../Equipment.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../Meter/Meter.md).meters
### Inherited
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../Collection/Loop/Loop.md).includes
* [System](../../../Collection/System/System.md).includes
