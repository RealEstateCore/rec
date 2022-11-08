[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Temperature_Setpoint](../Temperature_Setpoint.md) > [Cooling_Temperature_Setpoint](#)
# Cooling_Temperature_Setpoint

Sets temperature for cooling


**Display name:** Cooling Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Cooling_Temperature_Setpoint;1

---

## Child interfaces
* [Cooling_Supply_Air_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Supply_Air-/Cooling-.md)
* [Discharge_Air_Temperature_Cooling_Setpoint](../Air-/Discharge-/Discharge_Air_Temperature_Cooling_Setpoint/Discharge_Air_Temperature_Cooling_Setpoint.md)
* [Effective_Air_Temperature_Cooling_Setpoint](../Air-/Effective-/Effective_Air_Temperature_Cooling_Setpoint.md)
* [Occupied_Air_Temperature_Cooling_Setpoint](../Air-/Occupied-/Occupied_Air_Temperature_Cooling_Setpoint.md)
* [Occupied_Cooling_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Occupied_Cooling-.md)
* [Occupied_Cooling_Temperature_Setpoint](Occupied-.md)
* [Supply_Air_Temperature_Cooling_Setpoint](../Air-/Supply-/Supply_Air_Temperature_Cooling_Setpoint.md)
* [Unoccupied_Air_Temperature_Cooling_Setpoint](../Air-/Unoccupied-/Unoccupied_Air_Temperature_Cooling_Setpoint.md)
* [Unoccupied_Cooling_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Unoccupied_Cooling-.md)
* [Unoccupied_Cooling_Temperature_Setpoint](Unoccupied-.md)
* [Zone_Air_Cooling_Temperature_Setpoint](../Air-/Zone-/Zone_Air_Cooling_Temperature_Setpoint.md)

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
* [ObservationEvent](../../../../Event/Point-/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
