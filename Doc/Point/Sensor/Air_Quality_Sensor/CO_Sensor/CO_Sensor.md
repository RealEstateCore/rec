[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Air_Quality_Sensor](../Air_Quality_Sensor.md) > [CO_Sensor](#)
# CO_Sensor

Measures properties of CO


**Display name:** CO Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:CO_Sensor;1

---

## Child interfaces
* [CO_Differential_Sensor](CO_Differential_Sensor.md)
* [CO_Level_Sensor](CO_Level_Sensor.md)
* [Outside_Air_CO_Sensor](Outside_Air_CO_Sensor.md)
* [Return_Air_CO_Sensor](Return_Air_CO_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Air_Quality_Sensor](../Air_Quality_Sensor.md):** lastKnownValue
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
