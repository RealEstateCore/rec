[Index](../index.md) > [Agent](Agent.md) > [Person](#)
# Person

A natural person (i.e., an individual human being).


**Display name:** Person<br />
**DTMI:** dtmi:org:w3id:rec:Person;1

---

## Relationships

### Inherited Relationships
* **[Agent](Agent.md):** isMemberOf, owns

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|familyName|||string|True|
|gender|**en**: gender||string|True|
|givenName|||string|True|
|image|**en**: image|**en**: URL link to an image that represents the person.|string|True|
### Inherited Properties
* **[Agent](Agent.md):** customTags, externalIds, name

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Space](../Space/Space.md).isLocationOf
* [Agent](Agent.md).owns
* [EquipmentCollection](../Collection/EquipmentCollection.md).feeds
* [Portfolio](../Collection/Portfolio.md).includes
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../Asset/Asset.md).commissionedBy
* [Asset](../Asset/Asset.md).installedBy
* [Asset](../Asset/Asset.md).manufacturedBy
* [Asset](../Asset/Asset.md).servicedBy
* [Lease](../Event/Lease.md).leasee
* [Lease](../Event/Lease.md).leasor
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).acknowledgedBy
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).closedBy
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).createdBy
* [Architecture](../Space/Architecture/Architecture.md).architectedBy
* [Architecture](../Space/Architecture/Architecture.md).constructedBy
* [Architecture](../Space/Architecture/Architecture.md).operatedBy
* [Architecture](../Space/Architecture/Architecture.md).ownedBy
* [Organization](Organization/Organization.md).hasMember
