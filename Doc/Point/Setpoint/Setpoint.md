[Index](../../index.md) > [Point](../Point.md) > [Setpoint](#)
# Setpoint

**Display name:** Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Setpoint;1

---

## Child interfaces
* [Current_Ratio_Setpoint](Current_Ratio_Setpoint.md)
* [Damper_Position_Setpoint](Damper_Position_Setpoint.md)
* [Dewpoint_Setpoint](Dewpoint_Setpoint.md)
* [Enthalpy_Setpoint](Enthalpy_Setpoint.md)
* [Frequency_Setpoint](Frequency_Setpoint.md)
* [Illuminance_Setpoint](Illuminance_Setpoint.md)
* [Luminance_Setpoint](Luminance_Setpoint.md)
* [Voltage_Ratio_Setpoint](Voltage_Ratio_Setpoint.md)
* [CO2_Setpoint](CO2_Setpoint/CO2_Setpoint.md)
* [Deadband_Setpoint](Deadband_Setpoint/Deadband_Setpoint.md)
* [Demand_Setpoint](Demand_Setpoint/Demand_Setpoint.md)
* [Differential_Setpoint](Differential_Setpoint/Differential_Setpoint.md)
* [Flow_Setpoint](Flow_Setpoint/Flow_Setpoint.md)
* [Humidity_Setpoint](Humidity_Setpoint/Humidity_Setpoint.md)
* [Load_Setpoint](Load_Setpoint/Load_Setpoint.md)
* [Pressure_Setpoint](Pressure_Setpoint/Pressure_Setpoint.md)
* [Reset_Setpoint](Reset_Setpoint/Reset_Setpoint.md)
* [Speed_Setpoint](Speed_Setpoint/Speed_Setpoint.md)
* [Temperature_Setpoint](Temperature_Setpoint/Temperature_Setpoint.md)
* [Time_Setpoint](Time_Setpoint/Time_Setpoint.md)

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
* [ActuationEvent](../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
