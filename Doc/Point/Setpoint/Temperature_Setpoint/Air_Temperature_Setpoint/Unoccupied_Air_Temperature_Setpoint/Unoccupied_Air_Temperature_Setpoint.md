[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Unoccupied_Air_Temperature_Setpoint](#)
# Unoccupied_Air_Temperature_Setpoint

Sets temperature of air when unoccupied


**Display name:** Unoccupied Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Unoccupied_Air_Temperature_Setpoint;1

---

## Child interfaces
* [Unoccupied_Discharge_Air_Temperature_Setpoint](Unoccupied_Discharge_Air_Temperature_Setpoint.md)
* [Unoccupied_Return_Air_Temperature_Setpoint](Unoccupied_Return_Air_Temperature_Setpoint.md)
* [Unoccupied_Room_Air_Temperature_Setpoint](Unoccupied_Room_Air_Temperature_Setpoint.md)
* [Unoccupied_Supply_Air_Temperature_Setpoint](Unoccupied_Supply_Air_Temperature_Setpoint.md)
* [Unoccupied_Air_Temperature_Cooling_Setpoint](Unoccupied_Air_Temperature_Cooling_Setpoint.md)
* [Unoccupied_Air_Temperature_Heating_Setpoint](Unoccupied_Air_Temperature_Heating_Setpoint.md)
* [Unoccupied_Zone_Air_Temperature_Setpoint](../Zone_Air_Temperature_Setpoint/Unoccupied_Zone_Air_Temperature_Setpoint.md)

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
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
