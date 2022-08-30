[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Load_Setpoint](../../Load_Setpoint.md) > [Load_Shed_Setpoint](../Load_Shed_Setpoint.md) > [Load_Shed_Differential_Pressure_Setpoint](#)
# Load_Shed_Differential_Pressure_Setpoint

**Display name:** Load Shed Differential Pressure Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Shed_Differential_Pressure_Setpoint;1

---

## Child interfaces
* [Chilled_Water_Differential_Pressure_Load_Shed_Setpoint](../../../Differential_Setpoint/Differential_Pressure_Setpoint/Water_Differential_Pressure_Setpoint/Chilled_Water_Differential_Pressure_Setpoint/Chilled_Water_Differential_Pressure_Load_Shed_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

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
