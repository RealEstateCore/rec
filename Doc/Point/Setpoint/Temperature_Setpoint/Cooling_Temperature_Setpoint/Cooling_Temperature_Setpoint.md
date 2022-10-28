[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Temperature_Setpoint](../Temperature_Setpoint.md) > [Cooling_Temperature_Setpoint](#)
# Cooling_Temperature_Setpoint

Sets temperature for cooling


**Display name:** Cooling Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Cooling_Temperature_Setpoint;1

---

## Child interfaces
* [Occupied_Cooling_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Occupied_Cooling_Temperature_Deadband_Setpoint.md)
* [Occupied_Cooling_Temperature_Setpoint](Occupied_Cooling_Temperature_Setpoint.md)
* [Unoccupied_Cooling_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Unoccupied_Cooling_Temperature_Deadband_Setpoint.md)
* [Unoccupied_Cooling_Temperature_Setpoint](Unoccupied_Cooling_Temperature_Setpoint.md)
* [Effective_Air_Temperature_Cooling_Setpoint](../Air_Temperature_Setpoint/Effective_Air_Temperature_Setpoint/Effective_Air_Temperature_Cooling_Setpoint.md)
* [Occupied_Air_Temperature_Cooling_Setpoint](../Air_Temperature_Setpoint/Occupied_Air_Temperature_Setpoint/Occupied_Air_Temperature_Cooling_Setpoint.md)
* [Cooling_Supply_Air_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Supply_Air_Temperature_Deadband_Setpoint/Cooling_Supply_Air_Temperature_Deadband_Setpoint.md)
* [Supply_Air_Temperature_Cooling_Setpoint](../Air_Temperature_Setpoint/Supply_Air_Temperature_Setpoint/Supply_Air_Temperature_Cooling_Setpoint.md)
* [Unoccupied_Air_Temperature_Cooling_Setpoint](../Air_Temperature_Setpoint/Unoccupied_Air_Temperature_Setpoint/Unoccupied_Air_Temperature_Cooling_Setpoint.md)
* [Zone_Air_Cooling_Temperature_Setpoint](../Air_Temperature_Setpoint/Zone_Air_Temperature_Setpoint/Zone_Air_Cooling_Temperature_Setpoint.md)
* [Discharge_Air_Temperature_Cooling_Setpoint](../Air_Temperature_Setpoint/Discharge_Air_Temperature_Setpoint/Discharge_Air_Temperature_Cooling_Setpoint/Discharge_Air_Temperature_Cooling_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../../Setpoint.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

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
