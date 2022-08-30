[Index](../../../Index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Temperature_Sensor](#)
# Temperature_Sensor

**Display name:** Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_Sensor;1

---

## Child interfaces
* [Frost_Sensor](Frost_Sensor.md)
* [Heat_Sink_Temperature_Sensor](Heat_Sink_Temperature_Sensor.md)
* [Natural_Gas_Temperature_Sensor](Natural_Gas_Temperature_Sensor.md)
* [Soil_Temperature_Sensor](Soil_Temperature_Sensor.md)
* [Air_Temperature_Sensor](Air_Temperature_Sensor/Air_Temperature_Sensor.md)
* [Radiant_Panel_Temperature_Sensor](Radiant_Panel_Temperature_Sensor/Radiant_Panel_Temperature_Sensor.md)
* [Water_Temperature_Sensor](Water_Temperature_Sensor/Water_Temperature_Sensor.md)
* [Air_Wet_Bulb_Temperature_Sensor](Air_Temperature_Sensor/Air_Wet_Bulb_Temperature_Sensor/Air_Wet_Bulb_Temperature_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
