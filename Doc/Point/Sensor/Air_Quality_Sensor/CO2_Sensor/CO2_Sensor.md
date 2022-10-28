[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Air_Quality_Sensor](../Air_Quality_Sensor.md) > [CO2_Sensor](#)
# CO2_Sensor

Measures properties of CO2 in air


**Display name:** CO2 Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:CO2_Sensor;1

---

## Child interfaces
* [CO2_Differential_Sensor](CO2_Differential_Sensor.md)
* [CO2_Level_Sensor](CO2_Level_Sensor.md)
* [Outside_Air_CO2_Sensor](Outside_Air_CO2_Sensor.md)
* [Return_Air_CO2_Sensor](Return_Air_CO2_Sensor.md)

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
