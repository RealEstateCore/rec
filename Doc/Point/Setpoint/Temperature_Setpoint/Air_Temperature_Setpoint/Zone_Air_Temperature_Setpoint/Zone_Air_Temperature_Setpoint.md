[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Zone_Air_Temperature_Setpoint](#)
# Zone_Air_Temperature_Setpoint

Sets temperature of zone air


**Display name:** Zone Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Zone_Air_Temperature_Setpoint;1

---

## Child interfaces
* [Unoccupied_Zone_Air_Temperature_Setpoint](Unoccupied_Zone_Air_Temperature_Setpoint.md)
* [Effective_Zone_Air_Temperature_Setpoint](Effective_Zone_Air_Temperature_Setpoint.md)
* [Zone_Air_Cooling_Temperature_Setpoint](Zone_Air_Cooling_Temperature_Setpoint.md)
* [Zone_Air_Heating_Temperature_Setpoint](Zone_Air_Heating_Temperature_Setpoint.md)
* [Occupied_Zone_Air_Temperature_Setpoint](Occupied_Zone_Air_Temperature_Setpoint.md)

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
