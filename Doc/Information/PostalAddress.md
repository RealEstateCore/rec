[Index](../index.md) > [Information](Information.md) > [PostalAddress](#)
# PostalAddress

**Display name:** Postal address<br />
**DTMI:** dtmi:org:w3id:rec:PostalAddress;1

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|addressLine1|**en**: address line 1||string|True|
|addressLine2|**en**: address line 2||string|True|
|city|**en**: city||string|True|
|country|**en**: country|**en**: The country, e.g., USA, Sweden, Argentina, or optionally a two-letter ISO 3166-1 alpha-2 country code, e.g., "SE", "US", etc.|string|True|
|postalCode|**en**: postal code||string|True|
|region|**en**: region||string|True|
### Inherited Properties
* **[Information](Information.md):** customTags, externalIds, name

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
* [EquipmentCollection](../Collection/Equipment-.md).feeds
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [Architecture](../Space/Architecture/Architecture.md).address
