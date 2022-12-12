[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Time_Parameter](../Time_Parameter.md) > [Integral_Time_Parameter](#)
# Integral_Time_Parameter

**Display name:** Integral Time Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Integral_Time_Parameter;1

---

## Child interfaces
* [Air_Temperature_Integral_Time_Parameter](Air_Temperature-/Air_Temperature_Integral_Time_Parameter.md)
* [Differential_Pressure_Integral_Time_Parameter](Differential_Pressure-/Differential_Pressure_Integral_Time_Parameter.md)
* [Entering_Water_Temperature_Integral_Time_Parameter](Entering_Water_Temperature-.md)
* [Exhaust_Air_Flow_Integral_Time_Parameter](Exhaust_Air_Flow-/Exhaust_Air_Flow_Integral_Time_Parameter.md)
* [Leaving_Water_Temperature_Integral_Time_Parameter](Leaving_Water_Temperature-.md)
* [Static_Pressure_Integral_Time_Parameter](Static_Pressure-/Static_Pressure_Integral_Time_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../../../Parameter.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name

---

## Target Of
### General
* [Point](../../../../Point.md).isPointOf
* [Agent](../../../../../Agent/Agent.md).owns
* [Space](../../../../../Space/Space.md).isLocationOf
* [Equipment](../../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../../Information/Document/Document.md).url
* [Lease](../../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [ExceptionEvent](../../../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
