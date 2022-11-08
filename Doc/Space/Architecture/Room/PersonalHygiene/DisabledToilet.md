[Index](../../../../index.md) > [Space](../../../Space.md) > [Architecture](../../Architecture.md) > [Room](../Room.md) > [PersonalHygiene](PersonalHygiene.md) > [DisabledToilet](#)
# DisabledToilet

**Display name:** Disabled toilet<br />
**DTMI:** dtmi:org:w3id:rec:DisabledToilet;1

---

## Components

### Inherited Components
* **[Architecture](../../Architecture.md):** area, capacity
* **[Space](../../../Space.md):** georeference

---

## Relationships

### Inherited Relationships
* **[Architecture](../../Architecture.md):** address, adjacentElement, architectedBy, constructedBy, containsElement, documentation, hasPoint, intersectingElement, isFedBy, operatedBy, ownedBy
* **[Space](../../../Space.md):** hasPart, isLocationOf, isPartOf

---

## Properties

### Inherited Properties
* **[Space](../../../Space.md):** customTags, externalIds, geometry, name

---

## Target Of
### General
* [Point](../../../../Point/Point.md).isPointOf
* [Space](../../../Space.md).isLocationOf
* [Agent](../../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../Architecture.md).isFedBy
* [Meter](../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [BuildingElement](../../../../BuildingElement/BuildingElement.md).locatedIn
* [Asset](../../../../Asset/Asset.md).locatedIn
* [Space](../../../Space.md).hasPart
* [Space](../../../Space.md).isPartOf
* [Apartment](../../../../Collection/Apartment.md).includes
* [RealEstate](../../../../Collection/RealEstate.md).includes
* [Campus](../../../../Collection/Campus.md).includes
* [Premises](../../../../Collection/Premises.md).includes
