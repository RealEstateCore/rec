[Index](../index.md) > [Information](Information.md) > [Georeference](#)
# Georeference

Encapsulates a georeference globally placing a spatially located entity in terms of latitude, longitude, altitude, and bearing.


**Display name:** Georeference<br />
**DTMI:** dtmi:org:w3id:rec:Georeference;1

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|alt|**en**: alt|**en**: Altitude|float|True|
|bearing|**en**: bearing|**en**: The angle between local coordinate system and a north-south meridian.|float|True|
|lat|**en**: lat|**en**: Latitude|float|True|
|long|**en**: long|**en**: Longitude|float|True|
### Inherited Properties
* **[Information](Information.md):** customProperties, customTags, identifiers, name

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Agent](../Agent/Agent.md).owns
* [Space](../Space/Space.md).isLocationOf
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Document](Document/Document.md).documentTopic
* [Document](Document/Document.md).url
* [EquipmentCollection](../Collection/Equipment-.md).feeds
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
