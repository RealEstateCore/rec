[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Mode_Command](#)
# Mode_Command

**Display name:** Mode Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Mode_Command;1

---

## Child interfaces
* [Automatic_Mode_Command](Automatic_Mode_Command.md)
* [Box_Mode_Command](Box_Mode_Command.md)
* [Maintenance_Mode_Command](Maintenance_Mode_Command.md)

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
