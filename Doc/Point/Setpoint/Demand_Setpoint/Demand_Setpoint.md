[Index](../../../index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Demand_Setpoint](#)
# Demand_Setpoint

**Display name:** Demand Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Demand_Setpoint;1

---

## Child interfaces
* [Cooling_Demand_Setpoint](Cooling_Demand_Setpoint.md)
* [Heating_Demand_Setpoint](Heating_Demand_Setpoint.md)
* [Preheat_Demand_Setpoint](Preheat_Demand_Setpoint.md)
* [Air_Flow_Demand_Setpoint](../Flow_Setpoint/Air_Flow_Setpoint/Air_Flow_Demand_Setpoint/Air_Flow_Demand_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../Setpoint.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
