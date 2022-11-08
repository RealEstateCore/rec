[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Pressure_Setpoint](../Pressure_Setpoint.md) > [Static_Pressure_Setpoint](#)
# Static_Pressure_Setpoint

Sets static pressure


**Display name:** Static Pressure Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Static_Pressure_Setpoint;1

---

## Child interfaces
* [Underfloor_Air_Plenum_Static_Pressure_Setpoint](Underfloor_Air_Plenum_Static_Pressure_Setpoint.md)
* [Exhaust_Air_Static_Pressure_Setpoint](Exhaust_Air_Static_Pressure_Setpoint.md)
* [Building_Air_Static_Pressure_Setpoint](Building_Air_Static_Pressure_Setpoint.md)
* [Hot_Water_Static_Pressure_Setpoint](Hot_Water_Static_Pressure_Setpoint.md)
* [Chilled_Water_Static_Pressure_Setpoint](Chilled_Water_Static_Pressure_Setpoint.md)
* [Discharge_Air_Static_Pressure_Setpoint](Discharge_Air_Static_Pressure_Setpoint/Discharge_Air_Static_Pressure_Setpoint.md)
* [Supply_Air_Static_Pressure_Setpoint](Supply_Air_Static_Pressure_Setpoint/Supply_Air_Static_Pressure_Setpoint.md)
* [Static_Pressure_Deadband_Setpoint](Static_Pressure_Deadband_Setpoint/Static_Pressure_Deadband_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../../Setpoint.md):** lastKnownValue
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
