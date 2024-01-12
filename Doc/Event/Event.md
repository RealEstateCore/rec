[Index](../index.md) > [Event](#)
# Event

A temporally indexed entity, e.g., an observation, a lease, a construction project, etc. Can be instantaneous (timestamp property assigned) or have temporal extent (start and end properties assigned). Subclasses may define specific behaviour and requirements, e.g., on spatial indexing, agent participation, etc.


**Display name:** Event<br />
**DTMI:** dtmi:org:w3id:rec:Event;1

---

## Child interfaces
* [ElevatorTrip](ElevatorTrip.md)
* [Lease](Lease.md)
* [PointEvent](Point-/PointEvent.md)

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|customProperties|**en**: Custom Properties||map (string->map (string->string))|True|
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|end|**en**: end|**en**: Event ending timestamp.|dateTime|True|
|identifiers|**en**: Identifiers||map (string->string)|True|
|name|**en**: name||string|True|
|start|**en**: start|**en**: Event start timestamp.|dateTime|True|
|timestamp|**en**: timestamp||dateTime|True|

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Agent](../Agent/Agent.md).owns
* [Space](../Space/Space.md).isLocationOf
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [System](../Collection/System/System.md).includes
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [Lease](Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
