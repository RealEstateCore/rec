[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Step_Parameter](../Step_Parameter.md) > [Differential_Pressure_Step_Parameter](#)
# Differential_Pressure_Step_Parameter

**Display name:** Differential Pressure Step Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Pressure_Step_Parameter;1

---

## Child interfaces
* [Chilled_Water_Differential_Pressure_Step_Parameter](Chilled_Water_Differential_Pressure_Step_Parameter.md)

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
