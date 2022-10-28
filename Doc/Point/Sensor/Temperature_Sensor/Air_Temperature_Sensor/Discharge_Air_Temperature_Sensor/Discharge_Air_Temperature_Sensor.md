[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Air_Temperature_Sensor](../Air_Temperature_Sensor.md) > [Discharge_Air_Temperature_Sensor](#)
# Discharge_Air_Temperature_Sensor

Measures the temperature of discharge air


**Display name:** Discharge Air Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Sensor;1

---

## Child interfaces
* [Preheat_Discharge_Air_Temperature_Sensor](Preheat_Discharge_Air_Temperature_Sensor.md)

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
