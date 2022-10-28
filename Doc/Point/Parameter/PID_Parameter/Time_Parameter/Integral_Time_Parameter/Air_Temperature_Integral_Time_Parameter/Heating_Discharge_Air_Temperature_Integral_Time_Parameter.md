[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Parameter](../../../../Parameter.md) > [PID_Parameter](../../../PID_Parameter.md) > [Time_Parameter](../../Time_Parameter.md) > [Integral_Time_Parameter](../Integral_Time_Parameter.md) > [Air_Temperature_Integral_Time_Parameter](Air_Temperature_Integral_Time_Parameter.md) > [Heating_Discharge_Air_Temperature_Integral_Time_Parameter](#)
# Heating_Discharge_Air_Temperature_Integral_Time_Parameter

**Display name:** Heating Discharge Air Temperature Integral Time Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heating_Discharge_Air_Temperature_Integral_Time_Parameter;1

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
* **[Parameter](../../../../Parameter.md):** lastKnownValue
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
