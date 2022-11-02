[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Air_Quality_Sensor](../../Air_Quality_Sensor.md) > [Particulate_Matter_Sensor](../Particulate_Matter_Sensor.md) > [PM1_Sensor](#)
# PM1_Sensor

Detects matter of size 1 micron


**Display name:** PM1 Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:PM1_Sensor;1

---

## Child interfaces
* [PM1_Level_Sensor](PM1_Level_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Air_Quality_Sensor](../../Air_Quality_Sensor.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
