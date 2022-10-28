[Index](../index.md) > [Space](#)
# Space

A contiguous part of the physical world that contains or can contain sub-spaces. E.g., a Region can contain many Sites, which in turn can contain many Buildings.


**Display name:** Space<br />
**DTMI:** dtmi:org:w3id:rec:Space;1

---

## Child interfaces
* [Region](Region.md)
* [Architecture](Architecture/Architecture.md)

---

## Components

|Name|Display name|Description|Schema|
|-|-|-|-|
|georeference|**en**: georeference|**en**: A fixed point for, e.g., a building structure. Commonly refered to as "insertion point" in CAD-programs. Used as origo for locally defined geometries.|[Georeference](../Information/Georeference.md)|

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|hasPart|**en**: has part||0-Infinity|[Space](#)||True|
|isLocationOf|**en**: is location of||0-Infinity|||True|
|isPartOf|**en**: is part of||0-1|[Space](#)||True|

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|externalIds|**en**: External IDs||map (string->string)|True|
|geometry|**en**: geometry|**en**: A GeoJSON Polygon coordinate listing representing the geometrical representation of the space. Coordinates may be expressed in two or three dimensions. Ex: [[30.0, 10.0, 0.0], [40.0, 40.0, 2.0], [20.0, 40.0, 2.0], [10.0, 20.0, 2.0], [30.0, 10.0, 0.0]].|string|True|
|name|**en**: name||string|True|

---

## Target Of
### Direct
* [Asset](../Asset/Asset.md).locatedIn
* [Space](#).hasPart
* [Space](#).isPartOf
