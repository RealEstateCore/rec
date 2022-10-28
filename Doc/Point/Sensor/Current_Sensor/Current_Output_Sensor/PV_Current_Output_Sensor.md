[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Current_Sensor](../Current_Sensor.md) > [Current_Output_Sensor](Current_Output_Sensor.md) > [PV_Current_Output_Sensor](#)
# PV_Current_Output_Sensor

See Photovoltaic_Current_Output_Sensor


**Display name:** PV Current Output Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:PV_Current_Output_Sensor;1

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
* **[Current_Sensor](../Current_Sensor.md):** lastKnownValue
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
