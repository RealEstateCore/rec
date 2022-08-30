[Index](../../../Index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Air_Quality_Sensor](#)
# Air_Quality_Sensor

**Display name:** Air Quality Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Quality_Sensor;1

---

## Child interfaces
* [Ammonia_Sensor](Ammonia_Sensor.md)
* [Formaldehyde_Level_Sensor](Formaldehyde_Level_Sensor.md)
* [Methane_Level_Sensor](Methane_Level_Sensor.md)
* [NO2_Level_Sensor](NO2_Level_Sensor.md)
* [Ozone_Level_Sensor](Ozone_Level_Sensor.md)
* [CO2_Sensor](CO2_Sensor/CO2_Sensor.md)
* [CO_Sensor](CO_Sensor/CO_Sensor.md)
* [Particulate_Matter_Sensor](Particulate_Matter_Sensor/Particulate_Matter_Sensor.md)
* [Radioactivity_Concentration_Sensor](Radioactivity_Concentration_Sensor/Radioactivity_Concentration_Sensor.md)

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
