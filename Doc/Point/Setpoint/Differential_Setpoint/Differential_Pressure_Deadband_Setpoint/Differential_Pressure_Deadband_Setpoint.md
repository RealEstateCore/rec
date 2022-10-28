[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Differential_Setpoint](../Differential_Setpoint.md) > [Differential_Pressure_Deadband_Setpoint](#)
# Differential_Pressure_Deadband_Setpoint

Sets the size of a deadband of differential pressure


**Display name:** Differential Pressure Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Pressure_Deadband_Setpoint;1

---

## Child interfaces
* [Chilled_Water_Differential_Pressure_Deadband_Setpoint](Chilled_Water_Differential_Pressure_Deadband_Setpoint.md)
* [Entering_Water_Differential_Pressure_Deadband_Setpoint](Entering_Water_Differential_Pressure_Deadband_Setpoint.md)
* [Hot_Water_Differential_Pressure_Deadband_Setpoint](Hot_Water_Differential_Pressure_Deadband_Setpoint.md)
* [Leaving_Water_Differential_Pressure_Deadband_Setpoint](Leaving_Water_Differential_Pressure_Deadband_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../../Setpoint.md):** lastKnownValue
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
