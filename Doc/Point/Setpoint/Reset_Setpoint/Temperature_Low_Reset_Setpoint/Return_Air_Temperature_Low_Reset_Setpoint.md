[Index](../../../../Index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Reset_Setpoint](../Reset_Setpoint.md) > [Temperature_Low_Reset_Setpoint](Temperature_Low_Reset_Setpoint.md) > [Return_Air_Temperature_Low_Reset_Setpoint](#)
# Return_Air_Temperature_Low_Reset_Setpoint

**Display name:** Return Air Temperature Low Reset Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Return_Air_Temperature_Low_Reset_Setpoint;1

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

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
