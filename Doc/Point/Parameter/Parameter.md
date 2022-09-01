[Index](../../index.md) > [Point](../Point.md) > [Parameter](#)
# Parameter

**Display name:** Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Parameter;1

---

## Child interfaces
* [Alarm_Sensitivity_Parameter](Alarm_Sensitivity_Parameter/Alarm_Sensitivity_Parameter.md)
* [Delay_Parameter](Delay_Parameter/Delay_Parameter.md)
* [Humidity_Parameter](Humidity_Parameter/Humidity_Parameter.md)
* [Limit](Limit/Limit.md)
* [Load_Parameter](Load_Parameter/Load_Parameter.md)
* [PID_Parameter](PID_Parameter/PID_Parameter.md)
* [Temperature_Parameter](Temperature_Parameter/Temperature_Parameter.md)
* [Tolerance_Parameter](Tolerance_Parameter/Tolerance_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
