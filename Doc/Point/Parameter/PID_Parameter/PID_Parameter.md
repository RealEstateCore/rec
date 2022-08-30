[Index](../../../Index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [PID_Parameter](#)
# PID_Parameter

**Display name:** PID Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:PID_Parameter;1

---

## Child interfaces
* [Gain_Parameter](Gain_Parameter/Gain_Parameter.md)
* [Proportional_Band_Parameter](Proportional_Band_Parameter/Proportional_Band_Parameter.md)
* [Step_Parameter](Step_Parameter/Step_Parameter.md)
* [Time_Parameter](Time_Parameter/Time_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
