[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Temperature_Parameter](../../Temperature_Parameter.md) > [Air_Temperature_Setpoint_Limit](../Air_Temperature_Setpoint_Limit.md) > [Supply_Air_Temperature_Setpoint_Limit](#)
# Supply_Air_Temperature_Setpoint_Limit

**Display name:** Supply Air Temperature Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Temperature_Setpoint_Limit;1

---

## Child interfaces
* [Max_Supply_Air_Temperature_Setpoint_Limit](Max_Supply_Air_Temperature_Setpoint_Limit.md)
* [Min_Supply_Air_Temperature_Setpoint_Limit](Min_Supply_Air_Temperature_Setpoint_Limit.md)

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
