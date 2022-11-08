[Index](../../../../index.md) > [Point](../../../Point.md) > [Status](../../Status.md) > [On_Status](../On_Status.md) > [On_Off_Status](#)
# On_Off_Status

Indicates the on/off status of a control loop, relay or equipment


**Display name:** On Off Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:On_Off_Status;1

---

## Child interfaces
* [Pump_On_Off_Status](Pump_On_Off_Status.md)
* [Remotely_On_Off_Status](Remotely_On_Off_Status.md)
* [Locally_On_Off_Status](Locally_On_Off_Status.md)
* [Motor_On_Off_Status](Motor_On_Off_Status.md)
* [Fan_On_Off_Status](Fan_On_Off_Status.md)
* [Start_Stop_Status](Start_Stop_Status/Start_Stop_Status.md)
* [Standby_Unit_On_Off_Status](Standby_Unit_On_Off_Status/Standby_Unit_On_Off_Status.md)

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
