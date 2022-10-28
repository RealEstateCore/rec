[Index](../../index.md) > [Point](../Point.md) > [Setpoint](Setpoint.md) > [Damper_Position_Setpoint](#)
# Damper_Position_Setpoint

**Display name:** Damper Position Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Damper_Position_Setpoint;1

---

## Relationships

### Inherited Relationships
* **[Point](../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Setpoint](Setpoint.md):** lastKnownValue
* **[Point](../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
