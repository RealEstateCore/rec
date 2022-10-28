[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Valve_Command](#)
# Valve_Command

Controls or reports the openness of a valve (typically as a proportion of its full range of motion)


**Display name:** Valve Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Valve_Command;1

---

## Child interfaces
* [Valve_Position_Command](Valve_Position_Command.md)

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
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
