[Index](../../../Index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Humidity_Parameter](#)
# Humidity_Parameter

**Display name:** Humidity Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Humidity_Parameter;1

---

## Child interfaces
* [High_Humidity_Alarm_Parameter](High_Humidity_Alarm_Parameter.md)
* [Humidity_Tolerance_Parameter](../Tolerance_Parameter/Humidity_Tolerance_Parameter.md)
* [Low_Humidity_Alarm_Parameter](Low_Humidity_Alarm_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
