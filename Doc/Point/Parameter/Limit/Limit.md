[Index](../../../index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Limit](#)
# Limit

**Display name:** Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Limit;1

---

## Child interfaces
* [Close_Limit](Close_Limit.md)
* [Current_Limit](Current_Limit.md)
* [Ventilation_Air_Flow_Ratio_Limit](Ventilation_Air_Flow_Ratio_Limit.md)
* [Air_Flow_Setpoint_Limit](Air_Flow_Setpoint_Limit/Air_Flow_Setpoint_Limit.md)
* [Air_Temperature_Setpoint_Limit](../Temperature_Parameter/Air_Temperature_Setpoint_Limit/Air_Temperature_Setpoint_Limit.md)
* [Differential_Pressure_Setpoint_Limit](Differential_Pressure_Setpoint_Limit/Differential_Pressure_Setpoint_Limit.md)
* [Fresh_Air_Setpoint_Limit](Fresh_Air_Setpoint_Limit/Fresh_Air_Setpoint_Limit.md)
* [Max_Limit](Max_Limit/Max_Limit.md)
* [Min_Limit](Min_Limit/Min_Limit.md)
* [Position_Limit](Position_Limit/Position_Limit.md)
* [Speed_Setpoint_Limit](Speed_Setpoint_Limit/Speed_Setpoint_Limit.md)
* [Static_Pressure_Setpoint_Limit](Static_Pressure_Setpoint_Limit/Static_Pressure_Setpoint_Limit.md)

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
