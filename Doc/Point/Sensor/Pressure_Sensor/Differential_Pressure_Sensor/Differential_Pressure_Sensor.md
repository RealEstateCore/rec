[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Pressure_Sensor](../Pressure_Sensor.md) > [Differential_Pressure_Sensor](#)
# Differential_Pressure_Sensor

**Display name:** Differential Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Pressure_Sensor;1

---

## Child interfaces
* [Chilled_Water_Differential_Pressure_Sensor](Chilled_Water_Differential_Pressure_Sensor.md)
* [Filter_Differential_Pressure_Sensor](Filter_Differential_Pressure_Sensor.md)
* [Air_Differential_Pressure_Sensor](Air_Differential_Pressure_Sensor/Air_Differential_Pressure_Sensor.md)
* [Hot_Water_Differential_Pressure_Sensor](Hot_Water_Differential_Pressure_Sensor/Hot_Water_Differential_Pressure_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Pressure_Sensor](../Pressure_Sensor.md):** lastKnownValue
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
