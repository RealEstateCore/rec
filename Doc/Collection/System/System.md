[Index](../../index.md) > [Collection](../Collection.md) > [System](#)
# System

A System is a combination of equipment and auxiliary devices (e.g., controls, accessories, interconnecting means, and termi­nal elements) by which energy is transformed so it performs a specific function such as HVAC, service water heating, or lighting. (ASHRAE Dictionary).


**Display name:** System<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:System;1

---

## Child interfaces
* [Lighting_System](Lighting_System.md)
* [Domestic_Hot_Water_System](Domestic_Hot_Water_System.md)
* [Gas_System](Gas_System.md)
* [HVAC_System](HVAC_System.md)
* [Safety_System](Safety_System/Safety_System.md)
* [Electrical_System](Electrical_System/Electrical_System.md)
* [Heating_Ventilation_Air_Conditioning_System](Heating_Ventilation_Air_Conditioning_System/Heating_Ventilation_Air_Conditioning_System.md)
* [Shading_System](Shading_System/Shading_System.md)

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
* **[Collection](../Collection.md):** customTags, externalIds, name

---

## Target Of
### General
* [Point](../../Point/Point.md).isPointOf
* [Space](../../Space/Space.md).isLocationOf
* [Agent](../../Agent/Agent.md).owns
* [EquipmentCollection](../EquipmentCollection.md).feeds
* [Portfolio](../Portfolio.md).includes
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
