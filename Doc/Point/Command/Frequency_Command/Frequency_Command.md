[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Frequency_Command](#)
# Frequency_Command

**Display name:** Frequency Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Frequency_Command;1

---

## Child interfaces
* [Max_Frequency_Command](Max_Frequency_Command.md)
* [Min_Frequency_Command](Min_Frequency_Command.md)

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
