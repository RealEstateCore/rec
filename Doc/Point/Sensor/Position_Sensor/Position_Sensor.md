[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Position_Sensor](#)
# Position_Sensor

Measures the current position of a component in terms of a fraction of its full range of motion


**Display name:** Position Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Position_Sensor;1

---

## Child interfaces
* [Valve_Position_Sensor](Valve_Position_Sensor.md)
* [Damper_Position_Sensor](Damper_Position_Sensor.md)
* [Sash_Position_Sensor](Sash_Position_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|lastKnownValue|**en**: last known value||Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
### Inherited Properties
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
