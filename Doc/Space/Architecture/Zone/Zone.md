[Index](../../../index.md) > [Space](../../Space.md) > [Architecture](../Architecture.md) > [Zone](#)
# Zone

A sub-zone within or outside of a building defined to support some technology and/or use, e.g., an HVAC zone, a parking space, a security zone, etc.


**Display name:** Zone<br />
**DTMI:** dtmi:org:w3id:rec:Zone;1

---

## Child interfaces
* [AccessControlZone](AccessControl-.md)
* [HVACZone](HVAC-.md)
* [OccupancyZone](Occupancy-.md)
* [ParkingSpace](ParkingSpace.md)
* [Workspace](Workspace.md)

---

## Components

### Inherited Components
* **[Architecture](../Architecture.md):** area, capacity
* **[Space](../../Space.md):** georeference

---

## Relationships

### Inherited Relationships
* **[Architecture](../Architecture.md):** address, adjacentElement, architectedBy, constructedBy, containsElement, documentation, hasPoint, intersectingElement, isFedBy, operatedBy, ownedBy
* **[Space](../../Space.md):** hasPart, isLocationOf, isPartOf

---

## Properties

### Inherited Properties
* **[Space](../../Space.md):** customProperties, customTags, geometry, identifiers, name

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../Collection/Equipment-.md).feeds
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../../Asset/Asset.md).locatedIn
* [BuildingElement](../../../BuildingElement/BuildingElement.md).locatedIn
* [Campus](../../../Collection/Campus.md).includes
* [Premises](../../../Collection/Premises.md).includes
* [RealEstate](../../../Collection/RealEstate.md).includes
* [Space](../../Space.md).hasPart
* [Space](../../Space.md).isPartOf
