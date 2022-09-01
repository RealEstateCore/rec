[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Proportional_Band_Parameter](../Proportional_Band_Parameter.md) > [Differential_Pressure_Proportional_Band](#)
# Differential_Pressure_Proportional_Band

**Display name:** Differential Pressure Proportional Band<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Pressure_Proportional_Band;1

---

## Child interfaces
* [Chilled_Water_Differential_Pressure_Proportional_Band_Parameter](Chilled_Water_Differential_Pressure_Proportional_Band_Parameter.md)
* [Entering_Water_Differential_Pressure_Proportional_Band_Parameter](Entering_Water_Differential_Pressure_Proportional_Band_Parameter.md)
* [Hot_Water_Differential_Pressure_Proportional_Band_Parameter](Hot_Water_Differential_Pressure_Proportional_Band_Parameter.md)
* [Leaving_Water_Differential_Pressure_Proportional_Band_Parameter](Leaving_Water_Differential_Pressure_Proportional_Band_Parameter.md)

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
