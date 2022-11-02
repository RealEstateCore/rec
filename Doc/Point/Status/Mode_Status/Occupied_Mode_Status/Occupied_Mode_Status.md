[Index](../../../../index.md) > [Point](../../../Point.md) > [Status](../../Status.md) > [Mode_Status](../Mode_Status.md) > [Occupied_Mode_Status](#)
# Occupied_Mode_Status

Indicates if a system, device or control loop is in "Occupied" mode


**Display name:** Occupied Mode Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Occupied_Mode_Status;1

---

## Child interfaces
* [Occupied_Cooling_Mode_Status](Occupied_Cooling_Mode_Status.md)
* [Occupied_Heating_Mode_Status](Occupied_Heating_Mode_Status.md)

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
