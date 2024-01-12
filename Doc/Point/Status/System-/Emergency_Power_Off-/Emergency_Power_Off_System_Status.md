[Index](../../../../index.md) > [Point](../../../Point.md) > [Status](../../Status.md) > [System_Status](../System_Status.md) > [Emergency_Power_Off_System_Status](#)
# Emergency_Power_Off_System_Status

**Display name:** Emergency Power Off System Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Emergency_Power_Off_System_Status;1

---

## Child interfaces
* [Emergency_Power_Off_System_Activated_By_High_Temperature_Status](Emergency_Power_Off_System_Activated_By_High_Temperature_Status.md)
* [Emergency_Power_Off_System_Activated_By_Leak_Detection_System_Status](Emergency_Power_Off_System_Activated_By_Leak_Detection_System_Status.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name
* **[Status](../../Status.md):** lastKnownValue

---

## Target Of
### General
* [Point](../../../Point.md).isPointOf
* [Agent](../../../../Agent/Agent.md).owns
* [Space](../../../../Space/Space.md).isLocationOf
* [Equipment](../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../Asset/Equipment/Equipment.md).isFedBy
* [System](../../../../Collection/System/System.md).includes
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../../Asset/Asset.md).hasPoint
* [ExceptionEvent](../../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
