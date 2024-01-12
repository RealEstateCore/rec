[Index](../index.md) > [Agent](Agent.md) > [Person](#)
# Person

A natural person (i.e., an individual human being).


**Display name:** Person<br />
**DTMI:** dtmi:org:w3id:rec:Person;1

---

## Relationships

### Inherited Relationships
* **[Agent](Agent.md):** isMemberOf, memberOf, owns

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|familyName|||string|True|
|gender|**en**: gender||string|True|
|givenName|||string|True|
|image|**en**: image|**en**: URL link to an image that represents the person.|string|True|
### Inherited Properties
* **[Agent](Agent.md):** customProperties, customTags, identifiers, name

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Agent](Agent.md).owns
* [Space](../Space/Space.md).isLocationOf
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [System](../Collection/System/System.md).includes
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Architecture](../Space/Architecture/Architecture.md).architectedBy
* [Architecture](../Space/Architecture/Architecture.md).constructedBy
* [Architecture](../Space/Architecture/Architecture.md).operatedBy
* [Architecture](../Space/Architecture/Architecture.md).ownedBy
* [Asset](../Asset/Asset.md).commissionedBy
* [Asset](../Asset/Asset.md).installedBy
* [Asset](../Asset/Asset.md).manufacturedBy
* [Asset](../Asset/Asset.md).servicedBy
* [Lease](../Event/Lease.md).leasee
* [Lease](../Event/Lease.md).leasor
* [Organization](Organization/Organization.md).hasMember
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).acknowledgedBy
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).closedBy
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).createdBy
