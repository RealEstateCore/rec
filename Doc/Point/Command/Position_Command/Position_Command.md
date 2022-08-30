[Index](../../../Index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Position_Command](#)
# Position_Command

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
