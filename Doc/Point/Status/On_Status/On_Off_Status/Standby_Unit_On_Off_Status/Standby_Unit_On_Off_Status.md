[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Status](../../../Status.md) > [On_Status](../../On_Status.md) > [On_Off_Status](../On_Off_Status.md) > [Standby_Unit_On_Off_Status](#)
# Standby_Unit_On_Off_Status

**Display name:** Standby Unit On Off Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Standby_Unit_On_Off_Status;1

---

## Child interfaces
* [Standby_Glycool_Unit_On_Off_Status](Standby_Glycool_Unit_On_Off_Status.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
