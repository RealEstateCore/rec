[Index](../../Index.md) > [Information](../Information.md) > [Document](Document.md) > [LeaseContract](#)
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
### Direct
* [Lease](../../Event/Lease.md).regulatedBy
### Inherited
* [Asset](../../Asset/Asset.md).documentation
* [BuildingElement](../../BuildingElement/BuildingElement.md).documentation
* [Collection](../../Collection/Collection.md).documentation
* [Architecture](../../Space/Architecture/Architecture.md).documentation
