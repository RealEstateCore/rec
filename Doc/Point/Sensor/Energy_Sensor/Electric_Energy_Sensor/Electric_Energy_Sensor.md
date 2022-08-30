[Index](../../../../Index.md) > [Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Energy_Sensor](../Energy_Sensor.md) > [Electric_Energy_Sensor](#)
# Electric_Energy_Sensor

**Display name:** Electric Energy Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Electric_Energy_Sensor;1

---

## Child interfaces
* [Reactive_Energy_Sensor](Reactive_Energy_Sensor.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

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
