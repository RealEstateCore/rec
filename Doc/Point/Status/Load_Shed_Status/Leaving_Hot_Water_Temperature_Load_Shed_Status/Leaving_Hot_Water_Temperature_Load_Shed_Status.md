[Index](../../../../Index.md) > [Point](../../../Point.md) > [Status](../../Status.md) > [Load_Shed_Status](../Load_Shed_Status.md) > [Leaving_Hot_Water_Temperature_Load_Shed_Status](#)
# Leaving_Hot_Water_Temperature_Load_Shed_Status

**Display name:** Leaving Hot Water Temperature Load Shed Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Hot_Water_Temperature_Load_Shed_Status;1

---

## Child interfaces
* [Leaving_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Status](Leaving_Medium_Temperature_Hot_Water_Temperature_Load_Shed_Status.md)

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
