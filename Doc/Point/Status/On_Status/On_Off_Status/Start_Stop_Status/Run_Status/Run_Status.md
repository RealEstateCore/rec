[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Status](../../../../Status.md) > [On_Status](../../../On_Status.md) > [On_Off_Status](../../On_Off_Status.md) > [Start_Stop_Status](../Start_Stop_Status.md) > [Run_Status](#)
# Run_Status

**Display name:** Run Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Run_Status;1

---

## Child interfaces
* [Run_Request_Status](Run_Request_Status.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Status](../../../../Status.md):** lastKnownValue
* **[Point](../../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
