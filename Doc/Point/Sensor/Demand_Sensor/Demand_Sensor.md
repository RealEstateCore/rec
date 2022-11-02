[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Demand_Sensor](#)
# Demand_Sensor

Measures the amount of power consumed by the use of some process; typically found by multiplying the tonnage of a unit (e.g. RTU) by the efficiency rating in kW/ton


**Display name:** Demand Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Demand_Sensor;1

---

## Child interfaces
* [Peak_Demand_Sensor](Peak_Demand_Sensor.md)
* [Heating_Demand_Sensor](Heating_Demand_Sensor/Heating_Demand_Sensor.md)
* [Cooling_Demand_Sensor](Cooling_Demand_Sensor/Cooling_Demand_Sensor.md)

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
