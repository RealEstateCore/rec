[Index](../../../index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Flow_Setpoint](#)
# Flow_Setpoint

Sets flow


**Display name:** Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Flow_Setpoint;1

---

## Child interfaces
* [Water_Flow_Setpoint](Water_Flow_Setpoint/Water_Flow_Setpoint.md)
* [Air_Flow_Setpoint](Air_Flow_Setpoint/Air_Flow_Setpoint.md)

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
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
