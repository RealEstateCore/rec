[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Outside_Air_Temperature_Setpoint](#)
# Outside_Air_Temperature_Setpoint

Sets temperature of outside air


**Display name:** Outside Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Outside_Air_Temperature_Setpoint;1

---

## Child interfaces
* [Enable_Hot_Water_System_Outside_Air_Temperature_Setpoint](Enable_Hot_Water_System_Outside_Air_Temperature_Setpoint.md)
* [Open_Heating_Valve_Outside_Air_Temperature_Setpoint](Open_Heating_Valve_Outside_Air_Temperature_Setpoint.md)
* [Outside_Air_Lockout_Temperature_Setpoint](Outside_Air_Lockout_Temperature_Setpoint.md)
* [Disable_Hot_Water_System_Outside_Air_Temperature_Setpoint](Disable_Hot_Water_System_Outside_Air_Temperature_Setpoint.md)
* [Low_Outside_Air_Temperature_Enable_Setpoint](Low_Outside_Air_Temperature_Enable_Setpoint.md)

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
