[Index](../../index.md) > [Point](../Point.md) > [Parameter](#)
# Parameter

Parameter points are configuration settings used to guide the operation of equipment and control systems; for example they may provide bounds on valid setpoint values


**Display name:** Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Parameter;1

---

## Child interfaces
* [Alarm_Sensitivity_Parameter](Alarm_Sensitivity-/Alarm_Sensitivity_Parameter.md)
* [Delay_Parameter](Delay-/Delay_Parameter.md)
* [Humidity_Parameter](Humidity-/Humidity_Parameter.md)
* [Limit](Limit/Limit.md)
* [Load_Parameter](Load-/Load_Parameter.md)
* [PID_Parameter](PID-/PID_Parameter.md)
* [Temperature_Parameter](Temperature-/Temperature_Parameter.md)
* [Tolerance_Parameter](Tolerance-/Tolerance_Parameter.md)

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
* **[Point](../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name

---

## Target Of
### General
* [Point](../Point.md).isPointOf
* [Agent](../../Agent/Agent.md).owns
* [Space](../../Space/Space.md).isLocationOf
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../Asset/Asset.md).hasPoint
* [ExceptionEvent](../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
