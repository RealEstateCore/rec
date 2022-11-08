[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Temperature_Sensor](../Temperature_Sensor.md) > [Air_Temperature_Sensor](Air_Temperature_Sensor.md) > [Exhaust_Air_Temperature_Sensor](#)
# Exhaust_Air_Temperature_Sensor

Measures the temperature of exhaust air


**Display name:** Exhaust Air Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Exhaust_Air_Temperature_Sensor;1

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Temperature_Sensor](../Temperature_Sensor.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### General
* [Point](../../../Point.md).isPointOf
* [Space](../../../../Space/Space.md).isLocationOf
* [Agent](../../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
