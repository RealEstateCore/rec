[Index](../../index.md) > [Point](../Point.md) > [Alarm](#)
# Alarm

Alarm points are signals (either audible or visual) that alert an operator to an off-normal condition which requires some form of corrective action


**Display name:** Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Alarm;1

---

## Child interfaces
* [Liquid_Detection_Alarm](Liquid_Detection_Alarm.md)
* [Luminance_Alarm](Luminance_Alarm.md)
* [Maintenance_Required_Alarm](Maintenance_Required_Alarm.md)
* [Low_Battery_Alarm](Low_Battery_Alarm.md)
* [Valve_Position_Alarm](Valve_Position_Alarm.md)
* [Overload_Alarm](Overload_Alarm.md)
* [Change_Filter_Alarm](Change_Filter_Alarm.md)
* [Communication_Loss_Alarm](Communication_Loss_Alarm.md)
* [Cycle_Alarm](Cycle_Alarm/Cycle_Alarm.md)
* [Voltage_Alarm](Voltage_Alarm/Voltage_Alarm.md)
* [Pressure_Alarm](Pressure_Alarm/Pressure_Alarm.md)
* [Power_Alarm](Power_Alarm/Power_Alarm.md)
* [Emergency_Alarm](Emergency_Alarm/Emergency_Alarm.md)
* [Failure_Alarm](Failure_Alarm/Failure_Alarm.md)
* [Water_Alarm](Water_Alarm/Water_Alarm.md)
* [Air_Alarm](Air_Alarm/Air_Alarm.md)
* [CO2_Alarm](CO2_Alarm/CO2_Alarm.md)
* [Temperature_Alarm](Temperature_Alarm/Temperature_Alarm.md)
* [Humidity_Alarm](Humidity_Alarm/Humidity_Alarm.md)
* [Leak_Alarm](Leak_Alarm/Leak_Alarm.md)
* [Smoke_Alarm](Smoke_Alarm/Smoke_Alarm.md)

---

## Relationships

### Inherited Relationships
* **[Point](../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|lastKnownValue|**en**: last known value||Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
### Inherited Properties
* **[Point](../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../Event/PointEvent/ExceptionEvent.md).sourcePoint
