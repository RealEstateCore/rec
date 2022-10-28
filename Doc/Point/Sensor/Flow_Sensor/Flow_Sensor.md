[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Flow_Sensor](#)
# Flow_Sensor

Measures the rate of flow of some substance


**Display name:** Flow Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Flow_Sensor;1

---

## Child interfaces
* [Natural_Gas_Flow_Sensor](Natural_Gas_Flow_Sensor.md)
* [Air_Flow_Sensor](Air_Flow_Sensor/Air_Flow_Sensor.md)
* [Water_Flow_Sensor](Water_Flow_Sensor/Water_Flow_Sensor.md)

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
