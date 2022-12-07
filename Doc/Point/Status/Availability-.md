[Index](../../index.md) > [Point](../Point.md) > [Status](Status.md) > [Availability_Status](#)
# Availability_Status

Indicates if a piece of equipment, system, or functionality is available for operation


**Display name:** Availability Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Availability_Status;1

---

## Relationships

### Inherited Relationships
* **[Point](../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Point](../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name
* **[Status](Status.md):** lastKnownValue

---

## Target Of
### General
* [Point](../Point.md).isPointOf
* [Agent](../../Agent/Agent.md).owns
* [Space](../../Space/Space.md).isLocationOf
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [EquipmentCollection](../../Collection/Equipment-.md).feeds
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../Event/Point-/ObservationEvent.md).sourcePoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
