[Index](../../../../index.md) > [Point](../../../Point.md) > [Status](../../Status.md) > [Load_Shed_Status](../Load_Shed_Status.md) > [Entering_Hot_Water_Temperature_Load_Shed_Status](#)
# Entering_Hot_Water_Temperature_Load_Shed_Status

**Display name:** Entering Hot Water Temperature Load Shed Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Entering_Hot_Water_Temperature_Load_Shed_Status;1

---

## Child interfaces
* [Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Status](Entering_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Status.md)

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
* [ActuationEvent](../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../Space/Architecture/Architecture.md).hasPoint
