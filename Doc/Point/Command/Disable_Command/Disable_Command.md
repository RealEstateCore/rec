[Index](../../../Index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Disable_Command](#)
# Disable_Command

**Display name:** Disable Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Disable_Command;1

---

## Child interfaces
* [Disable_Differential_Enthalpy_Command](Disable_Differential_Enthalpy_Command.md)
* [Disable_Differential_Temperature_Command](Disable_Differential_Temperature_Command.md)
* [Disable_Fixed_Enthalpy_Command](Disable_Fixed_Enthalpy_Command.md)
* [Disable_Fixed_Temperature_Command](Disable_Fixed_Temperature_Command.md)

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
