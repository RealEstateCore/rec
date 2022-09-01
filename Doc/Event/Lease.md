[Index](../index.md) > [Event](Event.md) > [Lease](#)
# Lease

**Display name:** Lease<br />
**DTMI:** dtmi:org:w3id:rec:Lease;1

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|leaseOf|**en**: lease of|**en**: The object (e.g., property, equipment, etc) that this a lease of.|0-Infinity|||True|
|leasee|**en**: leasee|**en**: The agent leasing some leasable object, i.e., the user of the asset.|0-Infinity|[Agent](../Agent/Agent.md)||True|
|leasor|**en**: leasor|**en**: The agent leasing out some leasable object, i.e., the owner of the asset.|0-Infinity|[Agent](../Agent/Agent.md)||True|
|regulatedBy|**en**: regulated by|**en**: Indicates the contract regulating the terms of the lease in question. |0-Infinity|[LeaseContract](../Information/Document/LeaseContract.md)||True|

---

## Properties

### Inherited Properties
* **[Event](Event.md):** customTags, end, externalIds, name, start, timestamp

---

## Target Of
### Direct
* [LeaseContract](../Information/Document/LeaseContract.md).regulates
