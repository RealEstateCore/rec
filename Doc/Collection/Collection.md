[Index](../index.md) > [Collection](#)
# Collection

An administrative grouping of entities that are adressed and treated as a unit for some purpose. These entities may have some spatial arrangement (e.g., an apartment is typically contiguous) but that is not a requirement (see, e.g., a distributed campus consisting of spatially disjoint plots or buildings). Inclusion in a Collection is determined by the 'includes' field on a specific subclass.


**Display name:** Collection<br />
**DTMI:** dtmi:org:w3id:rec:Collection;1

---

## Child interfaces
* [PV_Array](PV_Array.md)
* [EquipmentCollection](EquipmentCollection.md)
* [Apartment](Apartment.md)
* [RealEstate](RealEstate.md)
* [FurnitureCollection](FurnitureCollection.md)
* [Campus](Campus.md)
* [Premises](Premises.md)
* [Portfolio](Portfolio.md)
* [Loop](Loop/Loop.md)
* [System](System/System.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|documentation|**en**: documentation||0-Infinity|[Document](../Information/Document/Document.md)||True|

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
* [Agent](../Agent/Agent.md).owns
* [EquipmentCollection](EquipmentCollection.md).feeds
* [Portfolio](Portfolio.md).includes
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
