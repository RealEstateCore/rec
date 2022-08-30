[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Effective_Air_Temperature_Setpoint](#)
# Effective_Air_Temperature_Setpoint

**Display name:** Effective Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Effective_Air_Temperature_Setpoint;1

---

## Child interfaces
* [Effective_Discharge_Air_Temperature_Setpoint](Effective_Discharge_Air_Temperature_Setpoint.md)
* [Effective_Air_Temperature_Cooling_Setpoint](Effective_Air_Temperature_Cooling_Setpoint.md)
* [Effective_Air_Temperature_Heating_Setpoint](Effective_Air_Temperature_Heating_Setpoint.md)
* [Effective_Return_Air_Temperature_Setpoint](../Return_Air_Temperature_Setpoint/Effective_Return_Air_Temperature_Setpoint.md)
* [Effective_Room_Air_Temperature_Setpoint](../Room_Air_Temperature_Setpoint/Effective_Room_Air_Temperature_Setpoint.md)
* [Effective_Supply_Air_Temperature_Setpoint](../Supply_Air_Temperature_Setpoint/Effective_Supply_Air_Temperature_Setpoint.md)
* [Effective_Zone_Air_Temperature_Setpoint](../Zone_Air_Temperature_Setpoint/Effective_Zone_Air_Temperature_Setpoint.md)

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
