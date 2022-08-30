[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Differential_Setpoint](../../Differential_Setpoint.md) > [Temperature_Differential_Reset_Setpoint](../Temperature_Differential_Reset_Setpoint.md) > [Discharge_Air_Temperature_Reset_Differential_Setpoint](Discharge_Air_Temperature_Reset_Differential_Setpoint.md) > [Discharge_Air_Temperature_Low_Reset_Setpoint](#)
# Discharge_Air_Temperature_Low_Reset_Setpoint

**Display name:** Discharge Air Temperature Low Reset Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Low_Reset_Setpoint;1

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
