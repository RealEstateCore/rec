[Index](../../../index.md) > [Space](../../Space.md) > [Architecture](../Architecture.md) > [Level](#)
# Level

The level of a building, a.k.a. storey, floor, etc.


**Display name:** Level<br />
**DTMI:** dtmi:org:w3id:rec:Level;1

---

## Child interfaces
* [BasementLevel](Basement-.md)
* [MezzanineLevel](Mezzanine-.md)
* [RoofLevel](Roof-.md)

---

## Components

### Inherited Components
* **[Architecture](../Architecture.md):** area, capacity

---

## Relationships

### Inherited Relationships
* **[Architecture](../Architecture.md):** address, adjacentElement, architectedBy, constructedBy, containsElement, documentation, hasPoint, intersectingElement, isFedBy, operatedBy, ownedBy
* **[Space](../../Space.md):** geometry, georeference, hasPart, isLocationOf, isPartOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|levelNumber|**en**: level number|**en**: A number indicating the ordinal number of this level within the containing space (typically a Building or in the case of a Mezzanine, sometimes another level). Note that the implementation of this numbering scheme and its starting point is implementation-specific; e.g., the fifth floor below ground may be 0 in some systems, and -5 in others.|integer|True|
### Inherited Properties
* **[Space](../../Space.md):** customProperties, customTags, identifiers, name

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [System](../../../Collection/System/System.md).includes
* [Architecture](../Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
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
