[Index](../../../../../../index.md) > [Point](../../../../../Point.md) > [Parameter](../../../../Parameter.md) > [Limit](../../../Limit.md) > [Max_Limit](../../Max_Limit.md) > [Max_Air_Flow_Setpoint_Limit](../Max_Air_Flow_Setpoint_Limit.md) > [Max_Heating_Discharge_Air_Flow_Setpoint_Limit](#)
# Max_Heating_Discharge_Air_Flow_Setpoint_Limit

A parameter that places an upper bound on the range of permitted values of a Heating_Discharge_Air_Flow_Setpoint.


**Display name:** Max Heating Discharge Air Flow Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Max_Heating_Discharge_Air_Flow_Setpoint_Limit;1

---

## Child interfaces
* [Max_Occupied_Heating_Discharge_Air_Flow_Setpoint_Limit](Max_Occupied_Heating_Discharge_Air_Flow_Setpoint_Limit.md)
* [Max_Unoccupied_Heating_Discharge_Air_Flow_Setpoint_Limit](Max_Unoccupied_Heating_Discharge_Air_Flow_Setpoint_Limit.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Parameter](../../../../Parameter.md):** lastKnownValue
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
