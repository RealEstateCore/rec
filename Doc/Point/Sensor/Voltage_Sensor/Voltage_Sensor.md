[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Voltage_Sensor](#)
# Voltage_Sensor

**Display name:** Voltage Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Voltage_Sensor;1

---

## Child interfaces
* [Battery_Voltage_Sensor](Battery_Voltage_Sensor.md)
* [DC_Bus_Voltage_Sensor](DC_Bus_Voltage_Sensor.md)
* [Output_Voltage_Sensor](Output_Voltage_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
