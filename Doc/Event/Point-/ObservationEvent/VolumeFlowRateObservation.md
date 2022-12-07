[Index](../../../index.md) > [Event](../../Event.md) > [PointEvent](../PointEvent.md) > [ObservationEvent](ObservationEvent.md) > [VolumeFlowRateObservation](#)
# VolumeFlowRateObservation

**Display name:** Volume flow observation<br />
**DTMI:** dtmi:org:w3id:rec:VolumeFlowRateObservation;1

---

## Relationships

### Inherited Relationships
* **[ObservationEvent](ObservationEvent.md):** sourcePoint

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|value|**en**: value||double|True|
### Inherited Properties
* **[Event](../../Event.md):** customProperties, customTags, end, identifiers, name, start, timestamp
* **[PointEvent](../PointEvent.md):** payload

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../Collection/Equipment-.md).feeds
* [Lease](../../Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
