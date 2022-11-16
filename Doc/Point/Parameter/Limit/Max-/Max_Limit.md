[Index](../../../../index.md) > [Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Max_Limit](#)
# Max_Limit

A parameter that places an upper bound on the range of permitted values of a Setpoint.


**Display name:** Max Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Max_Limit;1

---

## Child interfaces
* [Max_Air_Flow_Setpoint_Limit](Max_Air_Flow_Setpoint_Limit/Max_Air_Flow_Setpoint_Limit.md)
* [Max_Chilled_Water_Differential_Pressure_Setpoint_Limit](Max_Chilled_Water_Differential_Pressure_Setpoint_Limit.md)
* [Max_Discharge_Air_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint-/Max-/Max_Discharge_Air_Static_Pressure_Setpoint_Limit.md)
* [Max_Fresh_Air_Setpoint_Limit](Max_Fresh_Air_Setpoint_Limit.md)
* [Max_Hot_Water_Differential_Pressure_Setpoint_Limit](Max_Hot_Water_Differential_Pressure_Setpoint_Limit.md)
* [Max_Position_Setpoint_Limit](../Position-/Max_Position_Setpoint_Limit.md)
* [Max_Speed_Setpoint_Limit](../Speed_Setpoint-/Max-.md)
* [Max_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint-/Max-/Max_Static_Pressure_Setpoint_Limit.md)
* [Max_Supply_Air_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint-/Max-/Max_Supply_Air_Static_Pressure_Setpoint_Limit.md)
* [Max_Temperature_Setpoint_Limit](Max_Temperature_Setpoint_Limit/Max_Temperature_Setpoint_Limit.md)

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
* [Agent](../../../../Agent/Agent.md).owns
* [Space](../../../../Space/Space.md).isLocationOf
* [Equipment](../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../../Collection/Equipment-.md).feeds
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
