[Index](../../../index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Limit](#)
# Limit

A parameter that places an upper or lower bound on the range of permitted values of another point


**Display name:** Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Limit;1

---

## Child interfaces
* [Air_Flow_Setpoint_Limit](Air_Flow_Setpoint-/Air_Flow_Setpoint_Limit.md)
* [Air_Temperature_Setpoint_Limit](../Temperature-/Air_Temperature_Setpoint_Limit/Air_Temperature_Setpoint_Limit.md)
* [Close_Limit](Close-.md)
* [Current_Limit](Current-.md)
* [Differential_Pressure_Setpoint_Limit](Differential_Pressure_Setpoint-/Differential_Pressure_Setpoint_Limit.md)
* [Fresh_Air_Setpoint_Limit](Fresh_Air_Setpoint-/Fresh_Air_Setpoint_Limit.md)
* [Max_Limit](Max-/Max_Limit.md)
* [Min_Limit](Min-/Min_Limit.md)
* [Position_Limit](Position-/Position_Limit.md)
* [Speed_Setpoint_Limit](Speed_Setpoint-/Speed_Setpoint_Limit.md)
* [Static_Pressure_Setpoint_Limit](Static_Pressure_Setpoint-/Static_Pressure_Setpoint_Limit.md)
* [Ventilation_Air_Flow_Ratio_Limit](Ventilation_Air_Flow_Ratio-.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../Parameter.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### General
* [Point](../../Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../Collection/Equipment-.md).feeds
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/Point-/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
