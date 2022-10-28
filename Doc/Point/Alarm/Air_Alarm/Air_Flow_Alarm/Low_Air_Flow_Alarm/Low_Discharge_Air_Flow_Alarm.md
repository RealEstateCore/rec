[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Alarm](../../../Alarm.md) > [Air_Alarm](../../Air_Alarm.md) > [Air_Flow_Alarm](../Air_Flow_Alarm.md) > [Low_Air_Flow_Alarm](Low_Air_Flow_Alarm.md) > [Low_Discharge_Air_Flow_Alarm](#)
# Low_Discharge_Air_Flow_Alarm

**Display name:** Low Discharge Air Flow Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Low_Discharge_Air_Flow_Alarm;1

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|map (string->boolean)|False|
### Inherited Properties
* **[Alarm](../../../Alarm.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

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
