[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Pressure_Sensor](../../Pressure_Sensor.md) > [Static_Pressure_Sensor](../Static_Pressure_Sensor.md) > [Exhaust_Air_Static_Pressure_Sensor](Exhaust_Air_Static_Pressure_Sensor.md) > [Lowest_Exhaust_Air_Static_Pressure_Sensor](#)
# Lowest_Exhaust_Air_Static_Pressure_Sensor

The lowest observed static pressure of air in exhaust regions of an HVAC system over some period of time


**Display name:** Lowest Exhaust Air Static Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Lowest_Exhaust_Air_Static_Pressure_Sensor;1

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Pressure_Sensor](../../Pressure_Sensor.md):** lastKnownValue
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
