[Index](../../../index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Delay_Parameter](#)
# Delay_Parameter

A parameter determining how long to delay a subsequent action to take place after a received signal


**Display name:** Delay Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Delay_Parameter;1

---

## Child interfaces
* [Alarm_Delay_Parameter](Alarm_Delay_Parameter.md)

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
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
