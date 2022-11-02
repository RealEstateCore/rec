[Index](../../../../index.md) > [Point](../../../Point.md) > [Command](../../Command.md) > [Enable_Command](../Enable_Command.md) > [System_Enable_Command](System_Enable_Command.md) > [Chilled_Water_System_Enable_Command](#)
# Chilled_Water_System_Enable_Command

Enables operation of the chilled water system


**Display name:** Chilled Water System Enable Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Chilled_Water_System_Enable_Command;1

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Command](../../Command.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
