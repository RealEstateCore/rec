[Index](../index.md) > [Collection](Collection.md) > [Campus](#)
# Campus

A campus represents a collection of location entities. The constituent locations may have differing legal ownership and utilization purposes, but they are generally perceived as a coherent unit or sub-region within a city or other region. E.g., a university campus, a hospital campus, a corporate campus, etc.


**Display name:** Campus<br />
**DTMI:** dtmi:org:w3id:rec:Campus;1

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|includes|**en**: includes||0-Infinity|[Architecture](../Space/Architecture/Architecture.md)||True|
### Inherited Relationships
* **[Collection](Collection.md):** documentation

---

## Properties

### Inherited Properties
* **[Collection](Collection.md):** customTags, externalIds, name

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
