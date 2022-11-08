[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Temperature_Setpoint](../Temperature_Setpoint.md) > [Water_Temperature_Setpoint](#)
# Water_Temperature_Setpoint

Sets temperature of water


**Display name:** Water Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Temperature_Setpoint;1

---

## Child interfaces
* [Min_Water_Temperature_Setpoint](Min_Water_Temperature_Setpoint.md)
* [Max_Water_Temperature_Setpoint](Max_Water_Temperature_Setpoint.md)
* [Hot_Water_Temperature_Setpoint](Hot_Water_Temperature_Setpoint/Hot_Water_Temperature_Setpoint.md)
* [Chilled_Water_Temperature_Setpoint](Chilled_Water_Temperature_Setpoint/Chilled_Water_Temperature_Setpoint.md)
* [Leaving_Water_Temperature_Setpoint](Leaving_Water_Temperature_Setpoint/Leaving_Water_Temperature_Setpoint.md)
* [Entering_Water_Temperature_Setpoint](Entering_Water_Temperature_Setpoint/Entering_Water_Temperature_Setpoint.md)
* [Domestic_Hot_Water_Temperature_Setpoint](Hot_Water_Temperature_Setpoint/Domestic_Hot_Water_Temperature_Setpoint/Domestic_Hot_Water_Temperature_Setpoint.md)

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
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
