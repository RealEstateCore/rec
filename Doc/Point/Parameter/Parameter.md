[Index](../../index.md) > [Point](../Point.md) > [Parameter](#)
# Parameter

Parameter points are configuration settings used to guide the operation of equipment and control systems; for example they may provide bounds on valid setpoint values


**Display name:** Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Parameter;1

---

## Child interfaces
* [Tolerance_Parameter](Tolerance_Parameter/Tolerance_Parameter.md)
* [Alarm_Sensitivity_Parameter](Alarm_Sensitivity_Parameter/Alarm_Sensitivity_Parameter.md)
* [PID_Parameter](PID_Parameter/PID_Parameter.md)
* [Limit](Limit/Limit.md)
* [Delay_Parameter](Delay_Parameter/Delay_Parameter.md)
* [Load_Parameter](Load_Parameter/Load_Parameter.md)
* [Temperature_Parameter](Temperature_Parameter/Temperature_Parameter.md)
* [Humidity_Parameter](Humidity_Parameter/Humidity_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|lastKnownValue|**en**: last known value||Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
### Inherited Properties
* **[Point](../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../Event/PointEvent/ExceptionEvent.md).sourcePoint
