[Index](../../../index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Temperature_Parameter](#)
# Temperature_Parameter

**Display name:** Temperature Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_Parameter;1

---

## Child interfaces
* [High_Temperature_Alarm_Parameter](High_Temperature_Alarm_Parameter.md)
* [Low_Freeze_Protect_Temperature_Parameter](Low_Freeze_Protect_Temperature_Parameter.md)
* [Low_Temperature_Alarm_Parameter](Low_Temperature_Alarm_Parameter.md)
* [Temperature_Tolerance_Parameter](../Tolerance_Parameter/Temperature_Tolerance_Parameter.md)
* [Air_Temperature_Setpoint_Limit](Air_Temperature_Setpoint_Limit/Air_Temperature_Setpoint_Limit.md)
* [Entering_Water_Temperature_Proportional_Band_Parameter](../PID_Parameter/Proportional_Band_Parameter/Entering_Water_Temperature_Proportional_Band_Parameter.md)
* [Leaving_Water_Temperature_Proportional_Band_Parameter](../PID_Parameter/Proportional_Band_Parameter/Leaving_Water_Temperature_Proportional_Band_Parameter.md)
* [Lockout_Temperature_Differential_Parameter](Lockout_Temperature_Differential_Parameter/Lockout_Temperature_Differential_Parameter.md)
* [Max_Temperature_Setpoint_Limit](../Limit/Max_Limit/Max_Temperature_Setpoint_Limit/Max_Temperature_Setpoint_Limit.md)
* [Min_Temperature_Setpoint_Limit](../Limit/Min_Limit/Min_Temperature_Setpoint_Limit/Min_Temperature_Setpoint_Limit.md)
* [Discharge_Air_Temperature_Proportional_Band_Parameter](../PID_Parameter/Proportional_Band_Parameter/Discharge_Air_Temperature_Proportional_Band_Parameter/Discharge_Air_Temperature_Proportional_Band_Parameter.md)
* [Supply_Air_Temperature_Proportional_Band_Parameter](../PID_Parameter/Proportional_Band_Parameter/Supply_Air_Temperature_Proportional_Band_Parameter/Supply_Air_Temperature_Proportional_Band_Parameter.md)
* [Temperature_Step_Parameter](../PID_Parameter/Step_Parameter/Temperature_Step_Parameter/Temperature_Step_Parameter.md)
* [Entering_Water_Temperature_Integral_Time_Parameter](../PID_Parameter/Time_Parameter/Integral_Time_Parameter/Entering_Water_Temperature_Integral_Time_Parameter.md)
* [Leaving_Water_Temperature_Integral_Time_Parameter](../PID_Parameter/Time_Parameter/Integral_Time_Parameter/Leaving_Water_Temperature_Integral_Time_Parameter.md)
* [Air_Temperature_Integral_Time_Parameter](../PID_Parameter/Time_Parameter/Integral_Time_Parameter/Air_Temperature_Integral_Time_Parameter/Air_Temperature_Integral_Time_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
