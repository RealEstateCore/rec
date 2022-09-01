[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Air_Temperature_Sensor](../Air_Temperature_Sensor.md) > [Outside_Air_Temperature_Sensor](#)
# Outside_Air_Temperature_Sensor

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
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
