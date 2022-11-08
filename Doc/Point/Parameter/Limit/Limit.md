[Index](../../../index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Limit](#)
# Limit

A parameter that places an upper or lower bound on the range of permitted values of another point


**Display name:** Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Limit;1

---

## Child interfaces
* [Close_Limit](Close_Limit.md)
* [Ventilation_Air_Flow_Ratio_Limit](Ventilation_Air_Flow_Ratio_Limit.md)
* [Current_Limit](Current_Limit.md)
* [Position_Limit](Position_Limit/Position_Limit.md)
* [Min_Limit](Min_Limit/Min_Limit.md)
* [Fresh_Air_Setpoint_Limit](Fresh_Air_Setpoint_Limit/Fresh_Air_Setpoint_Limit.md)
* [Max_Limit](Max_Limit/Max_Limit.md)
* [Air_Flow_Setpoint_Limit](Air_Flow_Setpoint_Limit/Air_Flow_Setpoint_Limit.md)
* [Static_Pressure_Setpoint_Limit](Static_Pressure_Setpoint_Limit/Static_Pressure_Setpoint_Limit.md)
* [Air_Temperature_Setpoint_Limit](../Temperature_Parameter/Air_Temperature_Setpoint_Limit/Air_Temperature_Setpoint_Limit.md)
* [Speed_Setpoint_Limit](Speed_Setpoint_Limit/Speed_Setpoint_Limit.md)
* [Differential_Pressure_Setpoint_Limit](Differential_Pressure_Setpoint_Limit/Differential_Pressure_Setpoint_Limit.md)

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
* [Space](../../../Space/Space.md).isLocationOf
* [Agent](../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../Collection/Portfolio.md).includes
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
