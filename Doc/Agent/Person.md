[Index](../index.md) > [Agent](Agent.md) > [Person](#)
# Person

A natural person (i.e., an individual human being).


**Display name:** Person<br />
**DTMI:** dtmi:org:w3id:rec:Person;1

---

## Relationships

### Inherited Relationships
* **[Agent](Agent.md):** isMemberOf

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
### Inherited
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
* [Architecture](../Space/Architecture/Architecture.md).architectedBy
* [Architecture](../Space/Architecture/Architecture.md).constructedBy
* [Architecture](../Space/Architecture/Architecture.md).operatedBy
* [Architecture](../Space/Architecture/Architecture.md).ownedBy
