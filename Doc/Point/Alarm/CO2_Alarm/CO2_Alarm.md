[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [CO2_Alarm](#)
# CO2_Alarm

An alarm that indicates the off-normal conditions associated with the presence of carbon dioxide.


**Display name:** CO2 Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:CO2_Alarm;1

---

## Child interfaces
* [High_CO2_Alarm](High_CO2_Alarm.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Alarm](../Alarm.md):** lastKnownValue
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
