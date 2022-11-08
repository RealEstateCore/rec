[Index](../../../../index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Flow_Sensor](../Flow_Sensor.md) > [Air_Flow_Sensor](#)
# Air_Flow_Sensor

Measures the rate of flow of air


**Display name:** Air Flow Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Flow_Sensor;1

---

## Child interfaces
* [Mixed_Air_Flow_Sensor](Mixed_Air_Flow_Sensor.md)
* [Return_Air_Flow_Sensor](Return_Air_Flow_Sensor.md)
* [Outside_Air_Flow_Sensor](Outside_Air_Flow_Sensor.md)
* [Fume_Hood_Air_Flow_Sensor](Fume_Hood_Air_Flow_Sensor.md)
* [Bypass_Air_Flow_Sensor](Bypass_Air_Flow_Sensor.md)
* [Supply_Air_Flow_Sensor](Supply_Air_Flow_Sensor/Supply_Air_Flow_Sensor.md)
* [Exhaust_Air_Flow_Sensor](Exhaust_Air_Flow_Sensor/Exhaust_Air_Flow_Sensor.md)
* [Discharge_Air_Flow_Sensor](Discharge_Air_Flow_Sensor/Discharge_Air_Flow_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Flow_Sensor](../Flow_Sensor.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### General
* [Point](../../../Point.md).isPointOf
* [Space](../../../../Space/Space.md).isLocationOf
* [Agent](../../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../../Collection/Portfolio.md).includes
* [Lease](../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../Information/Document/Document.md).url
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
