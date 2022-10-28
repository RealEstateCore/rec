[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Flow_Setpoint](../../../Flow_Setpoint.md) > [Air_Flow_Setpoint](../../Air_Flow_Setpoint.md) > [Supply_Air_Flow_Setpoint](../Supply_Air_Flow_Setpoint.md) > [Cooling_Supply_Air_Flow_Setpoint](#)
# Cooling_Supply_Air_Flow_Setpoint

**Display name:** Cooling Supply Air Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Cooling_Supply_Air_Flow_Setpoint;1

---

## Child interfaces
* [Occupied_Cooling_Supply_Air_Flow_Setpoint](../Occupied_Supply_Air_Flow_Setpoint/Occupied_Cooling_Supply_Air_Flow_Setpoint.md)
* [Unoccupied_Cooling_Supply_Air_Flow_Setpoint](../Unoccupied_Supply_Air_Flow_Setpoint/Unoccupied_Cooling_Supply_Air_Flow_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../../../../Setpoint.md):** lastKnownValue
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
