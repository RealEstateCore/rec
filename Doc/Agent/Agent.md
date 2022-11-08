[Index](../index.md) > [Agent](#)
# Agent

The human, group, or machine that consumes or acts upon an object or data. This higher-level grouping allows properties that are shared among its subclasses (Person, Organization, ....) to be anchored in one joint place, on the Agent class.


**Display name:** Agent<br />
**DTMI:** dtmi:org:w3id:rec:Agent;1

---

## Child interfaces
* [Person](Person.md)
* [Organization](Organization/Organization.md)

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
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|externalIds|**en**: External IDs||map (string->string)|True|
|name|**en**: name||string|True|

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Space](../Space/Space.md).isLocationOf
* [Agent](#).owns
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
### Direct
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
