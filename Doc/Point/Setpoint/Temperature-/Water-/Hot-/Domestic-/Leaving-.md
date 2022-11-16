[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Temperature_Setpoint](../../../Temperature_Setpoint.md) > [Water_Temperature_Setpoint](../../Water_Temperature_Setpoint.md) > [Hot_Water_Temperature_Setpoint](../Hot_Water_Temperature_Setpoint.md) > [Domestic_Hot_Water_Temperature_Setpoint](Domestic_Hot_Water_Temperature_Setpoint.md) > [Leaving_Domestic_Hot_Water_Temperature_Setpoint](#)
# Leaving_Domestic_Hot_Water_Temperature_Setpoint

Sets temperature of leavinging part of domestic hot water


**Display name:** Leaving Domestic Hot Water Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Domestic_Hot_Water_Temperature_Setpoint;1

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Point](../../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name
* **[Setpoint](../../../../Setpoint.md):** lastKnownValue

---

## Target Of
### General
* [Point](../../../../../Point.md).isPointOf
* [Agent](../../../../../../Agent/Agent.md).owns
* [Space](../../../../../../Space/Space.md).isLocationOf
* [Equipment](../../../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../../../../Collection/Equipment-.md).feeds
* [Lease](../../../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../../../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).producedBy
