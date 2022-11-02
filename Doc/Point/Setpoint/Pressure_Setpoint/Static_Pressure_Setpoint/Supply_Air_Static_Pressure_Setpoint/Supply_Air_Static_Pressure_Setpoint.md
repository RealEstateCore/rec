[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Pressure_Setpoint](../../Pressure_Setpoint.md) > [Static_Pressure_Setpoint](../Static_Pressure_Setpoint.md) > [Supply_Air_Static_Pressure_Setpoint](#)
# Supply_Air_Static_Pressure_Setpoint

Sets static pressure of supply air


**Display name:** Supply Air Static Pressure Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Static_Pressure_Setpoint;1

---

## Child interfaces
* [Supply_Air_Static_Pressure_Deadband_Setpoint](Supply_Air_Static_Pressure_Deadband_Setpoint.md)

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
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
