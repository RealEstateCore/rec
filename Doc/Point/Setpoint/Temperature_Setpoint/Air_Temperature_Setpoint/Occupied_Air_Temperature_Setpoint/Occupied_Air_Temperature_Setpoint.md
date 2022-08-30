[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Occupied_Air_Temperature_Setpoint](#)
# Occupied_Air_Temperature_Setpoint

**Display name:** Occupied Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Occupied_Air_Temperature_Setpoint;1

---

## Child interfaces
* [Occupied_Discharge_Air_Temperature_Setpoint](Occupied_Discharge_Air_Temperature_Setpoint.md)
* [Occupied_Air_Temperature_Cooling_Setpoint](Occupied_Air_Temperature_Cooling_Setpoint.md)
* [Occupied_Air_Temperature_Heating_Setpoint](Occupied_Air_Temperature_Heating_Setpoint.md)
* [Occupied_Return_Air_Temperature_Setpoint](../Return_Air_Temperature_Setpoint/Occupied_Return_Air_Temperature_Setpoint.md)
* [Occupied_Room_Air_Temperature_Setpoint](../Room_Air_Temperature_Setpoint/Occupied_Room_Air_Temperature_Setpoint.md)
* [Occupied_Supply_Air_Temperature_Setpoint](../Supply_Air_Temperature_Setpoint/Occupied_Supply_Air_Temperature_Setpoint.md)
* [Occupied_Zone_Air_Temperature_Setpoint](../Zone_Air_Temperature_Setpoint/Occupied_Zone_Air_Temperature_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

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
