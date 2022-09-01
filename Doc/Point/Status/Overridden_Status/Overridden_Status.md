[Index](../../../index.md) > [Point](../../Point.md) > [Status](../Status.md) > [Overridden_Status](#)
# Overridden_Status

**Display name:** Overridden Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Overridden_Status;1

---

## Child interfaces
* [Overridden_Off_Status](Overridden_Off_Status.md)
* [Overridden_On_Status](Overridden_On_Status.md)

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
