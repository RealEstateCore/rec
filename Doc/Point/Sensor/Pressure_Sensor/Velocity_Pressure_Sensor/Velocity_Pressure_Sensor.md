[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Pressure_Sensor](../Pressure_Sensor.md) > [Velocity_Pressure_Sensor](#)
# Velocity_Pressure_Sensor

Measures the difference between total pressure and static pressure


**Display name:** Velocity Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Velocity_Pressure_Sensor;1

---

## Child interfaces
* [Supply_Air_Velocity_Pressure_Sensor](Supply_Air_Velocity_Pressure_Sensor.md)
* [Exhaust_Air_Velocity_Pressure_Sensor](Exhaust_Air_Velocity_Pressure_Sensor.md)
* [Discharge_Air_Velocity_Pressure_Sensor](Discharge_Air_Velocity_Pressure_Sensor.md)

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
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
