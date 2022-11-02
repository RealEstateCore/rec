[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Mode_Command](#)
# Mode_Command

Controls the operating mode of a device or controller


**Display name:** Mode Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Mode_Command;1

---

## Child interfaces
* [Box_Mode_Command](Box_Mode_Command.md)
* [Maintenance_Mode_Command](Maintenance_Mode_Command.md)
* [Automatic_Mode_Command](Automatic_Mode_Command.md)

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
