[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Differential_Setpoint](../Differential_Setpoint.md) > [Differential_Pressure_Setpoint](#)
# Differential_Pressure_Setpoint

**Display name:** Differential Pressure Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Pressure_Setpoint;1

---

## Child interfaces
* [Air_Differential_Pressure_Setpoint](Air_Differential_Pressure_Setpoint/Air_Differential_Pressure_Setpoint.md)
* [Load_Shed_Differential_Pressure_Setpoint](../../Load_Setpoint/Load_Shed_Setpoint/Load_Shed_Differential_Pressure_Setpoint/Load_Shed_Differential_Pressure_Setpoint.md)
* [Water_Differential_Pressure_Setpoint](Water_Differential_Pressure_Setpoint/Water_Differential_Pressure_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

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
