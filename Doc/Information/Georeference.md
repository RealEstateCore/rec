[Index](../index.md) > [Information](Information.md) > [Georeference](#)
# Georeference

A georeference provides linkage between the local coordinate system used within a building (e.g., measured in meters) and a global coordinate system (e.g., lat, long, alt), such that locally placed Spaces can be resolved and rendered in that global coordinate system (e.g., for mapping purposes).


**Display name:** Georeference<br />
**DTMI:** dtmi:org:w3id:rec:Georeference;1

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|bearing|**en**: bearing|**en**: The angle between the Y-axis of the local coordinate system and a global north-south meridian.|double|True|
|referencePoint|**en**: reference point|**en**: A GeoJSON Point coordinate indicating the placement of the local coordinate system origin point (0,0) in the containing global coordinate system. Units: X and Y coordinates in decimal degrees, altitude (if present) in meters.|Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
### Inherited Properties
* **[Information](Information.md):** customTags, externalIds, name

---

## Target Of
