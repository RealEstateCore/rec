[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Status](../../../Status.md) > [On_Status](../../On_Status.md) > [On_Off_Status](../On_Off_Status.md) > [Start_Stop_Status](#)
# Start_Stop_Status

Indicates the active/inactive status of a control loop (but not equipment activities or relays -- use On/Off for this purpose)


**Display name:** Start Stop Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Start_Stop_Status;1

---

## Child interfaces
* [Cooling_Start_Stop_Status](Cooling_Start_Stop_Status.md)
* [Heating_Start_Stop_Status](Heating_Start_Stop_Status.md)
* [Humidification_Start_Stop_Status](Humidification_Start_Stop_Status.md)
* [Dehumidification_Start_Stop_Status](Dehumidification_Start_Stop_Status.md)
* [EconCycle_Start_Stop_Status](EconCycle_Start_Stop_Status.md)
* [Run_Status](Run_Status/Run_Status.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Status](../../../Status.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
