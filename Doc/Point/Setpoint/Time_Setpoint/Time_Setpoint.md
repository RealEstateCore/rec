[Index](../../../index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Time_Setpoint](#)
# Time_Setpoint

**Display name:** Time Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Time_Setpoint;1

---

## Child interfaces
* [Acceleration_Time_Setpoint](Acceleration_Time_Setpoint.md)
* [Deceleration_Time_Setpoint](Deceleration_Time_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../Setpoint.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

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
