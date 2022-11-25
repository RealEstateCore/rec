[Index](../../../index.md) > [Collection](../../Collection.md) > [System](../System.md) > [Safety_System](Safety_System.md) > [Fire_Safety_System](#)
# Fire_Safety_System

A system containing devices and equipment that monitor, detect and suppress fire hazards


**Display name:** Fire Safety System<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Fire_Safety_System;1

---

## Relationships

### Inherited Relationships
* **[System](../System.md):** includes
* **[Collection](../../Collection.md):** documentation

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Collection](../../Collection.md):** customTags, externalIds, name

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
* [EquipmentCollection](../../Equipment-.md).feeds
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
