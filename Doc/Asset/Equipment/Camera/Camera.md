[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Camera](#)
# Camera

**Display name:** Camera<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Camera;1

---

## Child interfaces
* [Surveillance_Camera](../Security_Equipment/Video_Surveillance_Equipment/Surveillance_Camera.md)

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
