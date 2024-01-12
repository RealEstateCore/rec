[Index](../../index.md) > [Information](../Information.md) > [Georeference](#)
# Georeference

A georeference creates a relationship between a local coordinate system into a geographic coordinate system.


**Display name:** Georeference<br />
**DTMI:** dtmi:org:w3id:rec:Georeference;1

---

## Child interfaces
* [Geotransform](Geotransform.md)

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
* [System](../../Collection/System/System.md).includes
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../Document/Document.md).documentTopic
* [Document](../Document/Document.md).url
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [Space](../../Space/Space.md).georeference
