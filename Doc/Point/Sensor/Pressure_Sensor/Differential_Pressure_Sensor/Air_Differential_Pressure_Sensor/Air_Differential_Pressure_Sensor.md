[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Pressure_Sensor](../../Pressure_Sensor.md) > [Differential_Pressure_Sensor](../Differential_Pressure_Sensor.md) > [Air_Differential_Pressure_Sensor](#)
# Air_Differential_Pressure_Sensor

**Display name:** Air Differential Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Differential_Pressure_Sensor;1

---

## Child interfaces
* [Discharge_Air_Differential_Pressure_Sensor](Discharge_Air_Differential_Pressure_Sensor.md)
* [Exhaust_Air_Differential_Pressure_Sensor](Exhaust_Air_Differential_Pressure_Sensor.md)
* [Return_Air_Differential_Pressure_Sensor](Return_Air_Differential_Pressure_Sensor.md)
* [Supply_Air_Differential_Pressure_Sensor](Supply_Air_Differential_Pressure_Sensor.md)

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
