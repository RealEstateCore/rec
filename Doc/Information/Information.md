[Index](../index.md) > [Information](#)
# Information

**Display name:** Information<br />
**DTMI:** dtmi:org:w3id:rec:Information;1

---

## Child interfaces
* [Georeference](Georeference.md)
* [ArchitectureArea](ArchitectureArea.md)
* [PostalAddress](PostalAddress.md)
* [PointOfInterest](PointOfInterest.md)
* [ArchitectureCapacity](ArchitectureCapacity.md)
* [Document](Document/Document.md)
* [ServiceObject](ServiceObject/ServiceObject.md)

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|externalIds|**en**: External IDs||map (string->string)|True|
|name|**en**: name||string|True|

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Space](../Space/Space.md).isLocationOf
* [Agent](../Agent/Agent.md).owns
* [EquipmentCollection](../Collection/EquipmentCollection.md).feeds
* [Portfolio](../Collection/Portfolio.md).includes
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](PointOfInterest.md).objectOfInterest
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Document](Document/Document.md).documentTopic
* [Document](Document/Document.md).url
* [ServiceObject](ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
