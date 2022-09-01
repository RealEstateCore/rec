[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Status](../../../Status.md) > [Pressure_Status](../../Pressure_Status.md) > [Differential_Pressure_Load_Shed_Status](../Differential_Pressure_Load_Shed_Status.md) > [Hot_Water_Differential_Pressure_Load_Shed_Status](Hot_Water_Differential_Pressure_Load_Shed_Status.md) > [Hot_Water_Differential_Pressure_Load_Shed_Reset_Status](#)
# Hot_Water_Differential_Pressure_Load_Shed_Reset_Status

**Display name:** Hot Water Differential Pressure Load Shed Reset Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Hot_Water_Differential_Pressure_Load_Shed_Reset_Status;1

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
