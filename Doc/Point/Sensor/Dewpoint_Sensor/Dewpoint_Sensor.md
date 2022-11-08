[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Dewpoint_Sensor](#)
# Dewpoint_Sensor

Senses the dewpoint temperature . Dew point is the temperature to which air must be cooled to become saturated with water vapor


**Display name:** Dewpoint Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Dewpoint_Sensor;1

---

## Child interfaces
* [Return_Air_Dewpoint_Sensor](Return_Air_Dewpoint_Sensor.md)
* [Supply_Air_Dewpoint_Sensor](Supply_Air_Dewpoint_Sensor.md)
* [Exhaust_Air_Dewpoint_Sensor](Exhaust_Air_Dewpoint_Sensor.md)
* [Zone_Air_Dewpoint_Sensor](Zone_Air_Dewpoint_Sensor.md)
* [Outside_Air_Dewpoint_Sensor](Outside_Air_Dewpoint_Sensor.md)
* [Discharge_Air_Dewpoint_Sensor](Discharge_Air_Dewpoint_Sensor.md)

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
