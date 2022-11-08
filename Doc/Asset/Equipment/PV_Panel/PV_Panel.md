[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [PV_Panel](#)
# PV_Panel

An integrated assembly of interconnected photovoltaic cells designed to deliver a selected level of working voltage and current at its output terminals packaged for protection against environment degradation and suited for incorporation in photovoltaic power systems.


**Display name:** PV Panel<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:PV_Panel;1

---

## Child interfaces
* [PVT_Panel](../Solar_Thermal_Collector/PVT_Panel.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|measuredModuleConversionEfficiency|**en**: Measured module conversion efficiency||Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
|ratedModuleConversionEfficiency|**en**: Rated module conversion efficiency||Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
### Inherited Properties
* **[Equipment](../Equipment.md):** operationalStageCount
* **[Asset](../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Space](../../../Space/Space.md).isLocationOf
* [Agent](../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../Collection/Portfolio.md).includes
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../Equipment.md).feeds
* [Equipment](../Equipment.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../Meter/Meter.md).meters
### Direct
* [PV_Array](../../../Collection/PV_Array.md).includes
### Inherited
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../Collection/Loop/Loop.md).includes
* [System](../../../Collection/System/System.md).includes
