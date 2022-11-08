[Index](../../index.md) > [Point](../Point.md) > [Sensor](#)
# Sensor

A Sensor is an input point that represents the value of a device or instrument designed to detect and measure a variable (ASHRAE Dictionary).


**Display name:** Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Sensor;1

---

## Child interfaces
* [Contact_Sensor](Contact_Sensor.md)
* [Rain_Level_Sensor](Rain_Level_Sensor.md)
* [Occupancy_Count_Sensor](Occupancy_Count_Sensor.md)
* [Solar_Radiance_Sensor](Solar_Radiance_Sensor.md)
* [Hail_Sensor](Hail_Sensor.md)
* [Capacity_Sensor](Capacity_Sensor.md)
* [Luminance_Sensor](Luminance_Sensor.md)
* [Frost_Sensor](Frost_Sensor.md)
* [Gas_Sensor](Gas_Sensor.md)
* [Occupancy_Sensor](Occupancy_Sensor.md)
* [Refrigerant_Level_Sensor](Refrigerant_Level_Sensor.md)
* [Fire_Sensor](Fire_Sensor.md)
* [Power_Factor_Sensor](Power_Factor_Sensor.md)
* [Piezoelectric_Sensor](Piezoelectric_Sensor.md)
* [Demand_Sensor](Demand_Sensor/Demand_Sensor.md)
* [Enthalpy_Sensor](Enthalpy_Sensor/Enthalpy_Sensor.md)
* [Duration_Sensor](Duration_Sensor/Duration_Sensor.md)
* [Air_Quality_Sensor](Air_Quality_Sensor/Air_Quality_Sensor.md)
* [Imbalance_Sensor](Imbalance_Sensor/Imbalance_Sensor.md)
* [Direction_Sensor](Direction_Sensor/Direction_Sensor.md)
* [Voltage_Sensor](Voltage_Sensor/Voltage_Sensor.md)
* [Current_Sensor](Current_Sensor/Current_Sensor.md)
* [Torque_Sensor](Torque_Sensor/Torque_Sensor.md)
* [Pressure_Sensor](Pressure_Sensor/Pressure_Sensor.md)
* [Power_Sensor](Power_Sensor/Power_Sensor.md)
* [Frequency_Sensor](Frequency_Sensor/Frequency_Sensor.md)
* [Flow_Sensor](Flow_Sensor/Flow_Sensor.md)
* [Adjust_Sensor](Adjust_Sensor/Adjust_Sensor.md)
* [Position_Sensor](Position_Sensor/Position_Sensor.md)
* [Usage_Sensor](Usage_Sensor/Usage_Sensor.md)
* [Angle_Sensor](Angle_Sensor/Angle_Sensor.md)
* [Illuminance_Sensor](Illuminance_Sensor/Illuminance_Sensor.md)
* [Conductivity_Sensor](Conductivity_Sensor/Conductivity_Sensor.md)
* [Speed_Sensor](Speed_Sensor/Speed_Sensor.md)
* [Dewpoint_Sensor](Dewpoint_Sensor/Dewpoint_Sensor.md)
* [Heat_Sensor](Heat_Sensor/Heat_Sensor.md)
* [Motion_Sensor](Motion_Sensor/Motion_Sensor.md)
* [Generation_Sensor](Generation_Sensor/Generation_Sensor.md)
* [Energy_Sensor](Energy_Sensor/Energy_Sensor.md)
* [Water_Level_Sensor](Water_Level_Sensor/Water_Level_Sensor.md)
* [Temperature_Sensor](Temperature_Sensor/Temperature_Sensor.md)
* [Humidity_Sensor](Humidity_Sensor/Humidity_Sensor.md)
* [Air_Grains_Sensor](Air_Grains_Sensor/Air_Grains_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### General
* [Point](../Point.md).isPointOf
* [Space](../../Space/Space.md).isLocationOf
* [Agent](../../Agent/Agent.md).owns
* [EquipmentCollection](../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../Collection/Portfolio.md).includes
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../Information/Document/Document.md).documentTopic
* [Document](../../Information/Document/Document.md).url
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../Event/PointEvent/ExceptionEvent.md).sourcePoint
