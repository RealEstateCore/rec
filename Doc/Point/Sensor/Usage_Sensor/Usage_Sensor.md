[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Usage_Sensor](#)
# Usage_Sensor

**Display name:** Usage Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Usage_Sensor;1

---

## Child interfaces
* [Energy_Usage_Sensor](Energy_Usage_Sensor.md)
* [Natural_Gas_Usage_Sensor](Natural_Gas_Usage_Sensor.md)
* [Steam_Usage_Sensor](Steam_Usage_Sensor.md)
* [Water_Usage_Sensor](Water_Usage_Sensor/Water_Usage_Sensor.md)

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
