[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Temperature_Setpoint](../../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../../Air_Temperature_Setpoint.md) > [Discharge_Air_Temperature_Setpoint](../Discharge_Air_Temperature_Setpoint.md) > [Discharge_Air_Temperature_Deadband_Setpoint](#)
# Discharge_Air_Temperature_Deadband_Setpoint

Sets the size of a deadband of temperature of discharge air


**Display name:** Discharge Air Temperature Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Deadband_Setpoint;1

---

## Child interfaces
* [Cooling_Discharge_Air_Temperature_Deadband_Setpoint](Cooling_Discharge_Air_Temperature_Deadband_Setpoint.md)
* [Heating_Discharge_Air_Temperature_Deadband_Setpoint](../Discharge_Air_Temperature_Heating_Setpoint/Heating_Discharge_Air_Temperature_Deadband_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../../../../Setpoint.md):** lastKnownValue
* **[Point](../../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### General
* [Point](../../../../../Point.md).isPointOf
* [Space](../../../../../../Space/Space.md).isLocationOf
* [Agent](../../../../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../../../../Collection/Portfolio.md).includes
* [Lease](../../../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../../../Information/Document/Document.md).url
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
