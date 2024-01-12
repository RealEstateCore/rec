[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Load_Shed_Command](#)
# Load_Shed_Command

Controls load shedding behavior provided by a control system


**Display name:** Load Shed Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Shed_Command;1

---

## Child interfaces
* [Occupied_Load_Shed_Command](Occupied-/Occupied_Load_Shed_Command.md)
* [Standby_Load_Shed_Command](Standby-/Standby_Load_Shed_Command.md)
* [Unoccupied_Load_Shed_Command](Unoccupied-/Unoccupied_Load_Shed_Command.md)

---

## Components

### Inherited Components
* **[Command](../Command.md):** lastKnownValue

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name

---

## Target Of
### General
* [Point](../../Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [System](../../../Collection/System/System.md).includes
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
