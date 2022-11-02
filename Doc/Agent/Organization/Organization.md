[Index](../../index.md) > [Agent](../Agent.md) > [Organization](#)
# Organization

An organization of any sort (e.g., a business, association, project, consortium, tribe, etc.)


**Display name:** Organization<br />
**DTMI:** dtmi:org:w3id:rec:Organization;1

---

## Child interfaces
* [Department](Department.md)
* [Company](Company.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|hasMember|**en**: has member|**en**: Indicates membership in an organization. Note that componency (e.g., departments of a corporation) are expressed using the more generic hasPart property.|0-Infinity|[Agent](../Agent.md)||True|
|hasPart|**en**: has part|**en**: Indicates parthood relations in organizations (e.g., departments of a corporation). Note that membership in an organization is expressed using the more specific hasMember property.|0-Infinity|[Organization](#)||True|
|isPartOf|**en**: is part of|**en**: Indicates parthood relations in organizations (e.g., departments of a corporation). Note that membership in an organization is expressed using the Agent.isMemberOf property.|0-Infinity|[Organization](#)||True|
### Inherited Relationships
* **[Agent](../Agent.md):** isMemberOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|logo|**en**: logo|**en**: URL link to an image/logo that represents the organization.|string|True|
### Inherited Properties
* **[Agent](../Agent.md):** customTags, externalIds, name

---

## Target Of
### Direct
* [Agent](../Agent.md).isMemberOf
* [Organization](#).hasPart
* [Organization](#).isPartOf
### Inherited
* [Asset](../../Asset/Asset.md).commissionedBy
* [Asset](../../Asset/Asset.md).installedBy
* [Asset](../../Asset/Asset.md).manufacturedBy
* [Asset](../../Asset/Asset.md).servicedBy
* [Lease](../../Event/Lease.md).leasee
* [Lease](../../Event/Lease.md).leasor
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).acknowledgedBy
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).closedBy
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).createdBy
* [Architecture](../../Space/Architecture/Architecture.md).architectedBy
* [Architecture](../../Space/Architecture/Architecture.md).constructedBy
* [Architecture](../../Space/Architecture/Architecture.md).operatedBy
* [Architecture](../../Space/Architecture/Architecture.md).ownedBy
* [Organization](#).hasMember
