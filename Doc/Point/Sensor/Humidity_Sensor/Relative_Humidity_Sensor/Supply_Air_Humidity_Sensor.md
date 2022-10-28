[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Humidity_Sensor](../Humidity_Sensor.md) > [Relative_Humidity_Sensor](Relative_Humidity_Sensor.md) > [Supply_Air_Humidity_Sensor](#)
# Supply_Air_Humidity_Sensor

**Display name:** Supply Air Humidity Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Humidity_Sensor;1

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
* **[Humidity_Sensor](../Humidity_Sensor.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
