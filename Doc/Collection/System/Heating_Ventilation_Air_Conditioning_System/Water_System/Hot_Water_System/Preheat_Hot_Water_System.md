[Index](../../../../../index.md) > [Collection](../../../../Collection.md) > [System](../../../System.md) > [Heating_Ventilation_Air_Conditioning_System](../../Heating_Ventilation_Air_Conditioning_System.md) > [Water_System](../Water_System.md) > [Hot_Water_System](Hot_Water_System.md) > [Preheat_Hot_Water_System](#)
# Preheat_Hot_Water_System

**Display name:** Preheat Hot Water System<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Preheat_Hot_Water_System;1

---

## Relationships

### Inherited Relationships
* **[System](../../../System.md):** includes
* **[Collection](../../../../Collection.md):** documentation

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Collection](../../../../Collection.md):** customTags, externalIds, name

---

## Target Of
### General
* [Point](../../../../../Point/Point.md).isPointOf
* [Space](../../../../../Space/Space.md).isLocationOf
* [Agent](../../../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../../EquipmentCollection.md).feeds
* [Portfolio](../../../../Portfolio.md).includes
* [Lease](../../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../../Information/Document/Document.md).url
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../../../Asset/Equipment/Meter/Meter.md).meters
