[Index](../../../index.md) > [Point](../../Point.md) > [Setpoint](../Setpoint.md) > [CO2_Setpoint](#)
# CO2_Setpoint

Sets some property of CO2


**Display name:** CO2 Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:CO2_Setpoint;1

---

## Child interfaces
* [Return_Air_CO2_Setpoint](Return_Air_CO2_Setpoint.md)

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
