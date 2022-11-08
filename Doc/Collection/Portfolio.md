[Index](../index.md) > [Collection](Collection.md) > [Portfolio](#)
# Portfolio

A portfolio is a grouping of buildings, sites, apartments, campuses, etc. that share some business-relevant commonality, e.g., are managed by the same company, are rented out to the same tenant, share utilization or legal definition (industrial vs commercial), etc.


**Display name:** Portfolio<br />
**DTMI:** dtmi:org:w3id:rec:Portfolio;1

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|includes|**en**: includes||0-Infinity|||True|
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
* [Portfolio](#).includes
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
