[Index](../../../../../index.md) > [Asset](../../../../Asset.md) > [Equipment](../../../Equipment.md) > [Water_Heater](../../Water_Heater.md) > [Boiler](../Boiler.md) > [Natural_Gas_Boiler](#)
# Natural_Gas_Boiler

A closed, pressure vessel that uses natural gas for heating water or other fluids to supply steam or hot water for heating, humidification, or other applications.


**Display name:** Natural Gas Boiler<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Natural_Gas_Boiler;1

---

## Child interfaces
* [Condensing_Natural_Gas_Boiler](Condensing_Natural_Gas_Boiler.md)
* [Noncondensing_Natural_Gas_Boiler](Noncondensing_Natural_Gas_Boiler.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../../../Equipment.md):** feeds, isFedBy
* **[Asset](../../../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Equipment](../../../Equipment.md):** operationalStageCount
* **[Asset](../../../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../../../../Point/Point.md).isPointOf
* [Space](../../../../../Space/Space.md).isLocationOf
* [Agent](../../../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../../../Collection/Portfolio.md).includes
* [Lease](../../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../Equipment.md).feeds
* [Equipment](../../../Equipment.md).isFedBy
* [Document](../../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../../Information/Document/Document.md).url
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../Meter/Meter.md).meters
### Inherited
* [Asset](../../../../Asset.md).hasPart
* [Asset](../../../../Asset.md).isPartOf
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../../../Collection/Loop/Loop.md).includes
* [System](../../../../../Collection/System/System.md).includes
