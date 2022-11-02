[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Position_Command](#)
# Position_Command

Controls or reports the position of some object


**Display name:** Position Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Position_Command;1

---

## Child interfaces
* [Damper_Position_Command](Damper_Position_Command.md)
* [Valve_Position_Command](../Valve_Command/Valve_Position_Command.md)

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
