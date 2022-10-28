[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Flow_Sensor](../../Flow_Sensor.md) > [Water_Flow_Sensor](../Water_Flow_Sensor.md) > [Chilled_Water_Flow_Sensor](#)
# Chilled_Water_Flow_Sensor

Measures the rate of flow in a chilled water circuit


**Display name:** Chilled Water Flow Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Chilled_Water_Flow_Sensor;1

---

## Child interfaces
* [Entering_Chilled_Water_Flow_Sensor](../Entering_Water_Flow_Sensor/Entering_Chilled_Water_Flow_Sensor.md)
* [Leaving_Chilled_Water_Flow_Sensor](../Leaving_Water_Flow_Sensor/Leaving_Chilled_Water_Flow_Sensor.md)

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
