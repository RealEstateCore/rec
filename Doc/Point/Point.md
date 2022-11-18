[Index](../index.md) > [Point](#)
# Point

**Display name:** Point<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Point;1

---

## Child interfaces
* [Alarm](Alarm/Alarm.md)
* [Command](Command/Command.md)
* [Parameter](Parameter/Parameter.md)
* [Sensor](Sensor/Sensor.md)
* [Setpoint](Setpoint/Setpoint.md)
* [Status](Status/Status.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|isPointOf|**en**: is point of||0-Infinity|||True|

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|aggregate|**en**: Aggregate||Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
|customProperties|**en**: Custom Properties||map (string->map (string->string))|True|
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|hasQuantity|**en**: has quantity||enum (Absolute_Humidity, Acceleration_Time, Active_Energy, Active_Power, Air_Quality, Alternating_Current_Frequency, Ammonia_Concentration, Angle, Apparent_Energy, Apparent_Power, Atmospheric_Pressure, CO2_Concentration, CO_Concentration, Capacity, Cloudage, Complex_Power, Conductivity, Current_Angle, Current_Imbalance, Current_Total_Harmonic_Distortion, Deceleration_Time, Dewpoint, Differential_CO2_Concentration, Differential_CO_Concentration, Differential_Dry_Bulb_Temperature, Differential_Dynamic_Pressure, Differential_Pressure, Differential_Static_Pressure, Differential_Temperature, Direction, Dry_Bulb_Temperature, Dynamic_Pressure, Electric_Current, Electric_Energy, Electric_Power, Energy, Enthalpy, Flow, Flow_Loss, Formaldehyde_Concentration, Frequency, GrainsOfMoisture, Humidity, Illuminance, Irradiance, Level, Linear_Speed, Luminance, Luminous_Flux, Luminous_Intensity, Mass, Methane_Concentration, NO2_Concentration, Occupancy, Occupancy_Count, Occupancy_Percentage, Operative_Temperature, Ozone_Concentration, PM10_Concentration, PM1_Concentration, PM2_5_Concentration, Peak_Power, Phasor, Phasor_Angle, Phasor_Magnitude, Position, Power, Power_Factor, Precipitation, Pressure, Radiance, Radiant_Temperature, Radioactivity_Concentration, Radon_Concentration, Reactive_Energy, Reactive_Power, Real_Power, Relative_Humidity, Rotational_Speed, Solar_Irradiance, Solar_Radiance, Speed, Static_Pressure, TVOC_Concentration, Temperature, Thermal_Energy, Thermal_Power, Time, Torque, Velocity_Pressure, Voltage, Voltage_Angle, Voltage_Imbalance, Weather_Condition, Wet_Bulb_Temperature, Wind_Direction)|True|
|hasSubstance|**en**: has substance||enum (Air, Blowdown_Water, Building_Air, Bypass_Air, Bypass_Water, CO, CO2, Chilled_Water, Collection_Basin_Water, Condenser_Water, Deionized_Water, Discharge_Air, Domestic_Water, Entering_Chilled_Water, Entering_Condenser_Water, Entering_Hot_Water, Entering_Water, Exhaust_Air, Fluid, Frost, Fuel_Oil, Gas, Gasoline, Glycol, Hail, Hot_Water, Ice, Leaving_Chilled_Water, Leaving_Condenser_Water, Leaving_Hot_Water, Leaving_Water, Liquid, Liquid_CO2, Makeup_Water, Mixed_Air, Natural_Gas, Oil, Outside_Air, Potable_Water, Refrigerant, Return_Air, Soil, Solid, Steam, Supply_Air, Water, Zone_Air)|True|
|identifiers|**en**: Identifiers||map (string->string)|True|
|name|**en**: name||string|True|

---

## Target Of
### General
* [Point](#).isPointOf
* [Agent](../Agent/Agent.md).owns
* [Space](../Space/Space.md).isLocationOf
* [Equipment](../Asset/Equipment/Equipment.md).feeds
* [Equipment](../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../Space/Architecture/Architecture.md).isFedBy
* [Document](../Information/Document/Document.md).documentTopic
* [Document](../Information/Document/Document.md).url
* [EquipmentCollection](../Collection/Equipment-.md).feeds
* [Lease](../Event/Lease.md).leaseOf
* [PointOfInterest](../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../Collection/Portfolio.md).includes
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../Asset/Equipment/Meter/Meter.md).meters
### Direct
* [ActuationEvent](../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../Space/Architecture/Architecture.md).hasPoint
* [Asset](../Asset/Asset.md).hasPoint
* [EquipmentCollection](../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../Event/Point-/ObservationEvent.md).sourcePoint
* [ServiceObject](../Information/ServiceObject/ServiceObject.md).producedBy
