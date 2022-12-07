[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Sensor](../../../../Sensor.md) > [Temperature_Sensor](../../../Temperature_Sensor.md) > [Air_Temperature_Sensor](../../Air_Temperature_Sensor.md) > [Outside_Air_Temperature_Sensor](../Outside_Air_Temperature_Sensor.md) > [Outside_Air_Temperature_Enable_Differential_Sensor](#)
# Outside_Air_Temperature_Enable_Differential_Sensor

**Display name:** Outside Air Temperature Enable Differential Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Outside_Air_Temperature_Enable_Differential_Sensor;1

---

## Child interfaces
* [Low_Outside_Air_Temperature_Enable_Differential_Sensor](Low-.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name
* **[Temperature_Sensor](../../../Temperature_Sensor.md):** lastKnownValue

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
