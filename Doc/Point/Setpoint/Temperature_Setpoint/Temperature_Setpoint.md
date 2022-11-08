[Index](../../../index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Temperature_Setpoint](#)
# Temperature_Setpoint

Sets temperature


**Display name:** Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_Setpoint;1

---

## Child interfaces
* [Schedule_Temperature_Setpoint](Schedule_Temperature_Setpoint.md)
* [Temperature_Deadband_Setpoint](Temperature_Deadband_Setpoint/Temperature_Deadband_Setpoint.md)
* [Radiant_Panel_Temperature_Setpoint](Radiant_Panel_Temperature_Setpoint/Radiant_Panel_Temperature_Setpoint.md)
* [Cooling_Temperature_Setpoint](Cooling_Temperature_Setpoint/Cooling_Temperature_Setpoint.md)
* [Water_Temperature_Setpoint](Water_Temperature_Setpoint/Water_Temperature_Setpoint.md)
* [Air_Temperature_Setpoint](Air_Temperature_Setpoint/Air_Temperature_Setpoint.md)
* [Heating_Temperature_Setpoint](Heating_Temperature_Setpoint/Heating_Temperature_Setpoint.md)

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
