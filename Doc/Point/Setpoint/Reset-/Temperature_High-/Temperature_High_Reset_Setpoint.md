[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Reset_Setpoint](../Reset_Setpoint.md) > [Temperature_High_Reset_Setpoint](#)
# Temperature_High_Reset_Setpoint

**Display name:** Temperature High Reset Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_High_Reset_Setpoint;1

---

## Child interfaces
* [Entering_Hot_Water_Temperature_High_Reset_Setpoint](Entering_Hot_Water-/Entering_Hot_Water_Temperature_High_Reset_Setpoint.md)
* [Leaving_Hot_Water_Temperature_High_Reset_Setpoint](Leaving_Hot_Water-/Leaving_Hot_Water_Temperature_High_Reset_Setpoint.md)
* [Outside_Air_Temperature_High_Reset_Setpoint](Outside_Air-.md)
* [Return_Air_Temperature_High_Reset_Setpoint](Return_Air-.md)
* [Supply_Air_Temperature_High_Reset_Setpoint](Supply_Air-.md)

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
