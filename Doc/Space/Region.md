[Index](../index.md) > [Space](Space.md) > [Region](#)
# Region

An administrative geospatial unit larger than the individual real estate. For instance, "Lombary", "North America", "The Back Bay", "Elnätsområde Syd", etc.


**Display name:** Region<br />
**DTMI:** dtmi:org:w3id:rec:Region;1

---

## Relationships

### Inherited Relationships
* **[Space](Space.md):** geometry, georeference, hasPart, isLocationOf, isPartOf

---

## Properties

### Inherited Properties
* **[Space](Space.md):** customProperties, customTags, identifiers, name

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Agent](../Agent/Agent.md).owns
* [Space](Space.md).isLocationOf
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](Architecture/Architecture.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../Asset/Asset.md).locatedIn
* [Space](Space.md).hasPart
* [Space](Space.md).isPartOf
