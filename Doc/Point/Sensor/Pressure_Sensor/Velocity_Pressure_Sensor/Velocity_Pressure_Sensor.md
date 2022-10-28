[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Pressure_Sensor](../Pressure_Sensor.md) > [Velocity_Pressure_Sensor](#)
# Velocity_Pressure_Sensor

**Display name:** Velocity Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Velocity_Pressure_Sensor;1

---

## Child interfaces
* [Discharge_Air_Velocity_Pressure_Sensor](Discharge_Air_Velocity_Pressure_Sensor.md)
* [Exhaust_Air_Velocity_Pressure_Sensor](Exhaust_Air_Velocity_Pressure_Sensor.md)
* [Supply_Air_Velocity_Pressure_Sensor](Supply_Air_Velocity_Pressure_Sensor.md)

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
