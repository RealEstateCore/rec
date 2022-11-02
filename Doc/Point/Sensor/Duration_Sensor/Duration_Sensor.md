[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Duration_Sensor](#)
# Duration_Sensor

Measures the duration of a phenomenon or event


**Display name:** Duration Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Duration_Sensor;1

---

## Child interfaces
* [Rain_Duration_Sensor](Rain_Duration_Sensor.md)
* [On_Timer_Sensor](On_Timer_Sensor.md)
* [Run_Time_Sensor](Run_Time_Sensor.md)

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
