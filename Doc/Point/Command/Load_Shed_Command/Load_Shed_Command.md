[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Load_Shed_Command](#)
# Load_Shed_Command

Controls load shedding behavior provided by a control system


**Display name:** Load Shed Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Shed_Command;1

---

## Child interfaces
* [Standby_Load_Shed_Command](Standby_Load_Shed_Command/Standby_Load_Shed_Command.md)
* [Unoccupied_Load_Shed_Command](Unoccupied_Load_Shed_Command/Unoccupied_Load_Shed_Command.md)
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
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
