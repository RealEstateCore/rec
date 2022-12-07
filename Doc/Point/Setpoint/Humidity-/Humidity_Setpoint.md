[Index](../../../index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Humidity_Setpoint](#)
# Humidity_Setpoint

Sets humidity


**Display name:** Humidity Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Humidity_Setpoint;1

---

## Child interfaces
* [Building_Air_Humidity_Setpoint](Building_Air-.md)
* [Bypass_Air_Humidity_Setpoint](Bypass_Air-.md)
* [Discharge_Air_Humidity_Setpoint](Discharge_Air-.md)
* [Exhaust_Air_Humidity_Setpoint](Exhaust_Air-.md)
* [Mixed_Air_Humidity_Setpoint](Mixed_Air-.md)
* [Occupied_Humidity_Setpoint](Occupied-.md)
* [Outside_Air_Humidity_Setpoint](Outside_Air-.md)
* [Return_Air_Humidity_Setpoint](Return_Air-.md)
* [Supply_Air_Humidity_Setpoint](Supply_Air-.md)
* [Unoccupied_Humidity_Setpoint](Unoccupied-.md)
* [Zone_Air_Humidity_Setpoint](Zone_Air-.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name
* **[Setpoint](../Setpoint.md):** lastKnownValue

---

## Target Of
### General
* [Point](../../Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../Collection/Equipment-.md).feeds
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/Point-/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
