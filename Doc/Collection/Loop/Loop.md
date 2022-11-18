[Index](../../index.md) > [Collection](../Collection.md) > [Loop](#)
# Loop

A collection of connected equipment; part of a System


**Display name:** Loop<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Loop;1

---

## Child interfaces
* [Air_Loop](Air-.md)
* [Water_Loop](Water-/Water_Loop.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|includes|**en**: includes||0-Infinity|[Equipment](../../Asset/Equipment/Equipment.md)||True|
### Inherited Relationships
* **[Collection](../Collection.md):** documentation

---

## Properties

### Inherited Properties
* **[Collection](../Collection.md):** customProperties, customTags, identifiers, name

---

## Target Of
### General
* [Point](../../Point/Point.md).isPointOf
* [Agent](../../Agent/Agent.md).owns
* [Space](../../Space/Space.md).isLocationOf
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [EquipmentCollection](../Equipment-.md).feeds
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../Portfolio.md).includes
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
