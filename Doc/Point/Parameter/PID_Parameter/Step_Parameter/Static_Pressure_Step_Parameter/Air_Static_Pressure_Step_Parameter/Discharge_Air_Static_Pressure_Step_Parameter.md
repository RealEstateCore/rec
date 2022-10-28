[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Parameter](../../../../Parameter.md) > [PID_Parameter](../../../PID_Parameter.md) > [Step_Parameter](../../Step_Parameter.md) > [Static_Pressure_Step_Parameter](../Static_Pressure_Step_Parameter.md) > [Air_Static_Pressure_Step_Parameter](Air_Static_Pressure_Step_Parameter.md) > [Discharge_Air_Static_Pressure_Step_Parameter](#)
# Discharge_Air_Static_Pressure_Step_Parameter

**Display name:** Discharge Air Static Pressure Step Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Static_Pressure_Step_Parameter;1

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
