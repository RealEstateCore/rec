[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Enthalpy_Sensor](../Enthalpy_Sensor.md) > [Air_Enthalpy_Sensor](#)
# Air_Enthalpy_Sensor

Measures the total heat content of air


**Display name:** Air Enthalpy Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Enthalpy_Sensor;1

---

## Child interfaces
* [Outside_Air_Enthalpy_Sensor](Outside_Air_Enthalpy_Sensor.md)
* [Return_Air_Enthalpy_Sensor](Return_Air_Enthalpy_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Enthalpy_Sensor](../Enthalpy_Sensor.md):** lastKnownValue
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
