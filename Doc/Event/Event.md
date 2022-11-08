[Index](../index.md) > [Event](#)
# Event

A temporally indexed entity, e.g., an observation, a lease, a construction project, etc. Can be instantaneous (timestamp property assigned) or have temporal extent (start and end properties assigned). Subclasses may define specific behaviour and requirements, e.g., on spatial indexing, agent participation, etc.


**Display name:** Event<br />
**DTMI:** dtmi:org:w3id:rec:Event;1

---

## Child interfaces
* [Lease](Lease.md)
* [ElevatorTrip](ElevatorTrip.md)
* [PointEvent](PointEvent/PointEvent.md)

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|end|**en**: end|**en**: Event ending timestamp.|dateTime|True|
|externalIds|**en**: External IDs||map (string->string)|True|
|name|**en**: name||string|True|
|start|**en**: start|**en**: Event start timestamp.|dateTime|True|
|timestamp|**en**: timestamp||dateTime|True|

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Space](../Space/Space.md).isLocationOf
* [Agent](../Agent/Agent.md).owns
* [EquipmentCollection](../Collection/EquipmentCollection.md).feeds
* [Portfolio](../Collection/Portfolio.md).includes
* [Lease](Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
