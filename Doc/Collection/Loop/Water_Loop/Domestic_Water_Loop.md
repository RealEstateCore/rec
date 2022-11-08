[Index](../../../index.md) > [Collection](../../Collection.md) > [Loop](../Loop.md) > [Water_Loop](Water_Loop.md) > [Domestic_Water_Loop](#)
# Domestic_Water_Loop

**Display name:** Domestic Water Loop<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Domestic_Water_Loop;1

---

## Relationships

### Inherited Relationships
* **[Loop](../Loop.md):** includes
* **[Collection](../../Collection.md):** documentation

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Collection](../../Collection.md):** customTags, externalIds, name

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Space](../../../Space/Space.md).isLocationOf
* [Agent](../../../Agent/Agent.md).owns
* [EquipmentCollection](../../EquipmentCollection.md).feeds
* [Portfolio](../../Portfolio.md).includes
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
