[Index](../index.md) > [Space](#)
# Space

A contiguous part of the physical world that contains or can contain sub-spaces. E.g., a Region can contain many Sites, which in turn can contain many Buildings.


**Display name:** Space<br />
**DTMI:** dtmi:org:w3id:rec:Space;1

---

## Child interfaces
* [Architecture](Architecture/Architecture.md)
* [Region](Region.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|geometry|**en**: geometry|**en**: Polygon representing the spatial extent of this Space.|0-1|[Geometry](../Information/Geometry/Geometry.md)||True|
|georeference|**en**: georeference|**en**: A georeference creates a relationship between the local coordinate system used within a building (e.g., measured in meters) and a geographic coordinate system (e.g., lat, long, alt), such that locally placed Spaces can be resolved and rendered in that geographic coordinate system (e.g., for mapping purposes).|0-1|[Georeference](../Information/Georeference/Georeference.md)||True|
|hasPart|**en**: has part||0-Infinity|[Space](#)||True|
|isLocationOf|**en**: is location of||0-Infinity|||True|
|isPartOf|**en**: is part of||0-1|[Space](#)||True|

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|customProperties|**en**: Custom Properties||map (string->map (string->string))|True|
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|identifiers|**en**: Identifiers||map (string->string)|True|
|name|**en**: name||string|True|

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Agent](../Agent/Agent.md).owns
* [Space](#).isLocationOf
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](Architecture/Architecture.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [EquipmentCollection](../Collection/Equipment-.md).feeds
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [Asset](../Asset/Asset.md).locatedIn
* [Space](#).hasPart
* [Space](#).isPartOf
