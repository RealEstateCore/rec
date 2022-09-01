[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Flow_Setpoint](../Flow_Setpoint.md) > [Air_Flow_Setpoint](#)
# Air_Flow_Setpoint

**Display name:** Air Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Flow_Setpoint;1

---

## Child interfaces
* [Outside_Air_Flow_Setpoint](Outside_Air_Flow_Setpoint.md)
* [Air_Flow_Deadband_Setpoint](Air_Flow_Deadband_Setpoint/Air_Flow_Deadband_Setpoint.md)
* [Air_Flow_Demand_Setpoint](Air_Flow_Demand_Setpoint/Air_Flow_Demand_Setpoint.md)
* [Discharge_Air_Flow_Setpoint](Discharge_Air_Flow_Setpoint/Discharge_Air_Flow_Setpoint.md)
* [Exhaust_Air_Flow_Setpoint](Exhaust_Air_Flow_Setpoint/Exhaust_Air_Flow_Setpoint.md)
* [Supply_Air_Flow_Setpoint](Supply_Air_Flow_Setpoint/Supply_Air_Flow_Setpoint.md)

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
