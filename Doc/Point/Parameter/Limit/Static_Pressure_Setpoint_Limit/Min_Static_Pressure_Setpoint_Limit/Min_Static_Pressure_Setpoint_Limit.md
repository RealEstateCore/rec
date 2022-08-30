[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Limit](../../Limit.md) > [Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit.md) > [Min_Static_Pressure_Setpoint_Limit](#)
# Min_Static_Pressure_Setpoint_Limit

**Display name:** Min Static Pressure Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Min_Static_Pressure_Setpoint_Limit;1

---

## Child interfaces
* [Min_Discharge_Air_Static_Pressure_Setpoint_Limit](Min_Discharge_Air_Static_Pressure_Setpoint_Limit.md)
* [Min_Supply_Air_Static_Pressure_Setpoint_Limit](Min_Supply_Air_Static_Pressure_Setpoint_Limit.md)

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
