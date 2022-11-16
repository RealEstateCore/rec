[Index](../../../index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Temperature_Parameter](#)
# Temperature_Parameter

Parameters relevant to temperature-related systems and points


**Display name:** Temperature Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_Parameter;1

---

## Child interfaces
* [Air_Temperature_Integral_Time_Parameter](../PID-/Time_Parameter/Integral-/Air_Temperature-/Air_Temperature_Integral_Time_Parameter.md)
* [Air_Temperature_Setpoint_Limit](Air_Temperature_Setpoint_Limit/Air_Temperature_Setpoint_Limit.md)
* [Discharge_Air_Temperature_Proportional_Band_Parameter](../PID-/Proportional_Band_Parameter/Discharge_Air_Temperature-/Discharge_Air_Temperature_Proportional_Band_Parameter.md)
* [Entering_Water_Temperature_Integral_Time_Parameter](../PID-/Time_Parameter/Integral-/Entering_Water_Temperature-.md)
* [Entering_Water_Temperature_Proportional_Band_Parameter](../PID-/Proportional_Band_Parameter/Entering_Water_Temperature-.md)
* [High_Temperature_Alarm_Parameter](High_Temperature_Alarm_Parameter.md)
* [Leaving_Water_Temperature_Integral_Time_Parameter](../PID-/Time_Parameter/Integral-/Leaving_Water_Temperature-.md)
* [Leaving_Water_Temperature_Proportional_Band_Parameter](../PID-/Proportional_Band_Parameter/Leaving_Water_Temperature-.md)
* [Lockout_Temperature_Differential_Parameter](Lockout_Temperature_Differential_Parameter/Lockout_Temperature_Differential_Parameter.md)
* [Low_Freeze_Protect_Temperature_Parameter](Low_Freeze_Protect-.md)
* [Low_Temperature_Alarm_Parameter](Low_Temperature_Alarm_Parameter.md)
* [Max_Temperature_Setpoint_Limit](../Limit/Max-/Max_Temperature_Setpoint_Limit/Max_Temperature_Setpoint_Limit.md)
* [Min_Temperature_Setpoint_Limit](../Limit/Min-/Min_Temperature_Setpoint_Limit/Min_Temperature_Setpoint_Limit.md)
* [Supply_Air_Temperature_Proportional_Band_Parameter](../PID-/Proportional_Band_Parameter/Supply_Air_Temperature-/Supply_Air_Temperature_Proportional_Band_Parameter.md)
* [Temperature_Step_Parameter](../PID-/Step_Parameter/Temperature-/Temperature_Step_Parameter.md)
* [Temperature_Tolerance_Parameter](../Tolerance-/Temperature-.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../Parameter.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### General
* [Point](../../Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../Collection/Equipment-.md).feeds
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
