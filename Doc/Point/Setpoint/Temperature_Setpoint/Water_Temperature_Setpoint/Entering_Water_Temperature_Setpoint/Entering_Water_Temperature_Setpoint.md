[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Water_Temperature_Setpoint](../Water_Temperature_Setpoint.md) > [Entering_Water_Temperature_Setpoint](#)
# Entering_Water_Temperature_Setpoint

**Display name:** Entering Water Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Entering_Water_Temperature_Setpoint;1

---

## Child interfaces
* [Entering_Chilled_Water_Temperature_Setpoint](Entering_Chilled_Water_Temperature_Setpoint.md)
* [Entering_Hot_Water_Temperature_Setpoint](../Hot_Water_Temperature_Setpoint/Entering_Hot_Water_Temperature_Setpoint.md)
* [Entering_Water_Temperature_Deadband_Setpoint](Entering_Water_Temperature_Deadband_Setpoint.md)
* [Entering_Domestic_Hot_Water_Temperature_Setpoint](../Hot_Water_Temperature_Setpoint/Domestic_Hot_Water_Temperature_Setpoint/Entering_Domestic_Hot_Water_Temperature_Setpoint.md)

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
