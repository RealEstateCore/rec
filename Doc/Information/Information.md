[Index](../index.md) > [Information](#)
# Information

**Display name:** Information<br />
**DTMI:** dtmi:org:w3id:rec:Information;1

---

## Child interfaces
* [ArchitectureArea](ArchitectureArea.md)
* [ArchitectureCapacity](ArchitectureCapacity.md)
* [Document](Document/Document.md)
* [Geometry](Geometry/Geometry.md)
* [Georeference](Georeference/Georeference.md)
* [PointOfInterest](PointOfInterest.md)
* [PostalAddress](PostalAddress.md)
* [ServiceObject](ServiceObject/ServiceObject.md)

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
* [System](../Collection/System/System.md).includes
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Document](Document/Document.md).documentTopic
* [Document](Document/Document.md).url
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
