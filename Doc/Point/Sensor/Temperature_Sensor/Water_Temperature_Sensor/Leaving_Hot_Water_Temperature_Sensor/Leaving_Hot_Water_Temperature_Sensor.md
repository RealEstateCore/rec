[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Water_Temperature_Sensor](../Water_Temperature_Sensor.md) > [Leaving_Hot_Water_Temperature_Sensor](#)
# Leaving_Hot_Water_Temperature_Sensor

**Display name:** Leaving Hot Water Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Hot_Water_Temperature_Sensor;1

---

## Child interfaces
* [Leaving_Domestic_Hot_Water_Temperature_Sensor](Leaving_Domestic_Hot_Water_Temperature_Sensor.md)
* [Hot_Water_Differential_Temperature_Sensor](Hot_Water_Differential_Temperature_Sensor.md)
* [Leaving_High_Temperature_Hot_Water_Temperature_Sensor](Leaving_High_Temperature_Hot_Water_Temperature_Sensor.md)
* [Leaving_Medium_Temperature_Hot_Water_Temperature_Sensor](Leaving_Medium_Temperature_Hot_Water_Temperature_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

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
