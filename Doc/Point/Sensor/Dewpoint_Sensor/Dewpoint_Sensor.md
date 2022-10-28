[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Dewpoint_Sensor](#)
# Dewpoint_Sensor

**Display name:** Dewpoint Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Dewpoint_Sensor;1

---

## Child interfaces
* [Discharge_Air_Dewpoint_Sensor](Discharge_Air_Dewpoint_Sensor.md)
* [Exhaust_Air_Dewpoint_Sensor](Exhaust_Air_Dewpoint_Sensor.md)
* [Outside_Air_Dewpoint_Sensor](Outside_Air_Dewpoint_Sensor.md)
* [Return_Air_Dewpoint_Sensor](Return_Air_Dewpoint_Sensor.md)
* [Supply_Air_Dewpoint_Sensor](Supply_Air_Dewpoint_Sensor.md)
* [Zone_Air_Dewpoint_Sensor](Zone_Air_Dewpoint_Sensor.md)

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
