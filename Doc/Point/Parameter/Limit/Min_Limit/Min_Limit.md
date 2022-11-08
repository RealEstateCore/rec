[Index](../../../../index.md) > [Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Min_Limit](#)
# Min_Limit

A parameter that places a lower bound on the range of permitted values of a Setpoint.


**Display name:** Min Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Min_Limit;1

---

## Child interfaces
* [Min_Speed_Setpoint_Limit](../Speed_Setpoint_Limit/Min_Speed_Setpoint_Limit.md)
* [Min_Position_Setpoint_Limit](../Position_Limit/Min_Position_Setpoint_Limit.md)
* [Min_Fresh_Air_Setpoint_Limit](Min_Fresh_Air_Setpoint_Limit.md)
* [Min_Chilled_Water_Differential_Pressure_Setpoint_Limit](Min_Chilled_Water_Differential_Pressure_Setpoint_Limit.md)
* [Min_Hot_Water_Differential_Pressure_Setpoint_Limit](Min_Hot_Water_Differential_Pressure_Setpoint_Limit.md)
* [Min_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit/Min_Static_Pressure_Setpoint_Limit/Min_Static_Pressure_Setpoint_Limit.md)
* [Min_Temperature_Setpoint_Limit](Min_Temperature_Setpoint_Limit/Min_Temperature_Setpoint_Limit.md)
* [Min_Air_Flow_Setpoint_Limit](Min_Air_Flow_Setpoint_Limit/Min_Air_Flow_Setpoint_Limit.md)
* [Min_Discharge_Air_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit/Min_Static_Pressure_Setpoint_Limit/Min_Discharge_Air_Static_Pressure_Setpoint_Limit.md)
* [Min_Supply_Air_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit/Min_Static_Pressure_Setpoint_Limit/Min_Supply_Air_Static_Pressure_Setpoint_Limit.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../../Parameter.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### General
* [Point](../../../Point.md).isPointOf
* [Space](../../../../Space/Space.md).isLocationOf
* [Agent](../../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
