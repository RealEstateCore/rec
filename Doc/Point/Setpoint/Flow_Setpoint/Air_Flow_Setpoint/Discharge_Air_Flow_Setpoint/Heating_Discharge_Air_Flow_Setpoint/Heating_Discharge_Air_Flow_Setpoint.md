[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Flow_Setpoint](../../../Flow_Setpoint.md) > [Air_Flow_Setpoint](../../Air_Flow_Setpoint.md) > [Discharge_Air_Flow_Setpoint](../Discharge_Air_Flow_Setpoint.md) > [Heating_Discharge_Air_Flow_Setpoint](#)
# Heating_Discharge_Air_Flow_Setpoint

Sets discharge air flow for heating


**Display name:** Heating Discharge Air Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heating_Discharge_Air_Flow_Setpoint;1

---

## Child interfaces
* [Unoccupied_Heating_Discharge_Air_Flow_Setpoint](../Unoccupied_Discharge_Air_Flow_Setpoint/Unoccupied_Heating_Discharge_Air_Flow_Setpoint.md)
* [Occupied_Heating_Discharge_Air_Flow_Setpoint](../Occupied_Discharge_Air_Flow_Setpoint/Occupied_Heating_Discharge_Air_Flow_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../../../../Setpoint.md):** lastKnownValue
* **[Point](../../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
