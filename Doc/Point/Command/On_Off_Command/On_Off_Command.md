[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [On_Off_Command](#)
# On_Off_Command

**Display name:** On Off Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:On_Off_Command;1

---

## Child interfaces
* [Lead_On_Off_Command](Lead_On_Off_Command.md)
* [Off_Command](Off_Command.md)
* [On_Command](On_Command.md)
* [Start_Stop_Command](Start_Stop_Command.md)
* [Steam_On_Off_Command](Steam_On_Off_Command.md)

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
