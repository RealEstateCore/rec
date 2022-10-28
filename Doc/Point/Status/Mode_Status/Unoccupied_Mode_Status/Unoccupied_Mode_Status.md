[Index](../../../../index.md) > [Point](../../../Point.md) > [Status](../../Status.md) > [Mode_Status](../Mode_Status.md) > [Unoccupied_Mode_Status](#)
# Unoccupied_Mode_Status

**Display name:** Unoccupied Mode Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Unoccupied_Mode_Status;1

---

## Child interfaces
* [Unoccupied_Cooling_Mode_Status](Unoccupied_Cooling_Mode_Status.md)
* [Unoccupied_Heating_Mode_Status](Unoccupied_Heating_Mode_Status.md)

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
