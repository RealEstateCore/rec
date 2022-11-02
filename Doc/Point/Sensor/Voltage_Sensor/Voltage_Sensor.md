[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Voltage_Sensor](#)
# Voltage_Sensor

Measures the voltage of an electrical device or object


**Display name:** Voltage Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Voltage_Sensor;1

---

## Child interfaces
* [DC_Bus_Voltage_Sensor](DC_Bus_Voltage_Sensor.md)
* [Battery_Voltage_Sensor](Battery_Voltage_Sensor.md)
* [Output_Voltage_Sensor](Output_Voltage_Sensor.md)

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
