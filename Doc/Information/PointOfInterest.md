[Index](../index.md) > [Information](Information.md) > [PointOfInterest](#)
# PointOfInterest

**Display name:** Point of Interest<br />
**DTMI:** dtmi:org:w3id:rec:PointOfInterest;1

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|objectOfInterest|**en**: object of interest||0-1|||True|

---

## Properties

### Inherited Properties
* **[Information](Information.md):** customTags, externalIds, name

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Space](../Space/Space.md).isLocationOf
* [Agent](../Agent/Agent.md).owns
* [EquipmentCollection](../Collection/EquipmentCollection.md).feeds
* [Portfolio](../Collection/Portfolio.md).includes
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](#).objectOfInterest
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Document](Document/Document.md).documentTopic
* [Document](Document/Document.md).url
* [ServiceObject](ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
