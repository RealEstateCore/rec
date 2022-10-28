[Index](../../../../index.md) > [Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Static_Pressure_Setpoint_Limit](#)
# Static_Pressure_Setpoint_Limit

A parameter that places a lower or upper bound on the range of permitted values of a Static_Pressure_Setpoint.


**Display name:** Static Pressure Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Static_Pressure_Setpoint_Limit;1

---

## Child interfaces
* [High_Static_Pressure_Cutout_Setpoint_Limit](High_Static_Pressure_Cutout_Setpoint_Limit.md)
* [Max_Static_Pressure_Setpoint_Limit](Max_Static_Pressure_Setpoint_Limit/Max_Static_Pressure_Setpoint_Limit.md)
* [Min_Static_Pressure_Setpoint_Limit](Min_Static_Pressure_Setpoint_Limit/Min_Static_Pressure_Setpoint_Limit.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../../Parameter.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

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
