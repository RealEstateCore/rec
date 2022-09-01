[Index](../../../index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Flow_Setpoint](#)
# Flow_Setpoint

**Display name:** Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Flow_Setpoint;1

---

## Child interfaces
* [Air_Flow_Setpoint](Air_Flow_Setpoint/Air_Flow_Setpoint.md)
* [Water_Flow_Setpoint](Water_Flow_Setpoint/Water_Flow_Setpoint.md)

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
