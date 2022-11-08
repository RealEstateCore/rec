[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Electrical_Equipment](#)
# Electrical_Equipment

**Display name:** Electrical Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Electrical_Equipment;1

---

## Child interfaces
* [Motor_Control_Center](Motor_Control_Center.md)
* [PlugStrip](PlugStrip.md)
* [Switchgear](Switchgear.md)
* [Transformer](Transformer.md)
* [Bus_Riser](Bus_Riser.md)
* [Breaker_Panel](Breaker_Panel.md)
* [Inverter](Inverter.md)
* [Disconnect_Switch](Disconnect_Switch.md)
* [Energy_Storage](Energy_Storage/Energy_Storage.md)

---

## Relationships

### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

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
### Inherited
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../Collection/Loop/Loop.md).includes
* [System](../../../Collection/System/System.md).includes
