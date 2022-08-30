[Index](../../../../Index.md) > [Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Temperature_Parameter](../Temperature_Parameter.md) > [Lockout_Temperature_Differential_Parameter](#)
# Lockout_Temperature_Differential_Parameter

**Display name:** Lockout Temperature Differential Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Lockout_Temperature_Differential_Parameter;1

---

## Child interfaces
* [Outside_Air_Lockout_Temperature_Differential_Parameter](Outside_Air_Lockout_Temperature_Differential_Parameter/Outside_Air_Lockout_Temperature_Differential_Parameter.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Point](../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
