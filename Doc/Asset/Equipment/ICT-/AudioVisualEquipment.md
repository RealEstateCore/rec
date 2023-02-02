[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [ICTEquipment](ICTEquipment.md) > [AudioVisualEquipment](#)
# AudioVisualEquipment

Audio visual equipment.


**Display name:** Audio Visual Equipment<br />
**DTMI:** dtmi:org:w3id:rec:AudioVisualEquipment;1

---

## Relationships

### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, geometry, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Equipment](../Equipment.md):** operationalStageCount
* **[Asset](../../Asset.md):** assetTag, commissioningDate, customProperties, customTags, identifiers, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
* **[ICTEquipment](ICTEquipment.md):** heightRUs, numberOfPorts, standard

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../Equipment.md).feeds
* [Equipment](../Equipment.md).isFedBy
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Meter/Meter.md).meters
### Inherited
* [Loop](../../../Collection/Loop/Loop.md).includes
* [System](../../../Collection/System/System.md).includes
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [EquipmentCollection](../../../Collection/Equipment-.md).includes
