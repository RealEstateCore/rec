[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Parameter](../../../../Parameter.md) > [PID_Parameter](../../../PID_Parameter.md) > [Step_Parameter](../../Step_Parameter.md) > [Static_Pressure_Step_Parameter](../Static_Pressure_Step_Parameter.md) > [Air_Static_Pressure_Step_Parameter](#)
# Air_Static_Pressure_Step_Parameter

**Display name:** Air Static Pressure Step Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Static_Pressure_Step_Parameter;1

---

## Child interfaces
* [Supply_Air_Static_Pressure_Step_Parameter](Supply_Air_Static_Pressure_Step_Parameter.md)
* [Discharge_Air_Static_Pressure_Step_Parameter](Discharge_Air_Static_Pressure_Step_Parameter.md)

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
