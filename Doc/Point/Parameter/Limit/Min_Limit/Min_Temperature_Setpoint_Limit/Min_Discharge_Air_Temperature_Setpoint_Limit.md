[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Limit](../../Limit.md) > [Min_Limit](../Min_Limit.md) > [Min_Temperature_Setpoint_Limit](Min_Temperature_Setpoint_Limit.md) > [Min_Discharge_Air_Temperature_Setpoint_Limit](#)
# Min_Discharge_Air_Temperature_Setpoint_Limit

**Display name:** Min Discharge Air Temperature Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Min_Discharge_Air_Temperature_Setpoint_Limit;1

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
