[Index](../../index.md) > [Point](../Point.md) > [Command](#)
# Command

**Display name:** Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Command;1

---

## Child interfaces
* [Boiler_Command](Boiler_Command.md)
* [Bypass_Command](Bypass_Command.md)
* [Cooling_Command](Cooling_Command.md)
* [Direction_Command](Direction_Command.md)
* [Heating_Command](Heating_Command.md)
* [Humidify_Command](Humidify_Command.md)
* [Lead_Lag_Command](Lead_Lag_Command.md)
* [Light_Command](Light_Command.md)
* [Luminance_Command](Luminance_Command.md)
* [Occupancy_Command](Occupancy_Command.md)
* [Preheat_Command](Preheat_Command.md)
* [Pump_Command](Pump_Command.md)
* [Relay_Command](Relay_Command.md)
* [Speed_Command](Speed_Command.md)
* [Tint_Command](Tint_Command.md)
* [Damper_Command](Damper_Command/Damper_Command.md)
* [Disable_Command](Disable_Command/Disable_Command.md)
* [Enable_Command](Enable_Command/Enable_Command.md)
* [Fan_Command](Fan_Command/Fan_Command.md)
* [Frequency_Command](Frequency_Command/Frequency_Command.md)
* [Load_Shed_Command](Load_Shed_Command/Load_Shed_Command.md)
* [Mode_Command](Mode_Command/Mode_Command.md)
* [On_Off_Command](On_Off_Command/On_Off_Command.md)
* [Override_Command](Override_Command/Override_Command.md)
* [Position_Command](Position_Command/Position_Command.md)
* [Reset_Command](Reset_Command/Reset_Command.md)
* [Valve_Command](Valve_Command/Valve_Command.md)

---

## Relationships

### Inherited Relationships
* **[Point](../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|lastKnownValue|**en**: last known value||Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
### Inherited Properties
* **[Point](../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, name

---

## Target Of
### Inherited
* [Asset](../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../Space/Architecture/Architecture.md).hasPoint
