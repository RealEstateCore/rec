[Index](../../../Index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Reset_Setpoint](#)
# Reset_Setpoint

**Display name:** Reset Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Reset_Setpoint;1

---

## Child interfaces
* [Discharge_Air_Flow_Reset_Setpoint](Discharge_Air_Flow_Reset_Setpoint/Discharge_Air_Flow_Reset_Setpoint.md)
* [Supply_Air_Flow_Reset_Setpoint](Supply_Air_Flow_Reset_Setpoint/Supply_Air_Flow_Reset_Setpoint.md)
* [Temperature_High_Reset_Setpoint](Temperature_High_Reset_Setpoint/Temperature_High_Reset_Setpoint.md)
* [Temperature_Low_Reset_Setpoint](Temperature_Low_Reset_Setpoint/Temperature_Low_Reset_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

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
