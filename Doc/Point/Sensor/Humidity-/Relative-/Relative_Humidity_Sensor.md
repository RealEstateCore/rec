[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Humidity_Sensor](../Humidity_Sensor.md) > [Relative_Humidity_Sensor](#)
# Relative_Humidity_Sensor

Measures the present state of absolute humidity relative to a maximum humidity given the same temperature


**Display name:** Relative Humidity Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Relative_Humidity_Sensor;1

---

## Child interfaces
* [Discharge_Air_Humidity_Sensor](Discharge_Air_Humidity_Sensor.md)
* [Exhaust_Air_Humidity_Sensor](Exhaust_Air_Humidity_Sensor.md)
* [Mixed_Air_Humidity_Sensor](Mixed_Air_Humidity_Sensor.md)
* [Outside_Air_Humidity_Sensor](Outside_Air_Humidity_Sensor.md)
* [Return_Air_Humidity_Sensor](Return_Air_Humidity_Sensor.md)
* [Supply_Air_Humidity_Sensor](Supply_Air_Humidity_Sensor.md)
* [Zone_Air_Humidity_Sensor](Zone_Air_Humidity_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Humidity_Sensor](../Humidity_Sensor.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### General
* [Point](../../../Point.md).isPointOf
* [Agent](../../../../Agent/Agent.md).owns
* [Space](../../../../Space/Space.md).isLocationOf
* [Equipment](../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../../Collection/Equipment-.md).feeds
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/Point-/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
