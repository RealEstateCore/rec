[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Water_Temperature_Sensor](../Water_Temperature_Sensor.md) > [Entering_Hot_Water_Temperature_Sensor](#)
# Entering_Hot_Water_Temperature_Sensor

**Display name:** Entering Hot Water Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Entering_Hot_Water_Temperature_Sensor;1

---

## Child interfaces
* [Entering_Domestic_Hot_Water_Temperature_Sensor](Entering_Domestic_Hot_Water_Temperature_Sensor.md)
* [Entering_High_Temperature_Hot_Water_Temperature_Sensor](Entering_High_Temperature_Hot_Water_Temperature_Sensor.md)
* [Entering_Medium_Temperature_Hot_Water_Temperature_Sensor](Entering_Medium_Temperature_Hot_Water_Temperature_Sensor.md)
* [Hot_Water_Differential_Temperature_Sensor](../Leaving_Hot_Water_Temperature_Sensor/Hot_Water_Differential_Temperature_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Temperature_Sensor](../../Temperature_Sensor.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
