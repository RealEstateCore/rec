# ODR 004 Introduction of Space:Wing

## Context

With the release of Brick 1.4 the brick:Location domain will be deprecated in favour of rec:Space. All Brick:location classes are already covered in REC except for brick:Wing. This ODR introduces the Wing concept in REC for future compatibility reasons.

## Decision

A new class rec:Wing is introduced as subclass to the rec:SubBuilding.

## Consequences

Applications that uses the brick:Wing class can continue to use the building wing abstraction albeit in the REC namespace as rec:Wing.

Note; For new application REC recommends to use the rec:SubBuilding generalization of various building components such as towers, wings etc.
