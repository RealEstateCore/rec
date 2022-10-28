[Index](../../../index.md) > [Point](../../Point.md) > [Status](../Status.md) > [Overridden_Status](#)
# Overridden_Status

Indicates if the expected operating status of an equipment or control loop has been overridden


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
* **[Status](../Status.md):** lastKnownValue
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
