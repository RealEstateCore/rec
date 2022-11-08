[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Flow_Setpoint](../Flow_Setpoint.md) > [Water_Flow_Setpoint](#)
# Water_Flow_Setpoint

Sets the target flow rate of water


**Display name:** Water Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Flow_Setpoint;1

---

## Child interfaces
* [Condenser_Water_Flow_Setpoint](Condenser_Water_Flow_Setpoint.md)
* [Bypass_Water_Flow_Setpoint](Bypass_Water_Flow_Setpoint.md)
* [Hot_Water_Flow_Setpoint](Hot_Water_Flow_Setpoint/Hot_Water_Flow_Setpoint.md)
* [Chilled_Water_Flow_Setpoint](Chilled_Water_Flow_Setpoint/Chilled_Water_Flow_Setpoint.md)
* [Leaving_Water_Flow_Setpoint](Leaving_Water_Flow_Setpoint/Leaving_Water_Flow_Setpoint.md)
* [Entering_Water_Flow_Setpoint](Entering_Water_Flow_Setpoint/Entering_Water_Flow_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../../Setpoint.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
