[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Temperature_Setpoint](../Temperature_Setpoint.md) > [Temperature_Deadband_Setpoint](#)
# Temperature_Deadband_Setpoint

**Display name:** Temperature Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_Deadband_Setpoint;1

---

## Child interfaces
* [Occupied_Cooling_Temperature_Deadband_Setpoint](Occupied_Cooling_Temperature_Deadband_Setpoint.md)
* [Unoccupied_Cooling_Temperature_Deadband_Setpoint](Unoccupied_Cooling_Temperature_Deadband_Setpoint.md)
* [Occupied_Heating_Temperature_Deadband_Setpoint](Occupied_Heating_Temperature_Deadband_Setpoint.md)
* [Unoccupied_Heating_Temperature_Deadband_Setpoint](Unoccupied_Heating_Temperature_Deadband_Setpoint.md)
* [Supply_Air_Temperature_Deadband_Setpoint](Supply_Air_Temperature_Deadband_Setpoint/Supply_Air_Temperature_Deadband_Setpoint.md)
* [Entering_Water_Temperature_Deadband_Setpoint](../Water_Temperature_Setpoint/Entering_Water_Temperature_Setpoint/Entering_Water_Temperature_Deadband_Setpoint.md)
* [Leaving_Water_Temperature_Deadband_Setpoint](../Water_Temperature_Setpoint/Leaving_Water_Temperature_Setpoint/Leaving_Water_Temperature_Deadband_Setpoint.md)
* [Discharge_Air_Temperature_Deadband_Setpoint](../Air_Temperature_Setpoint/Discharge_Air_Temperature_Setpoint/Discharge_Air_Temperature_Deadband_Setpoint/Discharge_Air_Temperature_Deadband_Setpoint.md)

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
