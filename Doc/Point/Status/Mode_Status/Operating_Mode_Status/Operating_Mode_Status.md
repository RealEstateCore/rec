[Index](../../../../index.md) > [Point](../../../Point.md) > [Status](../../Status.md) > [Mode_Status](../Mode_Status.md) > [Operating_Mode_Status](#)
# Operating_Mode_Status

**Display name:** Operating Mode Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Operating_Mode_Status;1

---

## Child interfaces
* [Vent_Operating_Mode_Status](Vent_Operating_Mode_Status.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Status](../../Status.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
