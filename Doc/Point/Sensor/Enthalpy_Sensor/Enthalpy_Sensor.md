[Index](../../../Index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Enthalpy_Sensor](#)
# Enthalpy_Sensor

**Display name:** Enthalpy Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Enthalpy_Sensor;1

---

## Child interfaces
* [Air_Enthalpy_Sensor](Air_Enthalpy_Sensor/Air_Enthalpy_Sensor.md)

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
