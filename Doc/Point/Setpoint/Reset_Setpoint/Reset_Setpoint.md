[Index](../../../index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Reset_Setpoint](#)
# Reset_Setpoint

Setpoints used in reset strategies


**Display name:** Reset Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Reset_Setpoint;1

---

## Child interfaces
* [Discharge_Air_Flow_Reset_Setpoint](Discharge_Air_Flow_Reset_Setpoint/Discharge_Air_Flow_Reset_Setpoint.md)
* [Supply_Air_Flow_Reset_Setpoint](Supply_Air_Flow_Reset_Setpoint/Supply_Air_Flow_Reset_Setpoint.md)
* [Temperature_Low_Reset_Setpoint](Temperature_Low_Reset_Setpoint/Temperature_Low_Reset_Setpoint.md)
* [Temperature_High_Reset_Setpoint](Temperature_High_Reset_Setpoint/Temperature_High_Reset_Setpoint.md)

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
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
