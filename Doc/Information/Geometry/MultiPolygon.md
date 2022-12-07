[Index](../../index.md) > [Information](../Information.md) > [Geometry](Geometry.md) > [MultiPolygon](#)
# MultiPolygon

**Display name:** Multi polygon<br />
**DTMI:** dtmi:org:w3id:rec:MultiPolygon;1

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|coordinates|**en**: coordinates|**en**: A GeoJSON MultiPolygon coordinate listing. Coordinates may be expressed in two or three dimensions. Ex: [[[[30.0, 20.0], [45.0, 40.0], [10.0, 40.0], [30.0, 20.0]]], [[[15.0, 5.0], [40.0, 10.0], [10.0, 20.0], [5.0, 10.0], [15.0, 5.0]]]].|string|True|
### Inherited Properties
* **[Geometry](Geometry.md):** coordinateSystem
* **[Information](../Information.md):** customProperties, customTags, identifiers, name

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
### Inherited
* [Asset](../../Asset/Asset.md).geometry
* [Space](../../Space/Space.md).geometry
