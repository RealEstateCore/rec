[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Conductivity_Sensor](Conductivity_Sensor.md) > [Deionised_Water_Conductivity_Sensor](#)
# Deionised_Water_Conductivity_Sensor

Measures the electrical conductance of deionised water


**Display name:** Deionised Water Conductivity Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Deionised_Water_Conductivity_Sensor;1

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
* **[Conductivity_Sensor](Conductivity_Sensor.md):** lastKnownValue
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
