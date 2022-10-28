[Index](../../../../index.md) > [Point](../../../Point.md) > [Status](../../Status.md) > [Mode_Status](../Mode_Status.md) > [Unoccupied_Mode_Status](Unoccupied_Mode_Status.md) > [Unoccupied_Heating_Mode_Status](#)
# Unoccupied_Heating_Mode_Status

Indicates whether a system, device or control loop is in an unoccupied heating mode


**Display name:** Unoccupied Heating Mode Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Unoccupied_Heating_Mode_Status;1

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
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
