[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Temperature_Setpoint](../Temperature_Setpoint.md) > [Heating_Temperature_Setpoint](#)
# Heating_Temperature_Setpoint

Sets temperature for heating


**Display name:** Heating Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heating_Temperature_Setpoint;1

---

## Child interfaces
* [Discharge_Air_Temperature_Heating_Setpoint](../Air-/Discharge-/Discharge_Air_Temperature_Heating_Setpoint/Discharge_Air_Temperature_Heating_Setpoint.md)
* [Effective_Air_Temperature_Heating_Setpoint](../Air-/Effective-/Effective_Air_Temperature_Heating_Setpoint.md)
* [Heating_Supply_Air_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Supply_Air-/Heating-.md)
* [Occupied_Air_Temperature_Heating_Setpoint](../Air-/Occupied-/Occupied_Air_Temperature_Heating_Setpoint.md)
* [Occupied_Heating_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Occupied_Heating-.md)
* [Occupied_Heating_Temperature_Setpoint](Occupied-.md)
* [Open_Heating_Valve_Outside_Air_Temperature_Setpoint](../Air-/Outside-/Open_Heating_Valve-.md)
* [Supply_Air_Temperature_Heating_Setpoint](../Air-/Supply-/Supply_Air_Temperature_Heating_Setpoint.md)
* [Unoccupied_Air_Temperature_Heating_Setpoint](../Air-/Unoccupied-/Unoccupied_Air_Temperature_Heating_Setpoint.md)
* [Unoccupied_Heating_Temperature_Deadband_Setpoint](../Temperature_Deadband_Setpoint/Unoccupied_Heating-.md)
* [Unoccupied_Heating_Temperature_Setpoint](Unoccupied-.md)
* [Zone_Air_Heating_Temperature_Setpoint](../Air-/Zone-/Zone_Air_Heating_Temperature_Setpoint.md)

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
