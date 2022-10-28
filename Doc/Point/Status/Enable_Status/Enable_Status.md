[Index](../../../index.md) > [Point](../../Point.md) > [Status](../Status.md) > [Enable_Status](#)
# Enable_Status

**Display name:** Enable Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Enable_Status;1

---

## Child interfaces
* [Heat_Exchanger_System_Enable_Status](../System_Status/Heat_Exchanger_System_Enable_Status.md)

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
