[Index](../../../../Index.md) > [Point](../../../Point.md) > [Status](../../Status.md) > [Load_Shed_Status](../Load_Shed_Status.md) > [Entering_Hot_Water_Temperature_Load_Shed_Status](Entering_Hot_Water_Temperature_Load_Shed_Status.md) > [Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Status](#)
# Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Status

**Display name:** Entering Medium Temperature Hot Water Temperature Load Shed Stat<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Status;1

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
