[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Pressure_Setpoint](../../Pressure_Setpoint.md) > [Static_Pressure_Setpoint](../Static_Pressure_Setpoint.md) > [Static_Pressure_Deadband_Setpoint](#)
# Static_Pressure_Deadband_Setpoint

**Display name:** Static Pressure Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Static_Pressure_Deadband_Setpoint;1

---

## Child interfaces
* [Discharge_Air_Static_Pressure_Deadband_Setpoint](Discharge_Air_Static_Pressure_Deadband_Setpoint.md)
* [Supply_Air_Static_Pressure_Deadband_Setpoint](../Supply_Air_Static_Pressure_Setpoint/Supply_Air_Static_Pressure_Deadband_Setpoint.md)

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
