[Index](../../../index.md) > [Point](../../Point.md) > [Alarm](../Alarm.md) > [Air_Alarm](#)
# Air_Alarm

**Display name:** Air Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Alarm;1

---

## Child interfaces
* [Air_Flow_Alarm](Air_Flow_Alarm/Air_Flow_Alarm.md)
* [Air_Temperature_Alarm](../Temperature_Alarm/Air_Temperature_Alarm/Air_Temperature_Alarm.md)
* [Discharge_Air_Smoke_Detection_Alarm](../Smoke_Alarm/Smoke_Detection_Alarm/Discharge_Air_Smoke_Detection_Alarm.md)
* [Supply_Air_Smoke_Detection_Alarm](../Smoke_Alarm/Smoke_Detection_Alarm/Supply_Air_Smoke_Detection_Alarm.md)

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
