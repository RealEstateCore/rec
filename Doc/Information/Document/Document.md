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
* [Document](#).documentTopic
* [Document](#).url
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [Architecture](../../Space/Architecture/Architecture.md).documentation
* [Asset](../../Asset/Asset.md).documentation
* [BuildingElement](../../BuildingElement/BuildingElement.md).documentation
* [Collection](../../Collection/Collection.md).documentation
