[Index](../index.md) > [Collection](#)
# Collection

An administrative grouping of entities that are adressed and treated as a unit for some purpose. These entities may have some spatial arrangement (e.g., an apartment is typically contiguous) but that is not a requirement (see, e.g., a distributed campus consisting of spatially disjoint plots or buildings). Inclusion in a Collection is determined by the 'includes' field on a specific subclass.


**Display name:** Collection<br />
**DTMI:** dtmi:org:w3id:rec:Collection;1

---

## Child interfaces
* [Loop](Loop/Loop.md)
* [PV_Array](PV_Array.md)
* [System](System/System.md)
* [Apartment](Apartment.md)
* [Campus](Campus.md)
* [EquipmentCollection](Equipment-.md)
* [FurnitureCollection](Furniture-.md)
* [Portfolio](Portfolio.md)
* [Premises](Premises.md)
* [RealEstate](RealEstate.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|documentation|**en**: documentation||0-Infinity|[Document](../Information/Document/Document.md)||True|

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
* [Agent](../Agent/Agent.md).owns
* [Space](../Space/Space.md).isLocationOf
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [System](System/System.md).includes
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](Portfolio.md).includes
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
