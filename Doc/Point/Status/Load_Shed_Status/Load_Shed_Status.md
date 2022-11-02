[Index](../../../index.md) > [Point](../../Point.md) > [Status](../Status.md) > [Load_Shed_Status](#)
# Load_Shed_Status

Indicates if a load shedding policy is in effect


**Display name:** Load Shed Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Shed_Status;1

---

## Child interfaces
* [Entering_Hot_Water_Temperature_Load_Shed_Status](Entering_Hot_Water_Temperature_Load_Shed_Status/Entering_Hot_Water_Temperature_Load_Shed_Status.md)
* [Leaving_Hot_Water_Temperature_Load_Shed_Status](Leaving_Hot_Water_Temperature_Load_Shed_Status/Leaving_Hot_Water_Temperature_Load_Shed_Status.md)
* [Differential_Pressure_Load_Shed_Status](../Pressure_Status/Differential_Pressure_Load_Shed_Status/Differential_Pressure_Load_Shed_Status.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Status](../Status.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
