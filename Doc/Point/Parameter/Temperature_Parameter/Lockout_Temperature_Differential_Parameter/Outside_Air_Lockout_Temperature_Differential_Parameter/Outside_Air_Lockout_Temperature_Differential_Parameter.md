[Index](../../../../../index.md) > [Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Temperature_Parameter](../../Temperature_Parameter.md) > [Lockout_Temperature_Differential_Parameter](../Lockout_Temperature_Differential_Parameter.md) > [Outside_Air_Lockout_Temperature_Differential_Parameter](#)
# Outside_Air_Lockout_Temperature_Differential_Parameter

**Display name:** Outside Air Lockout Temperature Differential Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Outside_Air_Lockout_Temperature_Differential_Parameter;1

---

## Child interfaces
* [High_Outside_Air_Lockout_Temperature_Differential_Parameter](High_Outside_Air_Lockout_Temperature_Differential_Parameter.md)
* [Low_Outside_Air_Lockout_Temperature_Differential_Parameter](Low_Outside_Air_Lockout_Temperature_Differential_Parameter.md)

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