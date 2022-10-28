[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Demand_Sensor](../Demand_Sensor.md) > [Heating_Demand_Sensor](#)
# Heating_Demand_Sensor

Measures the amount of power consumed by a heating process; typically found by multiplying the tonnage of a unit (e.g. RTU) by the efficiency rating in kW/ton


**Display name:** Heating Demand Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heating_Demand_Sensor;1

---

## Child interfaces
* [Average_Heating_Demand_Sensor](Average_Heating_Demand_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Demand_Sensor](../Demand_Sensor.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
