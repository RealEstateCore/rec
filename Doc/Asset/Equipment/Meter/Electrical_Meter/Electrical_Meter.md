[Index](../../../../index.md) > [Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [Meter](../Meter.md) > [Electrical_Meter](#)
# Electrical_Meter

A meter that measures the usage or consumption of electricity


**Display name:** Electrical Meter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Electrical_Meter;1

---

## Child interfaces
* [Building_Electrical_Meter](Building_Electrical_Meter.md)

---

## Relationships

### Inherited Relationships
* **[Meter](../Meter.md):** hasSubMeter, isSubMeterOf, meters
* **[Equipment](../../Equipment.md):** feeds, isFedBy
* **[Asset](../../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Meter](../Meter.md):** isVirtualMeter
* **[Equipment](../../Equipment.md):** operationalStageCount
* **[Asset](../../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../../../Point/Point.md).isPointOf
* [Space](../../../../Space/Space.md).isLocationOf
* [Agent](../../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../Equipment.md).feeds
* [Equipment](../../Equipment.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../Meter.md).meters
### Inherited
* [Asset](../../../Asset.md).hasPart
* [Asset](../../../Asset.md).isPartOf
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../../Collection/Loop/Loop.md).includes
* [System](../../../../Collection/System/System.md).includes
* [Meter](../Meter.md).hasSubMeter
* [Meter](../Meter.md).isSubMeterOf
