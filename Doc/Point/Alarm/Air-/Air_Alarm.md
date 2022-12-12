[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Air_Alarm](#)
# Air_Alarm

**Display name:** Air Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Alarm;1

---

## Child interfaces
* [Air_Flow_Alarm](Air_Flow_Alarm/Air_Flow_Alarm.md)
* [Air_Temperature_Alarm](../Temperature-/Air-/Air_Temperature_Alarm.md)
* [Discharge_Air_Smoke_Detection_Alarm](../Smoke-/Smoke_Detection_Alarm/Discharge_Air-.md)
* [Supply_Air_Smoke_Detection_Alarm](../Smoke-/Smoke_Detection_Alarm/Supply_Air-.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Alarm](../Alarm.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name

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
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../Asset/Asset.md).hasPoint
* [ExceptionEvent](../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
