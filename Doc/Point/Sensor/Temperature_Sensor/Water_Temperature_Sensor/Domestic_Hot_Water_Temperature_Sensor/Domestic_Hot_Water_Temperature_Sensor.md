[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Water_Temperature_Sensor](../Water_Temperature_Sensor.md) > [Domestic_Hot_Water_Temperature_Sensor](#)
# Domestic_Hot_Water_Temperature_Sensor

**Display name:** Domestic Hot Water Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Domestic_Hot_Water_Temperature_Sensor;1

---

## Child interfaces
* [Entering_Domestic_Hot_Water_Temperature_Sensor](../Entering_Hot_Water_Temperature_Sensor/Entering_Domestic_Hot_Water_Temperature_Sensor.md)
* [Leaving_Domestic_Hot_Water_Temperature_Sensor](../Leaving_Hot_Water_Temperature_Sensor/Leaving_Domestic_Hot_Water_Temperature_Sensor.md)

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
