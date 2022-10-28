[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Reset_Setpoint](../Reset_Setpoint.md) > [Discharge_Air_Flow_Reset_Setpoint](#)
# Discharge_Air_Flow_Reset_Setpoint

Setpoints used in Reset strategies


**Display name:** Discharge Air Flow Reset Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Flow_Reset_Setpoint;1

---

## Child interfaces
* [Discharge_Air_Flow_High_Reset_Setpoint](Discharge_Air_Flow_High_Reset_Setpoint.md)
* [Discharge_Air_Flow_Low_Reset_Setpoint](Discharge_Air_Flow_Low_Reset_Setpoint.md)

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
