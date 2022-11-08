[Index](../index.md) > [Event](Event.md) > [Lease](#)
# Lease

**Display name:** Lease<br />
**DTMI:** dtmi:org:w3id:rec:Lease;1

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|leaseOf|**en**: lease of|**en**: The object (e.g., property, equipment, etc) that this a lease of.|0-Infinity|||True|
|leasee|**en**: leasee|**en**: The agent leasing some leasable object, i.e., the user of the asset.|0-Infinity|[Agent](../Agent/Agent.md)||True|
|leasor|**en**: leasor|**en**: The agent leasing out some leasable object, i.e., the owner of the asset.|0-Infinity|[Agent](../Agent/Agent.md)||True|
|regulatedBy|**en**: regulated by|**en**: Indicates the contract regulating the terms of the lease in question. |0-Infinity|[LeaseContract](../Information/Document/LeaseContract.md)||True|

---

## Properties

### Inherited Properties
* **[Event](Event.md):** customTags, end, externalIds, name, start, timestamp

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Space](../Space/Space.md).isLocationOf
* [Agent](../Agent/Agent.md).owns
* [EquipmentCollection](../Collection/EquipmentCollection.md).feeds
* [Portfolio](../Collection/Portfolio.md).includes
* [Lease](#).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [LeaseContract](../Information/Document/LeaseContract.md).regulates
