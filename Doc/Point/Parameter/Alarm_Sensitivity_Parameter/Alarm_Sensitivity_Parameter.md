[Index](../../../index.md) > [Point](../../Point.md) > [Parameter](../Parameter.md) > [Alarm_Sensitivity_Parameter](#)
# Alarm_Sensitivity_Parameter

A parameter indicates the sensitivity to activate an alarm.


**Display name:** Alarm Sensitivity Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Alarm_Sensitivity_Parameter;1

---

## Child interfaces
* [CO2_Alarm_Sensitivity_Parameter](CO2_Alarm_Sensitivity_Parameter.md)
* [Temperature_Alarm_Sensitivity_Parameter](Temperature_Alarm_Sensitivity_Parameter.md)

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
