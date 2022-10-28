[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Status](../../../../Status.md) > [On_Status](../../../On_Status.md) > [On_Off_Status](../../On_Off_Status.md) > [Start_Stop_Status](../Start_Stop_Status.md) > [Run_Status](Run_Status.md) > [Run_Request_Status](#)
# Run_Request_Status

**Display name:** Run Request Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Run_Request_Status;1

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Status](../../../../Status.md):** lastKnownValue
* **[Point](../../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../../Space/Architecture/Architecture.md).hasPoint
