[Index](../../../index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Limit](Limit.md) > [Ventilation_Air_Flow_Ratio_Limit](#)
# Ventilation_Air_Flow_Ratio_Limit

A parameter that places a lower or upper bound on the range of permitted values of a Ventilation_Air_Flow_Ratio_Setpoint.


**Display name:** Ventilation Air Flow Ratio Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Ventilation_Air_Flow_Ratio_Limit;1

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
* **[Parameter](../Parameter.md):** lastKnownValue
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
