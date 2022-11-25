[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Parameter](../../../../Parameter.md) > [Limit](../../../Limit.md) > [Max_Limit](../../Max_Limit.md) > [Max_Air_Flow_Setpoint_Limit](../Max_Air_Flow_Setpoint_Limit.md) > [Max_Heating_Supply_Air_Flow_Setpoint_Limit](#)
# Max_Heating_Supply_Air_Flow_Setpoint_Limit

A parameter that places an upper bound on the range of permitted values of a Heating_Supply_Air_Flow_Setpoint.


**Display name:** Max Heating Supply Air Flow Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Max_Heating_Supply_Air_Flow_Setpoint_Limit;1

---

## Child interfaces
* [Max_Occupied_Heating_Supply_Air_Flow_Setpoint_Limit](Max_Occupied_Heating_Supply_Air_Flow_Setpoint_Limit.md)
* [Max_Unoccupied_Heating_Supply_Air_Flow_Setpoint_Limit](Max_Unoccupied_Heating_Supply_Air_Flow_Setpoint_Limit.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../../../../Parameter.md):** lastKnownValue
* **[Point](../../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../../Space/Architecture/Architecture.md).hasPoint