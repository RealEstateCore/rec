[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Temperature_Setpoint](../../../Temperature_Setpoint.md) > [Water_Temperature_Setpoint](../../Water_Temperature_Setpoint.md) > [Hot_Water_Temperature_Setpoint](../Hot_Water_Temperature_Setpoint.md) > [Domestic_Hot_Water_Temperature_Setpoint](#)
# Domestic_Hot_Water_Temperature_Setpoint

Sets temperature of domestic hot water


**Display name:** Domestic Hot Water Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Domestic_Hot_Water_Temperature_Setpoint;1

---

## Child interfaces
* [Leaving_Domestic_Hot_Water_Temperature_Setpoint](Leaving_Domestic_Hot_Water_Temperature_Setpoint.md)
* [Entering_Domestic_Hot_Water_Temperature_Setpoint](Entering_Domestic_Hot_Water_Temperature_Setpoint.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Setpoint](../../../../Setpoint.md):** lastKnownValue
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
