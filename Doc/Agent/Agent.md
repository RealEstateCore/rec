[Index](../index.md) > [Agent](#)
# Agent

The human, group, or machine that consumes or acts upon an object or data. This higher-level grouping allows properties that are shared among its subclasses (Person, Organization, ....) to be anchored in one joint place, on the Agent class.


**Display name:** Agent<br />
**DTMI:** dtmi:org:w3id:rec:Agent;1

---

## Child interfaces
* [Organization](Organization/Organization.md)
* [Person](Person.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|isMemberOf|**en**: is member of|**en**: Indicates membership in an organization. Note that componency (e.g., departments of a corporation) are expressed using the more generic Organization.isPartOf property.|0-Infinity|[Organization](Organization/Organization.md)||True|
|owns|**en**: owns|**en**: Indicates ownership of some thing, e.g., a building, an asset, an organization, etc.|0-Infinity|||True|

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|customProperties|**en**: Custom Properties||map (string->map (string->string))|True|
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|identifiers|**en**: Identifiers||map (string->string)|True|
|name|**en**: name||string|True|

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Agent](#).owns
* [Space](../Space/Space.md).isLocationOf
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
### Direct
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
