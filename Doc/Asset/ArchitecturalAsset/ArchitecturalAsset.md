[Index](../../index.md) > [Asset](../Asset.md) > [ArchitecturalAsset](#)
# ArchitecturalAsset

**Display name:** Architectural asset<br />
**DTMI:** dtmi:org:w3id:rec:ArchitecturalAsset;1

---

## Child interfaces
* [BarrierAsset](BarrierAsset/BarrierAsset.md)

---

## Relationships

### Inherited Relationships
* **[Asset](../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Asset](../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../Point/Point.md).isPointOf
* [Space](../../Space/Space.md).isLocationOf
* [Agent](../../Agent/Agent.md).owns
* [EquipmentCollection](../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../Collection/Portfolio.md).includes
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../Equipment/Equipment.md).feeds
* [Equipment](../Equipment/Equipment.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../Asset.md).hasPart
* [Asset](../Asset.md).isPartOf
