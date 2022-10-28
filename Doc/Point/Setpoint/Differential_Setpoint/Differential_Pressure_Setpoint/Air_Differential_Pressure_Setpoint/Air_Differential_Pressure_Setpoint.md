[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Differential_Setpoint](../../Differential_Setpoint.md) > [Differential_Pressure_Setpoint](../Differential_Pressure_Setpoint.md) > [Air_Differential_Pressure_Setpoint](#)
# Air_Differential_Pressure_Setpoint

Sets the target air differential pressure between an upstream and downstream point in a air duct or conduit


**Display name:** Air Differential Pressure Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Differential_Pressure_Setpoint;1

---

## Child interfaces
* [Discharge_Air_Differential_Pressure_Setpoint](Discharge_Air_Differential_Pressure_Setpoint.md)
* [Exhaust_Air_Differential_Pressure_Setpoint](Exhaust_Air_Differential_Pressure_Setpoint.md)
* [Return_Air_Differential_Pressure_Setpoint](Return_Air_Differential_Pressure_Setpoint.md)
* [Supply_Air_Differential_Pressure_Setpoint](Supply_Air_Differential_Pressure_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../../../Setpoint.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

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
