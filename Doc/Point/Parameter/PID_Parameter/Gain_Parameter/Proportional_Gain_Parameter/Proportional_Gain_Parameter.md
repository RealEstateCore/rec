[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Gain_Parameter](../Gain_Parameter.md) > [Proportional_Gain_Parameter](#)
# Proportional_Gain_Parameter

**Display name:** Proportional Gain Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Proportional_Gain_Parameter;1

---

## Child interfaces
* [Discharge_Air_Proportional_Gain_Parameter](Discharge_Air_Proportional_Gain_Parameter.md)
* [Supply_Air_Proportional_Gain_Parameter](Supply_Air_Proportional_Gain_Parameter.md)

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
