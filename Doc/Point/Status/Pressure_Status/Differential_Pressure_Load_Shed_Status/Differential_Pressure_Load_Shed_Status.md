[Index](../../../../index.md) > [Point](../../../Point.md) > [Status](../../Status.md) > [Pressure_Status](../Pressure_Status.md) > [Differential_Pressure_Load_Shed_Status](#)
# Differential_Pressure_Load_Shed_Status

**Display name:** Differential Pressure Load Shed Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Pressure_Load_Shed_Status;1

---

## Child interfaces
* [Chilled_Water_Differential_Pressure_Load_Shed_Status](Chilled_Water_Differential_Pressure_Load_Shed_Status/Chilled_Water_Differential_Pressure_Load_Shed_Status.md)
* [Hot_Water_Differential_Pressure_Load_Shed_Status](Hot_Water_Differential_Pressure_Load_Shed_Status/Hot_Water_Differential_Pressure_Load_Shed_Status.md)
* [Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Status](Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Status/Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Status.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Status](../../Status.md):** lastKnownValue
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
