[Index](../../../index.md) > [Point](../../Point.md) > [Sensor](../Sensor.md) > [Water_Level_Sensor](#)
# Water_Level_Sensor

**Display name:** Water Level Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Level_Sensor;1

---

## Child interfaces
* [Collection_Basin_Water_Level_Sensor](Collection_Basin_Water_Level_Sensor.md)
* [Deionised_Water_Level_Sensor](Deionised_Water_Level_Sensor.md)

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
