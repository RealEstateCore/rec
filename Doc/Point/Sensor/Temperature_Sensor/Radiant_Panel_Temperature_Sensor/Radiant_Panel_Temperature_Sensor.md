[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Temperature_Sensor](../Temperature_Sensor.md) > [Radiant_Panel_Temperature_Sensor](#)
# Radiant_Panel_Temperature_Sensor

Measures the temperature of the radiant panel of the radiant heating and cooling HVAC system.


**Display name:** Radiant Panel Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Radiant_Panel_Temperature_Sensor;1

---

## Child interfaces
* [Inside_Face_Surface_Temperature_Sensor](Inside_Face_Surface_Temperature_Sensor.md)
* [Outside_Face_Surface_Temperature_Sensor](Outside_Face_Surface_Temperature_Sensor.md)
* [Embedded_Temperature_Sensor](Embedded_Temperature_Sensor/Embedded_Temperature_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Temperature_Sensor](../Temperature_Sensor.md):** lastKnownValue
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
