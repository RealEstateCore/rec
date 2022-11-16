[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Dewpoint_Sensor](#)
# Dewpoint_Sensor

Senses the dewpoint temperature . Dew point is the temperature to which air must be cooled to become saturated with water vapor


**Display name:** Dewpoint Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Dewpoint_Sensor;1

---

## Child interfaces
* [Discharge_Air_Dewpoint_Sensor](Discharge_Air-.md)
* [Exhaust_Air_Dewpoint_Sensor](Exhaust_Air-.md)
* [Outside_Air_Dewpoint_Sensor](Outside_Air-.md)
* [Return_Air_Dewpoint_Sensor](Return_Air-.md)
* [Supply_Air_Dewpoint_Sensor](Supply_Air-.md)
* [Zone_Air_Dewpoint_Sensor](Zone_Air-.md)

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
