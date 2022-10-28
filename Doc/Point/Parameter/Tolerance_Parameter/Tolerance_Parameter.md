[Index](../../../index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Tolerance_Parameter](#)
# Tolerance_Parameter

difference between upper and lower limits of size for a given nominal dimension or value.


**Display name:** Tolerance Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Tolerance_Parameter;1

---

## Child interfaces
* [Humidity_Tolerance_Parameter](Humidity_Tolerance_Parameter.md)
* [Temperature_Tolerance_Parameter](Temperature_Tolerance_Parameter.md)

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
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
