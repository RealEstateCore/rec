[Index](../../../../index.md) > [Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Reset_Setpoint](../Reset_Setpoint.md) > [Temperature_High_Reset_Setpoint](#)
# Temperature_High_Reset_Setpoint

**Display name:** Temperature High Reset Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_High_Reset_Setpoint;1

---

## Child interfaces
* [Return_Air_Temperature_High_Reset_Setpoint](Return_Air_Temperature_High_Reset_Setpoint.md)
* [Supply_Air_Temperature_High_Reset_Setpoint](Supply_Air_Temperature_High_Reset_Setpoint.md)
* [Outside_Air_Temperature_High_Reset_Setpoint](Outside_Air_Temperature_High_Reset_Setpoint.md)
* [Leaving_Hot_Water_Temperature_High_Reset_Setpoint](Leaving_Hot_Water_Temperature_High_Reset_Setpoint/Leaving_Hot_Water_Temperature_High_Reset_Setpoint.md)
* [Entering_Hot_Water_Temperature_High_Reset_Setpoint](Entering_Hot_Water_Temperature_High_Reset_Setpoint/Entering_Hot_Water_Temperature_High_Reset_Setpoint.md)

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
