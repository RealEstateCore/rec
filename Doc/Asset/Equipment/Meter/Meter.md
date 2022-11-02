[Index](../../../index.md) > [Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Meter](#)
# Meter

A device that measure usage or consumption of some media --- typically a form energy or power.


**Display name:** Meter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Meter;1

---

## Child interfaces
* [Thermal_Power_Meter](Thermal_Power_Meter.md)
* [Electrical_Meter](Electrical_Meter/Electrical_Meter.md)
* [Water_Meter](Water_Meter/Water_Meter.md)
* [Gas_Meter](Gas_Meter/Gas_Meter.md)
* [Building_Meter](Building_Meter/Building_Meter.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|hasSubMeter|**en**: has sub-meter||0-Infinity|[Meter](#)||True|
|isSubMeterOf|**en**: is sub-meter of||0-Infinity|[Meter](#)||True|
|meters|**en**: meters||0-Infinity|||True|
### Inherited Relationships
* **[Equipment](../Equipment.md):** feeds, isFedBy
* **[Asset](../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|isVirtualMeter|**en**: is virtual meter||boolean|True|
### Inherited Properties
* **[Equipment](../Equipment.md):** operationalStageCount
* **[Asset](../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### Direct
* [Meter](#).hasSubMeter
* [Meter](#).isSubMeterOf
### Inherited
* [Asset](../../Asset.md).hasPart
* [Asset](../../Asset.md).isPartOf
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../Collection/Loop/Loop.md).includes
* [System](../../../Collection/System/System.md).includes
