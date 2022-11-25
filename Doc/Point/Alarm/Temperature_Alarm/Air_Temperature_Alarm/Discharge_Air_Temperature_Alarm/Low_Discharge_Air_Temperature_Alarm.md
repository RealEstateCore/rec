[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Alarm](../../../Alarm.md) > [Temperature_Alarm](../../Temperature_Alarm.md) > [Air_Temperature_Alarm](../Air_Temperature_Alarm.md) > [Discharge_Air_Temperature_Alarm](Discharge_Air_Temperature_Alarm.md) > [Low_Discharge_Air_Temperature_Alarm](#)
# Low_Discharge_Air_Temperature_Alarm

**Display name:** Low Discharge Air Temperature Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Low_Discharge_Air_Temperature_Alarm;1

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