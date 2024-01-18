[Index](../../../index.md) > [Event](../../Event.md) > [PointEvent](../PointEvent.md) > [ObservationEvent](#)
# ObservationEvent

**Display name:** Observation event<br />
**DTMI:** dtmi:org:w3id:rec:ObservationEvent;1

---

## Child interfaces
* [AbsoluteHumidityObservation](AbsoluteHumidityObservation.md)
* [AccelerationObservation](AccelerationObservation.md)
* [AngleObservation](AngleObservation.md)
* [AngularAccelerationObservation](AngularAccelerationObservation.md)
* [AngularVelocityObservation](AngularVelocityObservation.md)
* [AreaObservation](AreaObservation.md)
* [BooleanValueObservation](BooleanValueObservation.md)
* [CapacitanceObservation](CapacitanceObservation.md)
* [DataRateObservation](DataRateObservation.md)
* [DataSizeObservation](DataSizeObservation.md)
* [DensityObservation](DensityObservation.md)
* [DistanceObservation](DistanceObservation.md)
* [DoubleValueObservation](DoubleValueObservation.md)
* [ElectricChargeObservation](ElectricChargeObservation.md)
* [ElectricCurrentObservation](ElectricCurrentObservation.md)
* [EnergyObservation](EnergyObservation.md)
* [ForceObservation](ForceObservation.md)
* [FrequencyObservation](FrequencyObservation.md)
* [IlluminanceObservation](IlluminanceObservation.md)
* [InductanceObservation](InductanceObservation.md)
* [IntegerValueObservation](IntegerValueObservation.md)
* [LengthObservation](LengthObservation.md)
* [LuminanceObservation](LuminanceObservation.md)
* [LuminousFluxObservation](LuminousFluxObservation.md)
* [LuminousIntensityObservation](LuminousIntensityObservation.md)
* [MagneticFluxObservation](MagneticFluxObservation.md)
* [MassFlowRateObservation](MassFlowRateObservation.md)
* [MassObservation](MassObservation.md)
* [PowerObservation](PowerObservation.md)
* [PressureObservation](PressureObservation.md)
* [RelativeHumidityObservation](RelativeHumidityObservation.md)
* [ResistanceObservation](ResistanceObservation.md)
* [SoundPressureObservation](SoundPressureObservation.md)
* [TemperatureObservation](TemperatureObservation.md)
* [ThrustObservation](ThrustObservation.md)
* [TimeSpanObservation](TimeSpanObservation.md)
* [TorqueObservation](TorqueObservation.md)
* [VelocityObservation](VelocityObservation.md)
* [VoltageObservation](VoltageObservation.md)
* [VolumeFlowRateObservation](VolumeFlowRateObservation.md)
* [VolumeObservation](VolumeObservation.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|sourcePoint|**en**: source point|**en**: The brick:Point that emitted this observation.|0-1|[Point](../../../Point/Point.md)||True|

---

## Properties

### Inherited Properties
* **[Event](../../Event.md):** customProperties, customTags, end, identifiers, name, start, timestamp

---

## Target Of
### General
* [Point](../../../Point/Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [System](../../../Collection/System/System.md).includes
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [Lease](../../Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
