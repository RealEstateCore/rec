[Index](../index.md) > [Information](Information.md) > [ArchitectureArea](#)
# ArchitectureArea

Describes business-relevant area measurements typically associated with architected spaces. As the exact requirements on these measurements will vary from case to case or jurisdiction to jurisdiction, subclassing and specializing this definition is encouraged.


**Display name:** Architecture area<br />
**DTMI:** dtmi:org:w3id:rec:ArchitectureArea;1

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|grossArea|**en**: gross area||float|True|
|netArea|**en**: net area||float|True|
|rentableArea|**en**: rentable area||float|True|
### Inherited Properties
* **[Information](Information.md):** customProperties, customTags, identifiers, name

---

## Target Of
### General
* [Point](../Point/Point.md).isPointOf
* [Agent](../Agent/Agent.md).owns
* [Space](../Space/Space.md).isLocationOf
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Document](Document/Document.md).documentTopic
* [Document](Document/Document.md).url
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
