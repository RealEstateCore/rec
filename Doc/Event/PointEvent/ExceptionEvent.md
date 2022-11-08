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

### Inherited Properties
* **[PointEvent](PointEvent.md):** payload
* **[Event](../Event.md):** customTags, end, externalIds, name, start, timestamp

---

## Target Of
### General
* [Point](../../Point/Point.md).isPointOf
* [Space](../../Space/Space.md).isLocationOf
* [Agent](../../Agent/Agent.md).owns
* [EquipmentCollection](../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../Collection/Portfolio.md).includes
* [Lease](../Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
