[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Enable_Command](Enable_Command.md) > [Cooling_Enable_Command](#)
# Cooling_Enable_Command

Command that enables cooling functionality in equipment but certain condition(s) must be met first before actively cooling. For the actively cooling control, see Cooling_Command.


**Display name:** Cooling Enable Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Cooling_Enable_Command;1

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
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
