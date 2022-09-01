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
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|externalIds|**en**: External IDs||map (string->string)|True|
|name|**en**: name||string|True|

---

## Target Of
### Direct
* [Asset](../Asset/Asset.md).mountedOn
* [BuildingElement](#).hasPart
* [BuildingElement](#).isPartOf
* [Architecture](../Space/Architecture/Architecture.md).adjacentElement
* [Architecture](../Space/Architecture/Architecture.md).containsElement
* [Architecture](../Space/Architecture/Architecture.md).intersectingElement
