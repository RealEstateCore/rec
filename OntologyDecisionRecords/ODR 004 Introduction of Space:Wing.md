# ODR 004 Introduction of Space:Wing

## Context

With the release of Brick 1.4 the brick:Location domain will be deprecated in favour of rec:Space. All specific Brick location classes but brick:Wing are already covered in REC. This ODR introduces the building Wing concept in REC for future compatibility reasons.

## Decision

An new class rec:Wing is introduced as subclass to the rec:SubBuilding.

## Consequences

Applications that uses the brick:Wing class can continue to use the building wing abstraction albeit in the REC namespace as rec:Wing.

Note; For new application REC recommends to use the rec:SubBuilding generalization of various building components such as towers, wings etc.
