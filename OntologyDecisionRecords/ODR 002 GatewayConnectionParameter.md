# ODR 002: GatewayConnectionParameter

## Context

An IoT [Gateway](../Doc/Asset/Equipment/ICT-/Gateway.md) is a device responsible for handling transfer data to different communication protocols. A modern IoT gateway enables bidirectional communication.

In the case that a cloud service needs to send a cloud-to-device message to the gateway, the connection information needed to accomplish this could be represented as a [Parameter](../Doc/Point/Parameter/Parameter.md).

## Decisions

1. We will create a [GatewayConnectionParameter](../Doc/Point/Parameter/GatewayConnection-/GatewayConnectionParameter.md) that uses the REC DTMI `dtmi:org:w3id:rec:GatewayConnectionParameter;1`.

1. We will NOT model security credentials in the connection parameters; it is recommended that a key vault, or similar technology, is used to store credentials.

## Consequences

Application services will need to implement application logic to support the different model extensions.

Application services will be responsible for securing the appropriate authorization to send messages. The GatewayConnectionParameters just provide configuration parameters.