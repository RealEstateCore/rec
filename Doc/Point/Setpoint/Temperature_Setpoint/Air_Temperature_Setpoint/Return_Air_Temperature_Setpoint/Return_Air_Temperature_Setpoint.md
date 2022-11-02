[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Return_Air_Temperature_Setpoint](#)
# Return_Air_Temperature_Setpoint

The target temperature for return air, often used as an approximation of zone air temperature


**Display name:** Return Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Return_Air_Temperature_Setpoint;1

---

## Child interfaces
* [Effective_Return_Air_Temperature_Setpoint](Effective_Return_Air_Temperature_Setpoint.md)
* [Unoccupied_Return_Air_Temperature_Setpoint](../Unoccupied_Air_Temperature_Setpoint/Unoccupied_Return_Air_Temperature_Setpoint.md)
* [Occupied_Return_Air_Temperature_Setpoint](Occupied_Return_Air_Temperature_Setpoint.md)

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
