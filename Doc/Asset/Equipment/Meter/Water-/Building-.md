[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [Meter](../Meter.md) > [Water_Meter](Water_Meter.md) > [Building_Water_Meter](#)
# Building_Water_Meter

A meter that measures the usage or consumption of water of a whole building


**Display name:** Building Water Meter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Building_Water_Meter;1

---

## Relationships

### Inherited Relationships
* **[Equipment](../../Equipment.md):** feeds, isFedBy
* **[Meter](../Meter.md):** hasSubMeter, isSubMeterOf, meters
* **[Asset](../../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Equipment](../../Equipment.md):** operationalStageCount
* **[Meter](../Meter.md):** isVirtualMeter
* **[Asset](../../../Asset.md):** assetTag, commissioningDate, customProperties, customTags, geometry, identifiers, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../../../Point/Point.md).isPointOf
* [Agent](../../../../Agent/Agent.md).owns
* [Space](../../../../Space/Space.md).isLocationOf
* [Equipment](../../Equipment.md).feeds
* [Equipment](../../Equipment.md).isFedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../../Collection/Equipment-.md).feeds
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Meter.md).meters
### Inherited
* [Loop](../../../../Collection/Loop/Loop.md).includes
* [Meter](../Meter.md).hasSubMeter
* [Meter](../Meter.md).isSubMeterOf
* [System](../../../../Collection/System/System.md).includes
* [Asset](../../../Asset.md).hasPart
* [Asset](../../../Asset.md).isPartOf
* [EquipmentCollection](../../../../Collection/Equipment-.md).includes
