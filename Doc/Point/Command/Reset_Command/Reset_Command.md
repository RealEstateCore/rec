[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Reset_Command](#)
# Reset_Command

**Display name:** Reset Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Reset_Command;1

---

## Child interfaces
* [Fault_Reset_Command](Fault_Reset_Command.md)
* [Filter_Reset_Command](Filter_Reset_Command.md)
* [Speed_Reset_Command](Speed_Reset_Command.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

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
