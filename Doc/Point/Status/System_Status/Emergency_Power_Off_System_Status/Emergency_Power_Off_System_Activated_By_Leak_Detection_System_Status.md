[Index](../../../../index.md) > [Point](../../../Point.md) > [Status](../../Status.md) > [System_Status](../System_Status.md) > [Emergency_Power_Off_System_Status](Emergency_Power_Off_System_Status.md) > [Emergency_Power_Off_System_Activated_By_Leak_Detection_System_Status](#)
# Emergency_Power_Off_System_Activated_By_Leak_Detection_System_Status

**Display name:** Emergency Power Off System Activated By Leak Detection System St<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Emergency_Power_Off_System_Activated_By_Leak_Detection_System_Status;1

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
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
