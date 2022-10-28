[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Emergency_Alarm](#)
# Emergency_Alarm

Alarms that indicate off-normal conditions associated with emergency systems


**Display name:** Emergency Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Emergency_Alarm;1

---

## Child interfaces
* [Emergency_Generator_Alarm](Emergency_Generator_Alarm.md)

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
