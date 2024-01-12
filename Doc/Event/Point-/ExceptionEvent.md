[Index](../../index.md) > [Event](../Event.md) > [PointEvent](PointEvent.md) > [ExceptionEvent](#)
# ExceptionEvent

**Display name:** Exception event<br />
**DTMI:** dtmi:org:w3id:rec:ExceptionEvent;1

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|sourcePoint|**en**: source point|**en**: The brick:Point that emitted this exception.|0-1|[Point](../../Point/Point.md)||True|

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|value|**en**: value|**en**: The message of this exception event.|string|True|
### Inherited Properties
* **[Event](../Event.md):** customProperties, customTags, end, identifiers, name, start, timestamp

---

## Target Of
### General
* [Point](../../Point/Point.md).isPointOf
* [Agent](../../Agent/Agent.md).owns
* [Space](../../Space/Space.md).isLocationOf
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [System](../../Collection/System/System.md).includes
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [Lease](../Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
