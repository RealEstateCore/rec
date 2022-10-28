[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Temperature_Sensor](Temperature_Sensor.md) > [Heat_Sink_Temperature_Sensor](#)
# Heat_Sink_Temperature_Sensor

Measure temperature of the heat sink on a device such as a VFD.


**Display name:** Heat Sink Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heat_Sink_Temperature_Sensor;1

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
* **[Temperature_Sensor](Temperature_Sensor.md):** lastKnownValue
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
