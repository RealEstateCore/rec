[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Temperature_Sensor](../Temperature_Sensor.md) > [Air_Temperature_Sensor](#)
# Air_Temperature_Sensor

Measures the temperature of air


**Display name:** Air Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Temperature_Sensor;1

---

## Child interfaces
* [Exhaust_Air_Temperature_Sensor](Exhaust_Air_Temperature_Sensor.md)
* [Mixed_Air_Temperature_Sensor](Mixed_Air_Temperature_Sensor.md)
* [Return_Air_Temperature_Sensor](Return_Air_Temperature_Sensor.md)
* [Underfloor_Air_Temperature_Sensor](Underfloor_Air_Temperature_Sensor.md)
* [Air_Wet_Bulb_Temperature_Sensor](Air_Wet_Bulb_Temperature_Sensor/Air_Wet_Bulb_Temperature_Sensor.md)
* [Discharge_Air_Temperature_Sensor](Discharge_Air_Temperature_Sensor/Discharge_Air_Temperature_Sensor.md)
* [Outside_Air_Temperature_Sensor](Outside_Air_Temperature_Sensor/Outside_Air_Temperature_Sensor.md)
* [Supply_Air_Temperature_Sensor](Supply_Air_Temperature_Sensor/Supply_Air_Temperature_Sensor.md)
* [Zone_Air_Temperature_Sensor](Zone_Air_Temperature_Sensor/Zone_Air_Temperature_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Temperature_Sensor](../Temperature_Sensor.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
