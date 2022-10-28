[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Pressure_Alarm](Pressure_Alarm.md) > [High_Head_Pressure_Alarm](#)
# High_Head_Pressure_Alarm

An alarm that indicates a high pressure generated on the output side of a gas compressor in a refrigeration or air conditioning system.


**Display name:** High Head Pressure Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:High_Head_Pressure_Alarm;1

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
* **[Alarm](../Alarm.md):** lastKnownValue
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
