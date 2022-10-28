[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Load_Setpoint](../Load_Setpoint.md) > [Load_Shed_Setpoint](#)
# Load_Shed_Setpoint

**Display name:** Load Shed Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Shed_Setpoint;1

---

## Child interfaces
* [Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Setpoint](Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Setpoint.md)
* [Leaving_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Setpoint](Leaving_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Setpoint.md)
* [Load_Shed_Differential_Pressure_Setpoint](Load_Shed_Differential_Pressure_Setpoint/Load_Shed_Differential_Pressure_Setpoint.md)

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
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
