[Index](../../../../../../Index.md) > [Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Temperature_Setpoint](../../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../../Air_Temperature_Setpoint.md) > [Discharge_Air_Temperature_Setpoint](../Discharge_Air_Temperature_Setpoint.md) > [Discharge_Air_Temperature_Deadband_Setpoint](#)
# Discharge_Air_Temperature_Deadband_Setpoint

**Display name:** Discharge Air Temperature Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Deadband_Setpoint;1

---

## Child interfaces
* [Cooling_Discharge_Air_Temperature_Deadband_Setpoint](Cooling_Discharge_Air_Temperature_Deadband_Setpoint.md)
* [Heating_Discharge_Air_Temperature_Deadband_Setpoint](../Discharge_Air_Temperature_Heating_Setpoint/Heating_Discharge_Air_Temperature_Deadband_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../../Space/Architecture/Architecture.md).hasPoint
