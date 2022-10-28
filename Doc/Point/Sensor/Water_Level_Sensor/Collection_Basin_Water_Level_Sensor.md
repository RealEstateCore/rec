[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Water_Level_Sensor](Water_Level_Sensor.md) > [Collection_Basin_Water_Level_Sensor](#)
# Collection_Basin_Water_Level_Sensor

Measures the level of the water in the collection basin, e.g. within a Cooling_Tower


**Display name:** Collection Basin Water Level Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Collection_Basin_Water_Level_Sensor;1

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
* **[Water_Level_Sensor](Water_Level_Sensor.md):** lastKnownValue
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
