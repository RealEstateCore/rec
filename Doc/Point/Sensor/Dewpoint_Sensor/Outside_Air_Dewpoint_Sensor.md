[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Dewpoint_Sensor](Dewpoint_Sensor.md) > [Outside_Air_Dewpoint_Sensor](#)
# Outside_Air_Dewpoint_Sensor

Senses the dewpoint temperature of outside air


**Display name:** Outside Air Dewpoint Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Outside_Air_Dewpoint_Sensor;1

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
* **[Dewpoint_Sensor](Dewpoint_Sensor.md):** lastKnownValue
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
