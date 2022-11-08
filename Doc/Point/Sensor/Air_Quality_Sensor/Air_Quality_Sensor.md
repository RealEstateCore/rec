[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Air_Quality_Sensor](#)
# Air_Quality_Sensor

A sensor which provides a measure of air quality


**Display name:** Air Quality Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Quality_Sensor;1

---

## Child interfaces
* [Ozone_Level_Sensor](Ozone_Level_Sensor.md)
* [NO2_Level_Sensor](NO2_Level_Sensor.md)
* [Ammonia_Sensor](Ammonia_Sensor.md)
* [Methane_Level_Sensor](Methane_Level_Sensor.md)
* [Formaldehyde_Level_Sensor](Formaldehyde_Level_Sensor.md)
* [Radioactivity_Concentration_Sensor](Radioactivity_Concentration_Sensor/Radioactivity_Concentration_Sensor.md)
* [CO_Sensor](CO_Sensor/CO_Sensor.md)
* [Particulate_Matter_Sensor](Particulate_Matter_Sensor/Particulate_Matter_Sensor.md)
* [CO2_Sensor](CO2_Sensor/CO2_Sensor.md)

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
* [Space](../../../Space/Space.md).isLocationOf
* [Agent](../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../Collection/Portfolio.md).includes
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
