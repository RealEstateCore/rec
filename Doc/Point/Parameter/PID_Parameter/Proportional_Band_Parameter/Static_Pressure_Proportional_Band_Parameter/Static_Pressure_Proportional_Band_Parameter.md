[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Proportional_Band_Parameter](../Proportional_Band_Parameter.md) > [Static_Pressure_Proportional_Band_Parameter](#)
# Static_Pressure_Proportional_Band_Parameter

**Display name:** Static Pressure Proportional Band Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Static_Pressure_Proportional_Band_Parameter;1

---

## Child interfaces
* [Discharge_Air_Static_Pressure_Proportional_Band_Parameter](Discharge_Air_Static_Pressure_Proportional_Band_Parameter.md)
* [Exhaust_Air_Static_Pressure_Proportional_Band_Parameter](Exhaust_Air_Static_Pressure_Proportional_Band_Parameter.md)
* [Supply_Air_Static_Pressure_Proportional_Band_Parameter](Supply_Air_Static_Pressure_Proportional_Band_Parameter.md)

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
