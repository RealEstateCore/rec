[Index](../../../Index.md) > [Point](../../Point.md) > [Status](../Status.md) > [Fault_Status](#)
# Fault_Status

**Display name:** Fault Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Fault_Status;1

---

## Child interfaces
* [Humidifier_Fault_Status](Humidifier_Fault_Status.md)
* [Last_Fault_Code_Status](Last_Fault_Code_Status.md)

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
