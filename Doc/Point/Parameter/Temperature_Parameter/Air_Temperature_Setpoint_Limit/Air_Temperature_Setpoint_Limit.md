[Index](../../../../index.md) > [Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Temperature_Parameter](../Temperature_Parameter.md) > [Air_Temperature_Setpoint_Limit](#)
# Air_Temperature_Setpoint_Limit

A parameter that places a lower or upper bound on the range of permitted values of a Air_Temperature_Setpoint.


**Display name:** Air Temperature Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Temperature_Setpoint_Limit;1

---

## Child interfaces
* [Supply_Air_Temperature_Setpoint_Limit](Supply_Air_Temperature_Setpoint_Limit/Supply_Air_Temperature_Setpoint_Limit.md)
* [Discharge_Air_Temperature_Setpoint_Limit](Discharge_Air_Temperature_Setpoint_Limit/Discharge_Air_Temperature_Setpoint_Limit.md)

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
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
