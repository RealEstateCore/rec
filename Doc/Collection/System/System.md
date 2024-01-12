[Index](../../index.md) > [Collection](../Collection.md) > [System](#)
# System

A System is a combination of equipment and auxiliary devices (e.g., controls, accessories, interconnecting means, and termi­nal elements) by which energy is transformed so it performs a specific function such as HVAC, service water heating, or lighting. (ASHRAE Dictionary).


**Display name:** System<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:System;1

---

## Child interfaces
* [Domestic_Hot_Water_System](Domestic_Hot_Water-.md)
* [Electrical_System](Electrical-/Electrical_System.md)
* [Gas_System](Gas-.md)
* [Heating_Ventilation_Air_Conditioning_System](Heating_Ventilation_Air_Conditioning-/Heating_Ventilation_Air_Conditioning_System.md)
* [HVAC_System](HVAC-.md)
* [Lighting_System](Lighting-.md)
* [Safety_System](Safety-/Safety_System.md)
* [Shading_System](Shading-/Shading_System.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|includes|**en**: includes||0-Infinity|||True|
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
* [System](#).includes
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../Portfolio.md).includes
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
