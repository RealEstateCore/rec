[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Temperature_Setpoint](../Temperature_Setpoint.md) > [Heating_Temperature_Setpoint](#)
# Heating_Temperature_Setpoint

Sets temperature for heating


**Display name:** Heating Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heating_Temperature_Setpoint;1

---

## Child interfaces
* [Unoccupied_Heating_Temperature_Setpoint](Unoccupied_Heating_Temperature_Setpoint.md)
* [Occupied_Heating_Temperature_Setpoint](Occupied_Heating_Temperature_Setpoint.md)
* [Occupied_Heating_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Occupied_Heating_Temperature_Deadband_Setpoint.md)
* [Unoccupied_Heating_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Unoccupied_Heating_Temperature_Deadband_Setpoint.md)
* [Heating_Supply_Air_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Supply_Air_Temperature_Deadband_Setpoint/Heating_Supply_Air_Temperature_Deadband_Setpoint.md)
* [Unoccupied_Air_Temperature_Heating_Setpoint](../Air_Temperature_Setpoint/Unoccupied_Air_Temperature_Setpoint/Unoccupied_Air_Temperature_Heating_Setpoint.md)
* [Effective_Air_Temperature_Heating_Setpoint](../Air_Temperature_Setpoint/Effective_Air_Temperature_Setpoint/Effective_Air_Temperature_Heating_Setpoint.md)
* [Supply_Air_Temperature_Heating_Setpoint](../Air_Temperature_Setpoint/Supply_Air_Temperature_Setpoint/Supply_Air_Temperature_Heating_Setpoint.md)
* [Zone_Air_Heating_Temperature_Setpoint](../Air_Temperature_Setpoint/Zone_Air_Temperature_Setpoint/Zone_Air_Heating_Temperature_Setpoint.md)
* [Occupied_Air_Temperature_Heating_Setpoint](../Air_Temperature_Setpoint/Occupied_Air_Temperature_Setpoint/Occupied_Air_Temperature_Heating_Setpoint.md)
* [Open_Heating_Valve_Outside_Air_Temperature_Setpoint](../Air_Temperature_Setpoint/Outside_Air_Temperature_Setpoint/Open_Heating_Valve_Outside_Air_Temperature_Setpoint.md)
* [Discharge_Air_Temperature_Heating_Setpoint](../Air_Temperature_Setpoint/Discharge_Air_Temperature_Setpoint/Discharge_Air_Temperature_Heating_Setpoint/Discharge_Air_Temperature_Heating_Setpoint.md)

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
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
