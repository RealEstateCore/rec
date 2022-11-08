[Index](../../../../index.md) > [Collection](../../../Collection.md) > [System](../../System.md) > [Electrical_System](../Electrical_System.md) > [Energy_System](Energy_System.md) > [Energy_Generation_System](#)
# Energy_Generation_System

A collection of devices that generates electricity


**Display name:** Energy Generation System<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Energy_Generation_System;1

---

## Relationships

### Inherited Relationships
* **[System](../../System.md):** includes
* **[Collection](../../../Collection.md):** documentation

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Collection](../../../Collection.md):** customTags, externalIds, name

---

## Target Of
### General
* [Point](../../../../Point/Point.md).isPointOf
* [Agent](../../../../Agent/Agent.md).owns
* [Space](../../../../Space/Space.md).isLocationOf
* [Equipment](../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../Equipment-.md).feeds
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Portfolio.md).includes
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../../Asset/Equipment/Meter/Meter.md).meters
