[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Limit](../../Limit.md) > [Min_Limit](../Min_Limit.md) > [Min_Air_Flow_Setpoint_Limit](#)
# Min_Air_Flow_Setpoint_Limit

**Display name:** Min Air Flow Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Min_Air_Flow_Setpoint_Limit;1

---

## Child interfaces
* [Min_Outside_Air_Flow_Setpoint_Limit](Min_Outside_Air_Flow_Setpoint_Limit.md)
* [Min_Cooling_Discharge_Air_Flow_Setpoint_Limit](Min_Cooling_Discharge_Air_Flow_Setpoint_Limit/Min_Cooling_Discharge_Air_Flow_Setpoint_Limit.md)
* [Min_Cooling_Supply_Air_Flow_Setpoint_Limit](Min_Cooling_Supply_Air_Flow_Setpoint_Limit/Min_Cooling_Supply_Air_Flow_Setpoint_Limit.md)
* [Min_Heating_Discharge_Air_Flow_Setpoint_Limit](Min_Heating_Discharge_Air_Flow_Setpoint_Limit/Min_Heating_Discharge_Air_Flow_Setpoint_Limit.md)
* [Min_Heating_Supply_Air_Flow_Setpoint_Limit](Min_Heating_Supply_Air_Flow_Setpoint_Limit/Min_Heating_Supply_Air_Flow_Setpoint_Limit.md)

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
