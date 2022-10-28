[Index](../index.md) > [Asset](#)
# Asset

Something which is placed inside of a building, but is not an integral part of that building's structure; e.g., furniture, equipment, systems, etc.


**Display name:** Asset<br />
**DTMI:** dtmi:org:w3id:rec:Asset;1

---

## Child interfaces
* [Equipment](Equipment/Equipment.md)
* [ArchitecturalAsset](ArchitecturalAsset/ArchitecturalAsset.md)
* [Furniture](Furniture/Furniture.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|commissionedBy|**en**: commissioned by||0-Infinity|[Agent](../Agent/Agent.md)||True|
|documentation|**en**: documentation||0-Infinity|[Document](../Information/Document/Document.md)||True|
|hasPart|**en**: has part||0-Infinity|[Asset](#)||True|
|hasPoint|**en**: has point||0-Infinity|[Point](../Point/Point.md)||True|
|installedBy|**en**: installed by||0-Infinity|[Agent](../Agent/Agent.md)||True|
|isPartOf|**en**: is part of||0-Infinity|[Asset](#)||True|
|locatedIn|**en**: located in||0-Infinity|[Space](../Space/Space.md)||True|
|manufacturedBy|**en**: manufactured by||0-Infinity|[Agent](../Agent/Agent.md)||True|
|mountedOn|**en**: mounted on|**en**: An asset may be mounted on some part of the building construction (e.g., a blind on a facade, a camera on a wall, etc).|0-1|[BuildingElement](../BuildingElement/BuildingElement.md)||True|
|servicedBy|**en**: serviced by||0-Infinity|[Agent](../Agent/Agent.md)||True|

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|IPAddress|**en**: IP address||string|True|
|MACAddress|**en**: MAC address||string|True|
|assetTag|**en**: asset tag||string|True|
|commissioningDate|**en**: commissioning date||date|True|
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|externalIds|**en**: External IDs||map (string->string)|True|
|geometry|**en**: geometry|**en**: A GeoJSON Polygon coordinate listing representing the geometrical representation of the asset. Coordinates may be expressed in two or three dimensions. Ex: [[30.0, 10.0, 0.0], [40.0, 40.0, 2.0], [20.0, 40.0, 2.0], [10.0, 20.0, 2.0], [30.0, 10.0, 0.0]].|string|True|
|initialCost|**en**: initial cost||string|True|
|installationDate|**en**: installation date||date|True|
|maintenanceInterval|**en**: maintenance interval||duration|True|
|modelNumber|**en**: model number||string|True|
|name|**en**: name||string|True|
|serialNumber|**en**: serial number||string|True|
|turnoverDate|**en**: turnover date||date|True|
|weight|**en**: weight||string|True|

---

## Target Of
### Direct
* [Asset](#).hasPart
* [Asset](#).isPartOf
