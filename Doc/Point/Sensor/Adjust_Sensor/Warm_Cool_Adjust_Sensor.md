[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Adjust_Sensor](Adjust_Sensor.md) > [Warm_Cool_Adjust_Sensor](#)
# Warm_Cool_Adjust_Sensor

User provided adjustment of zone temperature, typically in the range of +/- 5 degrees


**Display name:** Warm Cool Adjust Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Warm_Cool_Adjust_Sensor;1

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
* **[Adjust_Sensor](Adjust_Sensor.md):** lastKnownValue
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
