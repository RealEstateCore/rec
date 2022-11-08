[Index](../../index.md) > [Event](../Event.md) > [PointEvent](#)
# PointEvent

An event emanating from or targeting a Point; e.g., an individual Observation from a Sensor point, or an Actuation sent to a Command point. In other terms, the Points indicate the capability of some Space or Equipment to emit or accept data, while this class represents those actual data messages. Note that in most non-trivially sized systems, these events are not stored in the knowledge graph itself, but are rather forwarded to some C&C system or time series database.


**Display name:** Point event<br />
**DTMI:** dtmi:org:w3id:rec:PointEvent;1

---

## Child interfaces
* [ActuationEvent](ActuationEvent.md)
* [ObservationEvent](ObservationEvent.md)
* [ExceptionEvent](ExceptionEvent.md)

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|payload|**en**: payload|**en**: The payload message of this point event (e.g., a sensor reading, a command message, an exception message, etc.)|string|True|
### Inherited Properties
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
