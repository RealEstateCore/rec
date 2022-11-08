[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Flow_Setpoint](../../../Flow_Setpoint.md) > [Air_Flow_Setpoint](../../Air_Flow_Setpoint.md) > [Supply_Air_Flow_Setpoint](../Supply_Air_Flow_Setpoint.md) > [Occupied_Supply_Air_Flow_Setpoint](#)
# Occupied_Supply_Air_Flow_Setpoint

Sets supply air flow rate when occupied


**Display name:** Occupied Supply Air Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Occupied_Supply_Air_Flow_Setpoint;1

---

## Child interfaces
* [Occupied_Cooling_Supply_Air_Flow_Setpoint](Occupied_Cooling_Supply_Air_Flow_Setpoint.md)
* [Occupied_Heating_Supply_Air_Flow_Setpoint](Occupied_Heating_Supply_Air_Flow_Setpoint.md)

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
### General
* [Point](../../../../../Point.md).isPointOf
* [Space](../../../../../../Space/Space.md).isLocationOf
* [Agent](../../../../../../Agent/Agent.md).owns
* [EquipmentCollection](../../../../../../Collection/EquipmentCollection.md).feeds
* [Portfolio](../../../../../../Collection/Portfolio.md).includes
* [Lease](../../../../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../../../../Information/PointOfInterest.md).objectOfInterest
* [Equipment](../../../../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../../../../Asset/Equipment/Equipment.md).isFedBy
* [Document](../../../../../../Information/Document/Document.md).documentTopic
* [Document](../../../../../../Information/Document/Document.md).url
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Architecture](../../../../../../Space/Architecture/Architecture.md).isFedBy
* [Meter](../../../../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [Asset](../../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../../Collection/EquipmentCollection.md).hasPoint
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../../Space/Architecture/Architecture.md).hasPoint
* [ActuationEvent](../../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ObservationEvent](../../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ExceptionEvent](../../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
