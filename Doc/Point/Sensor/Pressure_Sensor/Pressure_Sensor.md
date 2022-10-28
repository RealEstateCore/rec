[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Pressure_Sensor](#)
# Pressure_Sensor

Measure the amount of force acting on a unit area


**Display name:** Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Pressure_Sensor;1

---

## Child interfaces
* [Differential_Pressure_Sensor](Differential_Pressure_Sensor/Differential_Pressure_Sensor.md)
* [Static_Pressure_Sensor](Static_Pressure_Sensor/Static_Pressure_Sensor.md)
* [Velocity_Pressure_Sensor](Velocity_Pressure_Sensor/Velocity_Pressure_Sensor.md)

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
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
