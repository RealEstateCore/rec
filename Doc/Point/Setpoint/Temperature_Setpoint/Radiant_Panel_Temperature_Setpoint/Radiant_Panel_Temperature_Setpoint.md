[Index](../../../../Index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Temperature_Setpoint](../Temperature_Setpoint.md) > [Radiant_Panel_Temperature_Setpoint](#)
# Radiant_Panel_Temperature_Setpoint

**Display name:** Radiant Panel Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Radiant_Panel_Temperature_Setpoint;1

---

## Child interfaces
* [Inside_Face_Surface_Temperature_Setpoint](Inside_Face_Surface_Temperature_Setpoint.md)
* [Outside_Face_Surface_Temperature_Setpoint](Outside_Face_Surface_Temperature_Setpoint.md)
* [Embedded_Temperature_Setpoint](Embedded_Temperature_Setpoint/Embedded_Temperature_Setpoint.md)

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
