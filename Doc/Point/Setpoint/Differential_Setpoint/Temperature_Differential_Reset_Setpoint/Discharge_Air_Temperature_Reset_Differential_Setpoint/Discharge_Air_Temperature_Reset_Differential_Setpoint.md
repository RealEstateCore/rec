[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Differential_Setpoint](../../Differential_Setpoint.md) > [Temperature_Differential_Reset_Setpoint](../Temperature_Differential_Reset_Setpoint.md) > [Discharge_Air_Temperature_Reset_Differential_Setpoint](#)
# Discharge_Air_Temperature_Reset_Differential_Setpoint

**Display name:** Discharge Air Temperature Reset Differential Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Reset_Differential_Setpoint;1

---

## Child interfaces
* [Discharge_Air_Temperature_High_Reset_Setpoint](Discharge_Air_Temperature_High_Reset_Setpoint.md)
* [Discharge_Air_Temperature_Low_Reset_Setpoint](Discharge_Air_Temperature_Low_Reset_Setpoint.md)

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
