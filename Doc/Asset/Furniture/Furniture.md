[Index](../../index.md) > [Asset](../Asset.md) > [Furniture](#)
# Furniture

**Display name:** Furniture<br />
**DTMI:** dtmi:org:w3id:rec:Furniture;1

---

## Child interfaces
* [Bed](Bed.md)
* [Bookcase](Bookcase.md)
* [BulletinBoard](BulletinBoard.md)
* [Cart](Cart/Cart.md)
* [Chair](Chair/Chair.md)
* [CoatRack](CoatRack.md)
* [Desk](Desk/Desk.md)
* [FilingCabinet](FilingCabinet.md)
* [FloorMat](FloorMat.md)
* [Footrest](Footrest.md)
* [Lamp](Lamp/Lamp.md)
* [Safe](Safe.md)
* [Sofa](Sofa.md)
* [Stand](Stand/Stand.md)
* [StorageCabinet](StorageCabinet.md)
* [Table](Table/Table.md)
* [WasteBasket](WasteBasket.md)

---

## Relationships

### Inherited Relationships
* **[Asset](../Asset.md):** commissionedBy, documentation, geometry, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Asset](../Asset.md):** assetTag, commissioningDate, customProperties, customTags, identifiers, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../Point/Point.md).isPointOf
* [Agent](../../Agent/Agent.md).owns
* [Space](../../Space/Space.md).isLocationOf
* [Equipment](../Equipment/Equipment.md).feeds
* [Equipment](../Equipment/Equipment.md).isFedBy
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Equipment/Meter/Meter.md).meters
### Direct
* [FurnitureCollection](../../Collection/Furniture-.md).includes
### Inherited
* [Asset](../Asset.md).hasPart
* [Asset](../Asset.md).isPartOf
