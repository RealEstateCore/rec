[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Gain_Parameter](../Gain_Parameter.md) > [Proportional_Gain_Parameter](#)
# Proportional_Gain_Parameter

**Display name:** Proportional Gain Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Proportional_Gain_Parameter;1

---

## Child interfaces
* [Supply_Air_Proportional_Gain_Parameter](Supply_Air_Proportional_Gain_Parameter.md)
* [Discharge_Air_Proportional_Gain_Parameter](Discharge_Air_Proportional_Gain_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../../../Parameter.md):** lastKnownValue
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
