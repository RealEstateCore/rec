[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Effective_Air_Temperature_Setpoint](#)
# Effective_Air_Temperature_Setpoint

**Display name:** Effective Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Effective_Air_Temperature_Setpoint;1

---

## Child interfaces
* [Effective_Air_Temperature_Cooling_Setpoint](Effective_Air_Temperature_Cooling_Setpoint.md)
* [Effective_Air_Temperature_Heating_Setpoint](Effective_Air_Temperature_Heating_Setpoint.md)
* [Effective_Discharge_Air_Temperature_Setpoint](Effective_Discharge_Air_Temperature_Setpoint.md)
* [Effective_Return_Air_Temperature_Setpoint](../Return-/Effective-.md)
* [Effective_Room_Air_Temperature_Setpoint](../Room-/Effective-.md)
* [Effective_Supply_Air_Temperature_Setpoint](../Supply-/Effective-.md)
* [Effective_Zone_Air_Temperature_Setpoint](../Zone-/Effective-.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name
* **[Setpoint](../../../Setpoint.md):** lastKnownValue

---

## Target Of
### General
* [Point](../../../../Point.md).isPointOf
* [Agent](../../../../../Agent/Agent.md).owns
* [Space](../../../../../Space/Space.md).isLocationOf
* [Equipment](../../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../../../Collection/Equipment-.md).feeds
* [Lease](../../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
