[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Electrical_Equipment](Electrical_Equipment.md) > [Breaker_Panel](#)
# Breaker_Panel

Breaker Panel distributes power into various end-uses.


**Display name:** Breaker Panel<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Breaker_Panel;1

---

## Relationships

### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, geometry, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
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
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../Collection/Equipment-.md).feeds
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Meter/Meter.md).meters
### Inherited
* [Loop](../../../Collection/Loop/Loop.md).includes
* [System](../../../Collection/System/System.md).includes
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [EquipmentCollection](../../../Collection/Equipment-.md).includes