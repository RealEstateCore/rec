[Index](../../index.md) > [Information](../Information.md) > [Document](#)
# Document

**Display name:** Document<br />
**DTMI:** dtmi:org:w3id:rec:Document;1

---

## Child interfaces
* [LeaseContract](LeaseContract.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|documentTopic|**en**: document topic||0-Infinity|||True|
|url|**en**: URL||0-Infinity|||True|

---

## Properties

### Inherited Properties
* **[Information](../Information.md):** customTags, externalIds, name

---

## Target Of
### General
* [Point](../../Point/Point.md).isPointOf
* [Space](../../Space/Space.md).isLocationOf
* [Agent](../../Agent/Agent.md).owns
* [EquipmentCollection](../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../Collection/Portfolio.md).includes
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../PointOfInterest.md).objectOfInterest
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [Document](#).documentTopic
* [Document](#).url
* [ServiceObject](../ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [Collection](../../Collection/Collection.md).documentation
* [BuildingElement](../../BuildingElement/BuildingElement.md).documentation
* [Asset](../../Asset/Asset.md).documentation
* [Architecture](../../Space/Architecture/Architecture.md).documentation
