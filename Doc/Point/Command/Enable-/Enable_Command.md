[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Enable_Command](#)
# Enable_Command

Commands that enable functionality


**Display name:** Enable Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Enable_Command;1

---

## Child interfaces
* [Cooling_Enable_Command](Cooling-.md)
* [Enable_Differential_Enthalpy_Command](Enable_Differential_Enthalpy_Command.md)
* [Enable_Differential_Temperature_Command](Enable_Differential_Temperature_Command.md)
* [Enable_Fixed_Enthalpy_Command](Enable_Fixed_Enthalpy_Command.md)
* [Enable_Fixed_Temperature_Command](Enable_Fixed_Temperature_Command.md)
* [Heating_Enable_Command](Heating-.md)
* [Run_Enable_Command](Run-.md)
* [Stage_Enable_Command](Stage-.md)
* [System_Enable_Command](System-/System_Enable_Command.md)
* [VFD_Enable_Command](VFD-.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Command](../Command.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customProperties, customTags, hasQuantity, hasSubstance, identifiers, name

---

## Target Of
### General
* [Point](../../Point.md).isPointOf
* [Agent](../../../Agent/Agent.md).owns
* [Space](../../../Space/Space.md).isLocationOf
* [Equipment](../../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../../Space/Architecture/Architecture.md).isFedBy
* [Document](../../../Information/Document/Document.md).documentTopic
* [Document](../../../Information/Document/Document.md).url
* [EquipmentCollection](../../../Collection/Equipment-.md).feeds
* [Lease](../../../Event/Lease.md).leaseOf
* [PointOfInterest](../../../Information/PointOfInterest.md).objectOfInterest
* [Portfolio](../../../Collection/Portfolio.md).includes
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).relatedTo
* [Meter](../../../Asset/Equipment/Meter/Meter.md).meters
### Inherited
* [ActuationEvent](../../../Event/Point-/ActuationEvent.md).targetPoint
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/Equipment-.md).hasPoint
* [ExceptionEvent](../../../Event/Point-/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/Point-/ObservationEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
