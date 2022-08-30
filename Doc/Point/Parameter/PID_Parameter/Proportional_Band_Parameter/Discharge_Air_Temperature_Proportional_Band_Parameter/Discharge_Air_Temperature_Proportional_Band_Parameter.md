[Index](../../../../../Index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Proportional_Band_Parameter](../Proportional_Band_Parameter.md) > [Discharge_Air_Temperature_Proportional_Band_Parameter](#)
# Discharge_Air_Temperature_Proportional_Band_Parameter

**Display name:** Discharge Air Temperature Proportional Band Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Proportional_Band_Parameter;1

---

## Child interfaces
* [Cooling_Discharge_Air_Temperature_Proportional_Band_Parameter](Cooling_Discharge_Air_Temperature_Proportional_Band_Parameter.md)
* [Heating_Discharge_Air_Temperature_Proportional_Band_Parameter](Heating_Discharge_Air_Temperature_Proportional_Band_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
