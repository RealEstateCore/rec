[Index](../../index.md) > [Information](../Information.md) > [Geometry](#)
# Geometry

**Display name:** Geometry<br />
**DTMI:** dtmi:org:w3id:rec:Geometry;1

---

## Child interfaces
* [MultiPoint](MultiPoint.md)
* [MultiPolygon](MultiPolygon.md)
* [Point](Point.md)
* [Polygon](Polygon.md)

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|coordinateSystem|**en**: coordinate system||enum (LocalCoordinates, WGS84)|True|
### Inherited Properties
* **[Information](../Information.md):** customTags, externalIds, name

---

## Target Of
### General
* [Point](../../Point/Point.md).isPointOf
* [Agent](../../Agent/Agent.md).owns
* [Space](../../Space/Space.md).isLocationOf
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../Document/Document.md).documentTopic
* [Document](../Document/Document.md).url
* [EquipmentCollection](../../Collection/Equipment-.md).feeds
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [Asset](../../Asset/Asset.md).geometry
