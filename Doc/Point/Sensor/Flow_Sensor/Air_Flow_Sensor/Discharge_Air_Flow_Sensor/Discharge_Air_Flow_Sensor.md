[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Flow_Sensor](../../Flow_Sensor.md) > [Air_Flow_Sensor](../Air_Flow_Sensor.md) > [Discharge_Air_Flow_Sensor](#)
# Discharge_Air_Flow_Sensor

Measures the rate of flow of discharge air


**Display name:** Discharge Air Flow Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Flow_Sensor;1

---

## Child interfaces
* [Average_Discharge_Air_Flow_Sensor](Average_Discharge_Air_Flow_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Flow_Sensor](../../Flow_Sensor.md):** lastKnownValue
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
