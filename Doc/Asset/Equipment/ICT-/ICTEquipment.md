[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [ICTEquipment](#)
# ICTEquipment

Equipment and devices that are part of a building's ICT infrastructure.


**Display name:** ICT Equipment<br />
**DTMI:** dtmi:org:w3id:rec:ICTEquipment;1

---

## Child interfaces
* [AudioVisualEquipment](AudioVisualEquipment.md)
* [Controller](Controller.md)
* [DataNetworkEquipment](DataNetworkEquipment/DataNetworkEquipment.md)
* [Gateway](Gateway.md)
* [ICTHardware](ICTHardware/ICTHardware.md)
* [ITRack](ITRack.md)
* [SensorEquipment](SensorEquipment/SensorEquipment.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, geometry, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|heightRUs|**en**: Height (RUs)||integer|True|
|numberOfPorts|**en**: Number of Ports||integer|True|
|standard|**en**: Standard|**en**: The standard the equipment or device adheres to, e.g. IEEE 802.11.|string|True|
### Inherited Properties
* **[Equipment](../Equipment.md):** operationalStageCount
* **[Asset](../../Asset.md):** assetTag, commissioningDate, customProperties, customTags, identifiers, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../Equipment.md).feeds
* [Equipment](../Equipment.md).isFedBy
* [System](../../../Collection/System/System.md).includes
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
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [EquipmentCollection](../../../Collection/Equipment-.md).includes
