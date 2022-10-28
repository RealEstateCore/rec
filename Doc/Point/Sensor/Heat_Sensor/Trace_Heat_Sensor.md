[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Heat_Sensor](Heat_Sensor.md) > [Trace_Heat_Sensor](#)
# Trace_Heat_Sensor

Measures the surface temperature of pipelines carrying temperature-sensitive products; typically used to avoid frosting/freezing


**Display name:** Trace Heat Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Trace_Heat_Sensor;1

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
* **[Heat_Sensor](Heat_Sensor.md):** lastKnownValue
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
