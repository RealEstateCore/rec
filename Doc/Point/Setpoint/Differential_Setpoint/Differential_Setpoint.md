[Index](../../../index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Differential_Setpoint](#)
# Differential_Setpoint

A type of Setpoints that is related to the difference between two measurements


**Display name:** Differential Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Setpoint;1

---

## Child interfaces
* [Differential_Speed_Setpoint](Differential_Speed_Setpoint.md)
* [Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Setpoint](Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Setpoint.md)
* [Differential_Pressure_Deadband_Setpoint](Differential_Pressure_Deadband_Setpoint/Differential_Pressure_Deadband_Setpoint.md)
* [Differential_Pressure_Setpoint](Differential_Pressure_Setpoint/Differential_Pressure_Setpoint.md)
* [Temperature_Differential_Reset_Setpoint](Temperature_Differential_Reset_Setpoint/Temperature_Differential_Reset_Setpoint.md)
* [Differential_Temperature_Setpoint](Differential_Temperature_Setpoint/Differential_Temperature_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../Setpoint.md):** lastKnownValue
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
