[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Water_Temperature_Sensor](../Water_Temperature_Sensor.md) > [Condenser_Water_Temperature_Sensor](Condenser_Water_Temperature_Sensor.md) > [Leaving_Condenser_Water_Temperature_Sensor](#)
# Leaving_Condenser_Water_Temperature_Sensor

Measures the temperature of the leaving condenser water


**Display name:** Leaving Condenser Water Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Condenser_Water_Temperature_Sensor;1

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
