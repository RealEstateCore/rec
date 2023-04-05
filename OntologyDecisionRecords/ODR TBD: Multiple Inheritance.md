# ODR TBD: Multiple Model Inheritance

## Context

While building out the core ontology, there have been scenarios where models have needed to extend multiple models. One example is a device that is a [Gateway](../Doc/Asset/Equipment/ICT-/Gateway.md), a [BACnetController](../Doc/Asset/Equipment/ICT-/Controller/BACnet-/BACnetController.md), and a [ModbusController](../Doc/Asset/Equipment/ICT-/Controller/Modbus-/ModbusController.md).

DTDLv2 has a limitation of only allowing 2 interfaces to be extended. In the above scenario, it makes sense to create a [BACnetAndModbusController](../Doc/Asset/Equipment/ICT-/Controller/BACnet-/BACnetAndModbusController.md). The new model is now able to extend Gateway and BACnetAndModbusController.

## Decisions

1. We will allow models that extend up to 2 other models.
1. We will enable RealEstateCore tools to support multiple inheritance

## Consequences

1. We will need to update DTDL2MD to list out all extended models.
1. We will need to update DTDL2SHACL to handle multiple extensions.