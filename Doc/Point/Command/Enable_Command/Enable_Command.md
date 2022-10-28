[Index](../../../index.md) > [Point](../../Point.md) > [Command](../Command.md) > [Enable_Command](#)
# Enable_Command

**Display name:** Enable Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Enable_Command;1

---

## Child interfaces
* [Cooling_Enable_Command](Cooling_Enable_Command.md)
* [Enable_Differential_Enthalpy_Command](Enable_Differential_Enthalpy_Command.md)
* [Enable_Differential_Temperature_Command](Enable_Differential_Temperature_Command.md)
* [Enable_Fixed_Enthalpy_Command](Enable_Fixed_Enthalpy_Command.md)
* [Enable_Fixed_Temperature_Command](Enable_Fixed_Temperature_Command.md)
* [Heating_Enable_Command](Heating_Enable_Command.md)
* [Run_Enable_Command](Run_Enable_Command.md)
* [Stage_Enable_Command](Stage_Enable_Command.md)
* [VFD_Enable_Command](VFD_Enable_Command.md)
* [System_Enable_Command](System_Enable_Command/System_Enable_Command.md)

---

## Relationships

### Inherited Relationships
* **[Point](../../Point.md):** isPointOf

---

## Properties

### Inherited Properties
* **[Command](../Command.md):** lastKnownValue
* **[Point](../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../Space/Architecture/Architecture.md).hasPoint
