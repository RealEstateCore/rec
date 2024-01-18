[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Temperature_Setpoint](../Temperature_Setpoint.md) > [Temperature_Deadband_Setpoint](#)
# Temperature_Deadband_Setpoint

Sets the size of a deadband of temperature


**Display name:** Temperature Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_Deadband_Setpoint;1

---

## Child interfaces
* [Discharge_Air_Temperature_Deadband_Setpoint](../Air-/Discharge-/Discharge_Air_Temperature_Deadband_Setpoint/Discharge_Air_Temperature_Deadband_Setpoint.md)
* [Entering_Water_Temperature_Deadband_Setpoint](../Water-/Entering-/Entering_Water_Temperature_Deadband_Setpoint.md)
* [Leaving_Water_Temperature_Deadband_Setpoint](../Water-/Leaving-/Leaving_Water_Temperature_Deadband_Setpoint.md)
* [Occupied_Cooling_Temperature_Deadband_Setpoint](Occupied_Cooling-.md)
* [Occupied_Heating_Temperature_Deadband_Setpoint](Occupied_Heating-.md)
* [Supply_Air_Temperature_Deadband_Setpoint](Supply_Air-/Supply_Air_Temperature_Deadband_Setpoint.md)
* [Unoccupied_Cooling_Temperature_Deadband_Setpoint](Unoccupied_Cooling-.md)
* [Unoccupied_Heating_Temperature_Deadband_Setpoint](Unoccupied_Heating-.md)

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
* [System](../../../../Collection/System/System.md).includes
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../../Asset/Asset.md).hasPoint
* [ExceptionEvent](../../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
