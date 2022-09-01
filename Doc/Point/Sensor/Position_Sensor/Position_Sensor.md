[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Position_Sensor](#)
# Position_Sensor

**Display name:** Position Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Position_Sensor;1

---

## Child interfaces
* [Damper_Position_Sensor](Damper_Position_Sensor.md)
* [Sash_Position_Sensor](Sash_Position_Sensor.md)
* [Valve_Position_Sensor](Valve_Position_Sensor.md)

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
