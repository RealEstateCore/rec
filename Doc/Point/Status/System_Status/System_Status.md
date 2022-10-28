[Index](../../../index.md) > [Point](../../Point.md) > [Status](../Status.md) > [System_Status](#)
# System_Status

**Display name:** System Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:System_Status;1

---

## Child interfaces
* [Heat_Exchanger_System_Enable_Status](Heat_Exchanger_System_Enable_Status.md)
* [Emergency_Air_Flow_System_Status](Emergency_Air_Flow_System_Status.md)
* [System_Shutdown_Status](System_Shutdown_Status.md)
* [Emergency_Power_Off_System_Status](Emergency_Power_Off_System_Status/Emergency_Power_Off_System_Status.md)

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
