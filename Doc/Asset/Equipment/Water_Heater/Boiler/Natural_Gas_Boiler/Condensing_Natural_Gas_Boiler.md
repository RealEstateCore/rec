[Index](../../../../../index.md) > [Asset](../../../../Asset.md) > [Equipment](../../../Equipment.md) > [Water_Heater](../../Water_Heater.md) > [Boiler](../Boiler.md) > [Natural_Gas_Boiler](Natural_Gas_Boiler.md) > [Condensing_Natural_Gas_Boiler](#)
# Condensing_Natural_Gas_Boiler

A closed, pressure vessel that uses natural gas and heat exchanger that capture and reuse any latent heat for heating water or other fluids to supply steam or hot water for heating, humidification, or other applications.


**Display name:** Condensing Natural Gas Boiler<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Condensing_Natural_Gas_Boiler;1

---

## Relationships

### Inherited Relationships
* **[Equipment](../../../Equipment.md):** feeds, isFedBy
* **[Asset](../../../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Equipment](../../../Equipment.md):** operationalStageCount
* **[Asset](../../../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### Inherited
* [Asset](../../../../Asset.md).hasPart
* [Asset](../../../../Asset.md).isPartOf
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../../../Collection/Loop/Loop.md).includes
* [System](../../../../../Collection/System/System.md).includes
