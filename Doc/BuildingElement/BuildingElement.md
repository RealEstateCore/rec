[Index](../index.md) > [BuildingElement](#)
# BuildingElement

A part that constitutes a piece of a building's structural makeup. E.g., Facade, Wall, Slab, Roof, etc.


**Display name:** Building element<br />
**DTMI:** dtmi:org:w3id:rec:BuildingElement;1

---

## Child interfaces
* [Balcony](Balcony.md)
* [Facade](Facade.md)
* [Roof](Roof.md)
* [Slab](Slab.md)
* [Wall](Wall/Wall.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|documentation|**en**: documentation||0-Infinity|[Document](../Information/Document/Document.md)||True|
|hasPart|**en**: has part||0-Infinity|[BuildingElement](#)||True|
|isPartOf|**en**: is part of||0-1|[BuildingElement](#)||True|
|locatedIn|**en**: located in|**en**: Indicates the architected space (site, building, level, room...) in which this building element is placed.|0-1|[Architecture](../Space/Architecture/Architecture.md)||True|

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
* [Space](../Space/Space.md).isLocationOf
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [EquipmentCollection](../Collection/Equipment-.md).feeds
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [Architecture](../Space/Architecture/Architecture.md).adjacentElement
* [Architecture](../Space/Architecture/Architecture.md).containsElement
* [Architecture](../Space/Architecture/Architecture.md).intersectingElement
* [Asset](../Asset/Asset.md).mountedOn
* [BuildingElement](#).hasPart
* [BuildingElement](#).isPartOf
