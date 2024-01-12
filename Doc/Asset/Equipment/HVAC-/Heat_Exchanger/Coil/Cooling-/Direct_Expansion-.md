[Index](../../../../../../index.md) > [Asset](../../../../../Asset.md) > [Equipment](../../../../Equipment.md) > [HVAC_Equipment](../../../HVAC_Equipment.md) > [Heat_Exchanger](../../Heat_Exchanger.md) > [Coil](../Coil.md) > [Cooling_Coil](Cooling_Coil.md) > [Direct_Expansion_Cooling_Coil](#)
# Direct_Expansion_Cooling_Coil

**Display name:** Direct Expansion Cooling Coil<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Direct_Expansion_Cooling_Coil;1

---

## Relationships

### Inherited Relationships
* **[Equipment](../../../../Equipment.md):** feeds, isFedBy
* **[Asset](../../../../../Asset.md):** commissionedBy, documentation, geometry, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Equipment](../../../../Equipment.md):** operationalStageCount
* **[Asset](../../../../../Asset.md):** assetTag, commissioningDate, customProperties, customTags, identifiers, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### General
* [Point](../../../../../../Point/Point.md).isPointOf
* [Agent](../../../../../../Agent/Agent.md).owns
* [Space](../../../../../../Space/Space.md).isLocationOf
* [Equipment](../../../../Equipment.md).feeds
* [Equipment](../../../../Equipment.md).isFedBy
* [System](../../../../../../Collection/System/System.md).includes
* [Architecture](../../../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../../../Information/Document/Document.md).url
* [Lease](../../../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../../Meter/Meter.md).meters
### Inherited
* [Loop](../../../../../../Collection/Loop/Loop.md).includes
* [Asset](../../../../../Asset.md).hasPart
* [Asset](../../../../../Asset.md).isPartOf
* [EquipmentCollection](../../../../../../Collection/Equipment-.md).includes
