[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Supply_Air_Temperature_Setpoint](#)
# Supply_Air_Temperature_Setpoint

**Display name:** Supply Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Temperature_Setpoint;1

---

## Child interfaces
* [Effective_Supply_Air_Temperature_Setpoint](Effective_Supply_Air_Temperature_Setpoint.md)
* [Occupied_Supply_Air_Temperature_Setpoint](Occupied_Supply_Air_Temperature_Setpoint.md)
* [Supply_Air_Temperature_Cooling_Setpoint](Supply_Air_Temperature_Cooling_Setpoint.md)
* [Supply_Air_Temperature_Heating_Setpoint](Supply_Air_Temperature_Heating_Setpoint.md)
* [Unoccupied_Supply_Air_Temperature_Setpoint](../Unoccupied_Air_Temperature_Setpoint/Unoccupied_Supply_Air_Temperature_Setpoint.md)

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
