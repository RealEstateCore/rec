[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Water_Temperature_Setpoint](../Water_Temperature_Setpoint.md) > [Leaving_Water_Temperature_Setpoint](#)
# Leaving_Water_Temperature_Setpoint

Sets temperature of leaving water


**Display name:** Leaving Water Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Water_Temperature_Setpoint;1

---

## Child interfaces
* [Leaving_Chilled_Water_Temperature_Setpoint](Leaving_Chilled_Water_Temperature_Setpoint.md)
* [Leaving_Hot_Water_Temperature_Setpoint](Leaving_Hot_Water_Temperature_Setpoint.md)
* [Entering_Condenser_Water_Temperature_Setpoint](Entering_Condenser_Water_Temperature_Setpoint.md)
* [Leaving_Condenser_Water_Temperature_Setpoint](Leaving_Condenser_Water_Temperature_Setpoint.md)
* [Leaving_Water_Temperature_Deadband_Setpoint](Leaving_Water_Temperature_Deadband_Setpoint.md)
* [Leaving_Domestic_Hot_Water_Temperature_Setpoint](../Hot_Water_Temperature_Setpoint/Domestic_Hot_Water_Temperature_Setpoint/Leaving_Domestic_Hot_Water_Temperature_Setpoint.md)

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
