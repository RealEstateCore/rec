[Index](../../../../../../Index.md) > [Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Flow_Setpoint](../../../Flow_Setpoint.md) > [Air_Flow_Setpoint](../../Air_Flow_Setpoint.md) > [Discharge_Air_Flow_Setpoint](../Discharge_Air_Flow_Setpoint.md) > [Unoccupied_Discharge_Air_Flow_Setpoint](#)
# Unoccupied_Discharge_Air_Flow_Setpoint

**Display name:** Unoccupied Discharge Air Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Unoccupied_Discharge_Air_Flow_Setpoint;1

---

## Child interfaces
* [Unoccupied_Cooling_Discharge_Air_Flow_Setpoint](Unoccupied_Cooling_Discharge_Air_Flow_Setpoint.md)
* [Unoccupied_Heating_Discharge_Air_Flow_Setpoint](Unoccupied_Heating_Discharge_Air_Flow_Setpoint.md)

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
