[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Differential_Setpoint](../../../Differential_Setpoint.md) > [Differential_Pressure_Setpoint](../../Differential_Pressure_Setpoint.md) > [Water_Differential_Pressure_Setpoint](../Water_Differential_Pressure_Setpoint.md) > [Hot_Water_Differential_Pressure_Setpoint](#)
# Hot_Water_Differential_Pressure_Setpoint

Sets the target water differential pressure between an upstream and downstream point in a water pipe or conduit used to carry hot water


**Display name:** Hot Water Differential Pressure Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Hot_Water_Differential_Pressure_Setpoint;1

---

## Child interfaces
* [Medium_Temperature_Hot_Water_Differential_Pressure_Setpoint](Medium_Temperature_Hot_Water_Differential_Pressure_Setpoint.md)

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
* [ActuationEvent](../../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../../Space/Architecture/Architecture.md).hasPoint
