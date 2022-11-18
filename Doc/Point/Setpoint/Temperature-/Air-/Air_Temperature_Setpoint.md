[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Temperature_Setpoint](../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](#)
# Air_Temperature_Setpoint

Sets temperature of air


**Display name:** Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Temperature_Setpoint;1

---

## Child interfaces
* [Discharge_Air_Temperature_Setpoint](Discharge-/Discharge_Air_Temperature_Setpoint.md)
* [Effective_Air_Temperature_Setpoint](Effective-/Effective_Air_Temperature_Setpoint.md)
* [Max_Air_Temperature_Setpoint](Max-.md)
* [Min_Air_Temperature_Setpoint](Min-.md)
* [Mixed_Air_Temperature_Setpoint](Mixed-.md)
* [Occupied_Air_Temperature_Setpoint](Occupied-/Occupied_Air_Temperature_Setpoint.md)
* [Outside_Air_Temperature_Setpoint](Outside-/Outside_Air_Temperature_Setpoint.md)
* [Return_Air_Temperature_Setpoint](Return-/Return_Air_Temperature_Setpoint.md)
* [Room_Air_Temperature_Setpoint](Room-/Room_Air_Temperature_Setpoint.md)
* [Supply_Air_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Supply_Air-/Supply_Air_Temperature_Deadband_Setpoint.md)
* [Supply_Air_Temperature_Setpoint](Supply-/Supply_Air_Temperature_Setpoint.md)
* [Unoccupied_Air_Temperature_Setpoint](Unoccupied-/Unoccupied_Air_Temperature_Setpoint.md)
* [Zone_Air_Temperature_Setpoint](Zone-/Zone_Air_Temperature_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name
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
* [ObservationEvent](../../../../Event/Point-/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
