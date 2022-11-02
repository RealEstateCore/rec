[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Imbalance_Sensor](#)
# Imbalance_Sensor

A sensor which measures difference (imbalance) between phases of an electrical system


**Display name:** Imbalance Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Imbalance_Sensor;1

---

## Child interfaces
* [Current_Imbalance_Sensor](Current_Imbalance_Sensor.md)
* [Voltage_Imbalance_Sensor](Voltage_Imbalance_Sensor.md)

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
