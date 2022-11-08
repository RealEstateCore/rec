[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Load_Shed_Command](#)
# Load_Shed_Command

Controls load shedding behavior provided by a control system


**Display name:** Load Shed Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Shed_Command;1

---

## Child interfaces
* [Unoccupied_Load_Shed_Command](Unoccupied_Load_Shed_Command/Unoccupied_Load_Shed_Command.md)
* [Standby_Load_Shed_Command](Standby_Load_Shed_Command/Standby_Load_Shed_Command.md)
* [Occupied_Load_Shed_Command](Occupied_Load_Shed_Command/Occupied_Load_Shed_Command.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Command](../Command.md):** lastKnownValue
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
