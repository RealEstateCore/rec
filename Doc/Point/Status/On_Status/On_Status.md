[Index](../../../index.md) > [Point](../../Point.md) > [Status](../Status.md) > [On_Status](#)
# On_Status

Indicates if a control loop, relay or equipment is on


**Display name:** On Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:On_Status;1

---

## Child interfaces
* [Overridden_On_Status](../Overridden_Status/Overridden_On_Status.md)
* [On_Off_Status](On_Off_Status/On_Off_Status.md)

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
