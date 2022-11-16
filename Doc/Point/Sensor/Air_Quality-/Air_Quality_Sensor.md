[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Air_Quality_Sensor](#)
# Air_Quality_Sensor

A sensor which provides a measure of air quality


**Display name:** Air Quality Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Quality_Sensor;1

---

## Child interfaces
* [Ammonia_Sensor](Ammonia_Sensor.md)
* [CO_Sensor](CO_Sensor/CO_Sensor.md)
* [CO2_Sensor](CO2_Sensor/CO2_Sensor.md)
* [Formaldehyde_Level_Sensor](Formaldehyde_Level_Sensor.md)
* [Methane_Level_Sensor](Methane_Level_Sensor.md)
* [NO2_Level_Sensor](NO2_Level_Sensor.md)
* [Ozone_Level_Sensor](Ozone_Level_Sensor.md)
* [Particulate_Matter_Sensor](Particulate_Matter_Sensor/Particulate_Matter_Sensor.md)
* [Radioactivity_Concentration_Sensor](Radioactivity_Concentration_Sensor/Radioactivity_Concentration_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|lastKnownValue|**en**: last known value||Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
### Inherited Properties
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### General
* [Point](../../Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../Collection/Equipment-.md).feeds
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
