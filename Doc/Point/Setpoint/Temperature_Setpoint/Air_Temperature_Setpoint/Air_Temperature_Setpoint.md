[Index](../../../../Index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Temperature_Setpoint](../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](#)
# Air_Temperature_Setpoint

**Display name:** Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Temperature_Setpoint;1

---

## Child interfaces
* [Max_Air_Temperature_Setpoint](Max_Air_Temperature_Setpoint.md)
* [Min_Air_Temperature_Setpoint](Min_Air_Temperature_Setpoint.md)
* [Mixed_Air_Temperature_Setpoint](Mixed_Air_Temperature_Setpoint.md)
* [Discharge_Air_Temperature_Setpoint](Discharge_Air_Temperature_Setpoint/Discharge_Air_Temperature_Setpoint.md)
* [Effective_Air_Temperature_Setpoint](Effective_Air_Temperature_Setpoint/Effective_Air_Temperature_Setpoint.md)
* [Occupied_Air_Temperature_Setpoint](Occupied_Air_Temperature_Setpoint/Occupied_Air_Temperature_Setpoint.md)
* [Outside_Air_Temperature_Setpoint](Outside_Air_Temperature_Setpoint/Outside_Air_Temperature_Setpoint.md)
* [Return_Air_Temperature_Setpoint](Return_Air_Temperature_Setpoint/Return_Air_Temperature_Setpoint.md)
* [Room_Air_Temperature_Setpoint](Room_Air_Temperature_Setpoint/Room_Air_Temperature_Setpoint.md)
* [Supply_Air_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Supply_Air_Temperature_Deadband_Setpoint/Supply_Air_Temperature_Deadband_Setpoint.md)
* [Supply_Air_Temperature_Setpoint](Supply_Air_Temperature_Setpoint/Supply_Air_Temperature_Setpoint.md)
* [Unoccupied_Air_Temperature_Setpoint](Unoccupied_Air_Temperature_Setpoint/Unoccupied_Air_Temperature_Setpoint.md)
* [Zone_Air_Temperature_Setpoint](Zone_Air_Temperature_Setpoint/Zone_Air_Temperature_Setpoint.md)

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
