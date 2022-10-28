[Index](../../../index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Demand_Setpoint](Demand_Setpoint.md) > [Preheat_Demand_Setpoint](#)
# Preheat_Demand_Setpoint

Sets the rate required for preheat


**Display name:** Preheat Demand Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Preheat_Demand_Setpoint;1

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
* **[Setpoint](../Setpoint.md):** lastKnownValue
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
