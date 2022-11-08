[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Parameter](../../../../Parameter.md) > [PID_Parameter](../../../PID_Parameter.md) > [Time_Parameter](../../Time_Parameter.md) > [Integral_Time_Parameter](../Integral_Time_Parameter.md) > [Air_Temperature_Integral_Time_Parameter](#)
# Air_Temperature_Integral_Time_Parameter

**Display name:** Air Temperature Integral Time Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Temperature_Integral_Time_Parameter;1

---

## Child interfaces
* [Cooling_Discharge_Air_Temperature_Integral_Time_Parameter](Cooling_Discharge_Air_Temperature_Integral_Time_Parameter.md)
* [Heating_Supply_Air_Temperature_Integral_Time_Parameter](Heating_Supply_Air_Temperature_Integral_Time_Parameter.md)
* [Heating_Discharge_Air_Temperature_Integral_Time_Parameter](Heating_Discharge_Air_Temperature_Integral_Time_Parameter.md)
* [Cooling_Supply_Air_Temperature_Integral_Time_Parameter](Cooling_Supply_Air_Temperature_Integral_Time_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../../../../Parameter.md):** lastKnownValue
* **[Point](../../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
