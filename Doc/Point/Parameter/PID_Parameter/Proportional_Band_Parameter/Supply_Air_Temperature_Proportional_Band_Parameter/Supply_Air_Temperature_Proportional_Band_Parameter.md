[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Proportional_Band_Parameter](../Proportional_Band_Parameter.md) > [Supply_Air_Temperature_Proportional_Band_Parameter](#)
# Supply_Air_Temperature_Proportional_Band_Parameter

**Display name:** Supply Air Temperature Proportional Band Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Temperature_Proportional_Band_Parameter;1

---

## Child interfaces
* [Cooling_Supply_Air_Temperature_Proportional_Band_Parameter](Cooling_Supply_Air_Temperature_Proportional_Band_Parameter.md)
* [Heating_Supply_Air_Temperature_Proportional_Band_Parameter](Heating_Supply_Air_Temperature_Proportional_Band_Parameter.md)

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
* [ActuationEvent](../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../Space/Architecture/Architecture.md).hasPoint
