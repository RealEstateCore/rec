[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Humidity_Sensor](../Humidity_Sensor.md) > [Relative_Humidity_Sensor](#)
# Relative_Humidity_Sensor

Measures the present state of absolute humidity relative to a maximum humidity given the same temperature


**Display name:** Relative Humidity Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Relative_Humidity_Sensor;1

---

## Child interfaces
* [Supply_Air_Humidity_Sensor](Supply_Air_Humidity_Sensor.md)
* [Discharge_Air_Humidity_Sensor](Discharge_Air_Humidity_Sensor.md)
* [Mixed_Air_Humidity_Sensor](Mixed_Air_Humidity_Sensor.md)
* [Zone_Air_Humidity_Sensor](Zone_Air_Humidity_Sensor.md)
* [Return_Air_Humidity_Sensor](Return_Air_Humidity_Sensor.md)
* [Outside_Air_Humidity_Sensor](Outside_Air_Humidity_Sensor.md)
* [Exhaust_Air_Humidity_Sensor](Exhaust_Air_Humidity_Sensor.md)

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
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
