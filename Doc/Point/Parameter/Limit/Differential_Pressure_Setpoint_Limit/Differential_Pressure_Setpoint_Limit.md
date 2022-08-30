[Index](../../../../Index.md) > [Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Differential_Pressure_Setpoint_Limit](#)
# Differential_Pressure_Setpoint_Limit

**Display name:** Differential Pressure Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Pressure_Setpoint_Limit;1

---

## Child interfaces
* [Max_Chilled_Water_Differential_Pressure_Setpoint_Limit](../Max_Limit/Max_Chilled_Water_Differential_Pressure_Setpoint_Limit.md)
* [Max_Hot_Water_Differential_Pressure_Setpoint_Limit](../Max_Limit/Max_Hot_Water_Differential_Pressure_Setpoint_Limit.md)
* [Min_Chilled_Water_Differential_Pressure_Setpoint_Limit](../Min_Limit/Min_Chilled_Water_Differential_Pressure_Setpoint_Limit.md)
* [Min_Hot_Water_Differential_Pressure_Setpoint_Limit](../Min_Limit/Min_Hot_Water_Differential_Pressure_Setpoint_Limit.md)

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
