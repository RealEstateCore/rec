[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Discharge_Air_Temperature_Setpoint](#)
# Discharge_Air_Temperature_Setpoint

Sets temperature of discharge air


**Display name:** Discharge Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Setpoint;1

---

## Child interfaces
* [Effective_Discharge_Air_Temperature_Setpoint](../Effective_Air_Temperature_Setpoint/Effective_Discharge_Air_Temperature_Setpoint.md)
* [Unoccupied_Discharge_Air_Temperature_Setpoint](../Unoccupied_Air_Temperature_Setpoint/Unoccupied_Discharge_Air_Temperature_Setpoint.md)
* [Occupied_Discharge_Air_Temperature_Setpoint](../Occupied_Air_Temperature_Setpoint/Occupied_Discharge_Air_Temperature_Setpoint.md)
* [Discharge_Air_Temperature_Cooling_Setpoint](Discharge_Air_Temperature_Cooling_Setpoint/Discharge_Air_Temperature_Cooling_Setpoint.md)
* [Discharge_Air_Temperature_Deadband_Setpoint](Discharge_Air_Temperature_Deadband_Setpoint/Discharge_Air_Temperature_Deadband_Setpoint.md)
* [Discharge_Air_Temperature_Heating_Setpoint](Discharge_Air_Temperature_Heating_Setpoint/Discharge_Air_Temperature_Heating_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../../../Setpoint.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
