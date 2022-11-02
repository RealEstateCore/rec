[Index](../../../index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Deadband_Setpoint](#)
# Deadband_Setpoint

Sets the size of a deadband


**Display name:** Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Deadband_Setpoint;1

---

## Child interfaces
* [Humidity_Deadband_Setpoint](Humidity_Deadband_Setpoint.md)
* [Temperature_Deadband_Setpoint](../Temperature_Setpoint/Temperature_Deadband_Setpoint/Temperature_Deadband_Setpoint.md)
* [Air_Flow_Deadband_Setpoint](../Flow_Setpoint/Air_Flow_Setpoint/Air_Flow_Deadband_Setpoint/Air_Flow_Deadband_Setpoint.md)
* [Static_Pressure_Deadband_Setpoint](../Pressure_Setpoint/Static_Pressure_Setpoint/Static_Pressure_Deadband_Setpoint/Static_Pressure_Deadband_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../Setpoint.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
