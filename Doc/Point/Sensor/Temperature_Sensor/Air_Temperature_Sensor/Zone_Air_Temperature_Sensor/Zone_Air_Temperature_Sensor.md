[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Air_Temperature_Sensor](../Air_Temperature_Sensor.md) > [Zone_Air_Temperature_Sensor](#)
# Zone_Air_Temperature_Sensor

**Display name:** Zone Air Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Zone_Air_Temperature_Sensor;1

---

## Child interfaces
* [Average_Zone_Air_Temperature_Sensor](Average_Zone_Air_Temperature_Sensor.md)
* [Coldest_Zone_Air_Temperature_Sensor](Coldest_Zone_Air_Temperature_Sensor.md)
* [Warmest_Zone_Air_Temperature_Sensor](Warmest_Zone_Air_Temperature_Sensor.md)

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
