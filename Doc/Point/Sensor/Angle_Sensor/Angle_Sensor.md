[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Angle_Sensor](#)
# Angle_Sensor

**Display name:** Angle Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Angle_Sensor;1

---

## Child interfaces
* [Solar_Azimuth_Angle_Sensor](Solar_Azimuth_Angle_Sensor.md)
* [Solar_Zenith_Angle_Sensor](Solar_Zenith_Angle_Sensor.md)

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
