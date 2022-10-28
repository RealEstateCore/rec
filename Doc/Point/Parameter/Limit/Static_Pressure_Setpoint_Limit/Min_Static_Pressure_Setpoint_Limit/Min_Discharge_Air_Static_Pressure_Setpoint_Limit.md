[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Limit](../../Limit.md) > [Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit.md) > [Min_Static_Pressure_Setpoint_Limit](Min_Static_Pressure_Setpoint_Limit.md) > [Min_Discharge_Air_Static_Pressure_Setpoint_Limit](#)
# Min_Discharge_Air_Static_Pressure_Setpoint_Limit

**Display name:** Min Discharge Air Static Pressure Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Min_Discharge_Air_Static_Pressure_Setpoint_Limit;1

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
* **[Parameter](../../../Parameter.md):** lastKnownValue
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
