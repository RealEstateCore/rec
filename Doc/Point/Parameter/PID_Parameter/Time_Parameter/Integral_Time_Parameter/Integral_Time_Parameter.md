[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Time_Parameter](../Time_Parameter.md) > [Integral_Time_Parameter](#)
# Integral_Time_Parameter

**Display name:** Integral Time Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Integral_Time_Parameter;1

---

## Child interfaces
* [Entering_Water_Temperature_Integral_Time_Parameter](Entering_Water_Temperature_Integral_Time_Parameter.md)
* [Leaving_Water_Temperature_Integral_Time_Parameter](Leaving_Water_Temperature_Integral_Time_Parameter.md)
* [Air_Temperature_Integral_Time_Parameter](Air_Temperature_Integral_Time_Parameter/Air_Temperature_Integral_Time_Parameter.md)
* [Differential_Pressure_Integral_Time_Parameter](Differential_Pressure_Integral_Time_Parameter/Differential_Pressure_Integral_Time_Parameter.md)
* [Static_Pressure_Integral_Time_Parameter](Static_Pressure_Integral_Time_Parameter/Static_Pressure_Integral_Time_Parameter.md)
* [Exhaust_Air_Flow_Integral_Time_Parameter](Exhaust_Air_Flow_Integral_Time_Parameter/Exhaust_Air_Flow_Integral_Time_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../../../Parameter.md):** lastKnownValue
* **[Point](../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
