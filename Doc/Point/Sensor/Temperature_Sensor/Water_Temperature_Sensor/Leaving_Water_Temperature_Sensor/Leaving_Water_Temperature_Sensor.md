[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Water_Temperature_Sensor](../Water_Temperature_Sensor.md) > [Leaving_Water_Temperature_Sensor](#)
# Leaving_Water_Temperature_Sensor

Measures the temperature of water leaving a piece of equipment or system


**Display name:** Leaving Water Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Water_Temperature_Sensor;1

---

## Child interfaces
* [Heat_Exchanger_Leaving_Water_Temperature_Sensor](Heat_Exchanger_Leaving_Water_Temperature_Sensor.md)
* [Ice_Tank_Leaving_Water_Temperature_Sensor](Ice_Tank_Leaving_Water_Temperature_Sensor.md)

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
