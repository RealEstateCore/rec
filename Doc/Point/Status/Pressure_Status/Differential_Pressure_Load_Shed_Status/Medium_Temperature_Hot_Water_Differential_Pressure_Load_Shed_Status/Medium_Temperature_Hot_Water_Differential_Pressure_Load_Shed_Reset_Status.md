[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Status](../../../Status.md) > [Pressure_Status](../../Pressure_Status.md) > [Differential_Pressure_Load_Shed_Status](../Differential_Pressure_Load_Shed_Status.md) > [Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Status](Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Status.md) > [Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Reset_Status](#)
# Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Reset_Status

**Display name:** Medium Temperature Hot Water Differential Pressure Load Shed Res<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Reset_Status;1

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
* **[Status](../../../Status.md):** lastKnownValue
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
