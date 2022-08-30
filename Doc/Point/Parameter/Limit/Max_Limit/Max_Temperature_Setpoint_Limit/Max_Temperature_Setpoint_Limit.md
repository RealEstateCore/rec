[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Limit](../../Limit.md) > [Max_Limit](../Max_Limit.md) > [Max_Temperature_Setpoint_Limit](#)
# Max_Temperature_Setpoint_Limit

**Display name:** Max Temperature Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Max_Temperature_Setpoint_Limit;1

---

## Child interfaces
* [Max_Discharge_Air_Temperature_Setpoint_Limit](Max_Discharge_Air_Temperature_Setpoint_Limit.md)
* [Max_Supply_Air_Temperature_Setpoint_Limit](../../../Temperature_Parameter/Air_Temperature_Setpoint_Limit/Supply_Air_Temperature_Setpoint_Limit/Max_Supply_Air_Temperature_Setpoint_Limit.md)

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
