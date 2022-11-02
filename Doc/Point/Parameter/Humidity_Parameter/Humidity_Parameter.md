[Index](../../../index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Humidity_Parameter](#)
# Humidity_Parameter

Parameters relevant to humidity-related systems and points


**Display name:** Humidity Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Humidity_Parameter;1

---

## Child interfaces
* [Humidity_Tolerance_Parameter](../Tolerance_Parameter/Humidity_Tolerance_Parameter.md)
* [Low_Humidity_Alarm_Parameter](Low_Humidity_Alarm_Parameter.md)
* [High_Humidity_Alarm_Parameter](High_Humidity_Alarm_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../Parameter.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
