[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Air_Temperature_Sensor](../Air_Temperature_Sensor.md) > [Outside_Air_Temperature_Sensor](#)
# Outside_Air_Temperature_Sensor

Measures the temperature of outside air


**Display name:** Outside Air Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Outside_Air_Temperature_Sensor;1

---

## Child interfaces
* [Outside_Air_Wet_Bulb_Temperature_Sensor](Outside_Air_Wet_Bulb_Temperature_Sensor.md)
* [Intake_Air_Temperature_Sensor](Intake_Air_Temperature_Sensor.md)
* [Outside_Air_Temperature_Enable_Differential_Sensor](Outside_Air_Temperature_Enable_Differential_Sensor/Outside_Air_Temperature_Enable_Differential_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Temperature_Sensor](../../Temperature_Sensor.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### General
* [Point](../../../../Point.md).isPointOf
* [Space](../../../../../Space/Space.md).isLocationOf
* [Agent](../../../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../../../Collection/Portfolio.md).includes
* [Lease](../../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../../Information/Document/Document.md).url
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
