[Index](../index.md) > [Event](Event.md) > [ElevatorTrip](#)
# ElevatorTrip

**Display name:** Elevator trip<br />
**DTMI:** dtmi:org:w3id:rec:ElevatorTrip;1

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|currentLevel|**en**: current level||string|True|
|endLevel|**en**: end level||string|True|
|startLevel|**en**: start level||string|True|
|tripDirection|**en**: trip direction||enum (Down, Up)|True|
### Inherited Properties
* **[Event](Event.md):** customTags, end, externalIds, name, start, timestamp

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Agent](../Agent/Agent.md).owns
* [Space](../Space/Space.md).isLocationOf
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [EquipmentCollection](../Collection/Equipment-.md).feeds
* [Lease](Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
