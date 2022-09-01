[Index](../../../../index.md) > [Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Max_Limit](#)
# Max_Limit

**Display name:** Max Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Max_Limit;1

---

## Child interfaces
* [Max_Chilled_Water_Differential_Pressure_Setpoint_Limit](Max_Chilled_Water_Differential_Pressure_Setpoint_Limit.md)
* [Max_Hot_Water_Differential_Pressure_Setpoint_Limit](Max_Hot_Water_Differential_Pressure_Setpoint_Limit.md)
* [Max_Fresh_Air_Setpoint_Limit](Max_Fresh_Air_Setpoint_Limit.md)
* [Max_Position_Setpoint_Limit](../Position_Limit/Max_Position_Setpoint_Limit.md)
* [Max_Speed_Setpoint_Limit](../Speed_Setpoint_Limit/Max_Speed_Setpoint_Limit.md)
* [Max_Air_Flow_Setpoint_Limit](Max_Air_Flow_Setpoint_Limit/Max_Air_Flow_Setpoint_Limit.md)
* [Max_Discharge_Air_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit/Max_Static_Pressure_Setpoint_Limit/Max_Discharge_Air_Static_Pressure_Setpoint_Limit.md)
* [Max_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit/Max_Static_Pressure_Setpoint_Limit/Max_Static_Pressure_Setpoint_Limit.md)
* [Max_Supply_Air_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit/Max_Static_Pressure_Setpoint_Limit/Max_Supply_Air_Static_Pressure_Setpoint_Limit.md)
* [Max_Temperature_Setpoint_Limit](Max_Temperature_Setpoint_Limit/Max_Temperature_Setpoint_Limit.md)

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
