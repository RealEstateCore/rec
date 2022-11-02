[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Flow_Sensor](../Flow_Sensor.md) > [Water_Flow_Sensor](#)
# Water_Flow_Sensor

Measures the rate of flow of water


**Display name:** Water Flow Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Flow_Sensor;1

---

## Child interfaces
* [Bypass_Water_Flow_Sensor](Bypass_Water_Flow_Sensor.md)
* [Chilled_Water_Flow_Sensor](Chilled_Water_Flow_Sensor/Chilled_Water_Flow_Sensor.md)
* [Hot_Water_Flow_Sensor](Hot_Water_Flow_Sensor/Hot_Water_Flow_Sensor.md)
* [Entering_Water_Flow_Sensor](Entering_Water_Flow_Sensor/Entering_Water_Flow_Sensor.md)
* [Leaving_Water_Flow_Sensor](Leaving_Water_Flow_Sensor/Leaving_Water_Flow_Sensor.md)
* [Condenser_Water_Flow_Sensor](Condenser_Water_Flow_Sensor/Condenser_Water_Flow_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Flow_Sensor](../Flow_Sensor.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
