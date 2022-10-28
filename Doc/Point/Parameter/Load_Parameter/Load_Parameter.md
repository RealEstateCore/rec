[Index](../../../index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Load_Parameter](#)
# Load_Parameter

**Display name:** Load Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Parameter;1

---

## Child interfaces
* [Max_Load_Setpoint](Max_Load_Setpoint.md)
* [Min_Load_Setpoint](Min_Load_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../Parameter.md):** lastKnownValue
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
