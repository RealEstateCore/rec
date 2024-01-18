[Index](../../index.md) > [Point](../Point.md) > [Sensor](#)
# Sensor

A Sensor is an input point that represents the value of a device or instrument designed to detect and measure a variable (ASHRAE Dictionary).


**Display name:** Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Sensor;1

---

## Child interfaces
* [Adjust_Sensor](Adjust-/Adjust_Sensor.md)
* [Air_Grains_Sensor](Air_Grains-/Air_Grains_Sensor.md)
* [Air_Quality_Sensor](Air_Quality-/Air_Quality_Sensor.md)
* [Angle_Sensor](Angle-/Angle_Sensor.md)
* [Capacity_Sensor](Capacity-.md)
* [Conductivity_Sensor](Conductivity-/Conductivity_Sensor.md)
* [Contact_Sensor](Contact-.md)
* [Current_Sensor](Current-/Current_Sensor.md)
* [Demand_Sensor](Demand-/Demand_Sensor.md)
* [Dewpoint_Sensor](Dewpoint-/Dewpoint_Sensor.md)
* [Direction_Sensor](Direction-/Direction_Sensor.md)
* [Duration_Sensor](Duration-/Duration_Sensor.md)
* [Energy_Sensor](Energy-/Energy_Sensor.md)
* [Enthalpy_Sensor](Enthalpy-/Enthalpy_Sensor.md)
* [Fire_Sensor](Fire-.md)
* [Flow_Sensor](Flow-/Flow_Sensor.md)
* [Frequency_Sensor](Frequency-/Frequency_Sensor.md)
* [Frost_Sensor](Frost-.md)
* [Gas_Sensor](Gas-.md)
* [Generation_Sensor](Generation-/Generation_Sensor.md)
* [Hail_Sensor](Hail-.md)
* [Heat_Sensor](Heat-/Heat_Sensor.md)
* [Humidity_Sensor](Humidity-/Humidity_Sensor.md)
* [Illuminance_Sensor](Illuminance-/Illuminance_Sensor.md)
* [Imbalance_Sensor](Imbalance-/Imbalance_Sensor.md)
* [Luminance_Sensor](Luminance-.md)
* [Motion_Sensor](Motion-/Motion_Sensor.md)
* [Occupancy_Count_Sensor](Occupancy_Count-.md)
* [Occupancy_Sensor](Occupancy-.md)
* [Piezoelectric_Sensor](Piezoelectric-.md)
* [Position_Sensor](Position-/Position_Sensor.md)
* [Power_Factor_Sensor](Power_Factor-.md)
* [Power_Sensor](Power-/Power_Sensor.md)
* [Pressure_Sensor](Pressure-/Pressure_Sensor.md)
* [Rain_Level_Sensor](Rain_Level-.md)
* [Refrigerant_Level_Sensor](Refrigerant_Level-.md)
* [Solar_Radiance_Sensor](Solar_Radiance-.md)
* [Speed_Sensor](Speed-/Speed_Sensor.md)
* [Temperature_Sensor](Temperature-/Temperature_Sensor.md)
* [Torque_Sensor](Torque-/Torque_Sensor.md)
* [Usage_Sensor](Usage-/Usage_Sensor.md)
* [Voltage_Sensor](Voltage-/Voltage_Sensor.md)
* [Water_Level_Sensor](Water_Level-/Water_Level_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name

---

## Target Of
### General
* [Point](../Point.md).isPointOf
* [Agent](../../Agent/Agent.md).owns
* [Space](../../Space/Space.md).isLocationOf
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [System](../../Collection/System/System.md).includes
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../Asset/Asset.md).hasPoint
* [ExceptionEvent](../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
