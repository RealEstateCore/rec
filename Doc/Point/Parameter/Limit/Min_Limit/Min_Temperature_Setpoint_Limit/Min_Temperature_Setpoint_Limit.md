[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Limit](../../Limit.md) > [Min_Limit](../Min_Limit.md) > [Min_Temperature_Setpoint_Limit](#)
# Min_Temperature_Setpoint_Limit

A parameter that places a lower bound on the range of permitted values of a Temperature_Setpoint.


**Display name:** Min Temperature Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Min_Temperature_Setpoint_Limit;1

---

## Child interfaces
* [Min_Discharge_Air_Temperature_Setpoint_Limit](Min_Discharge_Air_Temperature_Setpoint_Limit.md)
* [Min_Supply_Air_Temperature_Setpoint_Limit](../../../Temperature_Parameter/Air_Temperature_Setpoint_Limit/Supply_Air_Temperature_Setpoint_Limit/Min_Supply_Air_Temperature_Setpoint_Limit.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../../../Parameter.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

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
