[Index](../../index.md) > [Asset](../Asset.md) > [Furniture](#)
# Furniture

**Display name:** Furniture<br />
**DTMI:** dtmi:org:w3id:rec:Furniture;1

---

## Child interfaces
* [Footrest](Footrest.md)
* [Safe](Safe.md)
* [FloorMat](FloorMat.md)
* [WasteBasket](WasteBasket.md)
* [Sofa](Sofa.md)
* [StorageCabinet](StorageCabinet.md)
* [Bookcase](Bookcase.md)
* [FilingCabinet](FilingCabinet.md)
* [BulletinBoard](BulletinBoard.md)
* [Bed](Bed.md)
* [CoatRack](CoatRack.md)
* [Cart](Cart/Cart.md)
* [Lamp](Lamp/Lamp.md)
* [Table](Table/Table.md)
* [Chair](Chair/Chair.md)
* [Stand](Stand/Stand.md)
* [Desk](Desk/Desk.md)

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
### Direct
* [FurnitureCollection](../../Collection/FurnitureCollection.md).includes
### Inherited
* [Asset](../Asset.md).hasPart
* [Asset](../Asset.md).isPartOf
