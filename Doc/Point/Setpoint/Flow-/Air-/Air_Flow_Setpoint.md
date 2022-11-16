[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Flow_Setpoint](../Flow_Setpoint.md) > [Air_Flow_Setpoint](#)
# Air_Flow_Setpoint

Sets air flow


**Display name:** Air Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Flow_Setpoint;1

---

## Child interfaces
* [Air_Flow_Deadband_Setpoint](Air_Flow_Deadband_Setpoint/Air_Flow_Deadband_Setpoint.md)
* [Air_Flow_Demand_Setpoint](Air_Flow_Demand_Setpoint/Air_Flow_Demand_Setpoint.md)
* [Discharge_Air_Flow_Setpoint](Discharge-/Discharge_Air_Flow_Setpoint.md)
* [Exhaust_Air_Flow_Setpoint](Exhaust-/Exhaust_Air_Flow_Setpoint.md)
* [Outside_Air_Flow_Setpoint](Outside-.md)
* [Supply_Air_Flow_Setpoint](Supply-/Supply_Air_Flow_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name
* **[Setpoint](../../Setpoint.md):** lastKnownValue

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
