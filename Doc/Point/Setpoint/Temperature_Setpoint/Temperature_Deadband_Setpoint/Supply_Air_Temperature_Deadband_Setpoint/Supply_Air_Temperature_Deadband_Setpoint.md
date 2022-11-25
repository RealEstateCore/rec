[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint.md) > [Supply_Air_Temperature_Deadband_Setpoint](#)
# Supply_Air_Temperature_Deadband_Setpoint

Sets the size of a deadband of temperature of supply air


**Display name:** Supply Air Temperature Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Temperature_Deadband_Setpoint;1

---

## Child interfaces
* [Cooling_Supply_Air_Temperature_Deadband_Setpoint](Cooling_Supply_Air_Temperature_Deadband_Setpoint.md)
* [Heating_Supply_Air_Temperature_Deadband_Setpoint](Heating_Supply_Air_Temperature_Deadband_Setpoint.md)

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