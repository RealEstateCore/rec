[Index](../../index.md) > [Information](../Information.md) > [Document](Document.md) > [LeaseContract](#)
# LeaseContract

Formal document that identifies the Tenant and the leased asset or property; states lease term and fee (rent), and detailed terms and conditions of the lease agreement.


**Display name:** Lease contract<br />
**DTMI:** dtmi:org:w3id:rec:LeaseContract;1

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|regulates|**en**: regulates|**en**: Indicates the lease(s) that this contract regulates the conditions of.|0-Infinity|[Lease](../../Event/Lease.md)||True|
### Inherited Relationships
* **[Document](Document.md):** documentTopic, url

---

## Properties

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
* [Document](Document.md).documentTopic
* [Document](Document.md).url
* [EquipmentCollection](../../Collection/Equipment-.md).feeds
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [Lease](../../Event/Lease.md).regulatedBy
### Inherited
* [Architecture](../../Space/Architecture/Architecture.md).documentation
* [Asset](../../Asset/Asset.md).documentation
* [BuildingElement](../../BuildingElement/BuildingElement.md).documentation
* [Collection](../../Collection/Collection.md).documentation
